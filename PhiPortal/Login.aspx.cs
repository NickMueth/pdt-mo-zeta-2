using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PhiPortal_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink hplPortal_Login = (HyperLink)this.Master.FindControl("hplPortal_Login");
        hplPortal_Login.Visible = false;

        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PhiPortalUserDB"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM PhiPortalUsers WHERE Username =@Username AND Password =@Password", con);
        cmd.Parameters.AddWithValue("@Username", txtbxUsername.Text);
        cmd.Parameters.AddWithValue("@Password", txtbxPassword.Text);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            FormsAuthentication.RedirectFromLoginPage(txtbxUsername.Text, false);
            Response.Redirect("Home.aspx");
        }
        else
        {
            lblLoginError.Visible = true;
            txtbxUsername.Text = "";
        }
    }
}