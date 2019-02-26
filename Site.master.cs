using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Site : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PhiPortalUserDB"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT FirstName FROM PhiPortalUsers WHERE Username =@Username", con);
        SqlDataReader reader = null;
        cmd.Parameters.AddWithValue("@Username", Context.User.Identity.Name);

        reader = cmd.ExecuteReader();

        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            hplPortal_MainHome.Visible = true;
            hplManageAndWelcome.Visible = true;
            while (reader.Read())
            {
                hplManageAndWelcome.Text = "Welcome " + reader["FirstName"].ToString();
            }
            hplPortal_Logout.Visible = true;
            hplPortal_Login.Visible = false;
        }
    }
}
