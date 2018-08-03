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

public partial class PhiPortal_Manage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnChange_Click(object sender, EventArgs e)
    {
        SqlConnection passwordConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PhiPortalUserDatabase"].ConnectionString);
        passwordConnection.Open();
        SqlCommand getPassword = new SqlCommand("SELECT * FROM UserInfo WHERE Username =@Username AND Password =@Password", passwordConnection);
        getPassword.Parameters.AddWithValue("@Username", Context.User.Identity.Name);
        getPassword.Parameters.AddWithValue("@Password", txtBoxOldPassword.Text);
        SqlDataAdapter da = new SqlDataAdapter(getPassword);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if(dt.Rows.Count > 0)
        {
            passwordConnection.Close();
            ChangePassword();
        }
        else
        {
            passwordConnection.Close();
            lblSuccessOrError.Visible = true;
            lblSuccessOrError.Text = "ERROR: Invalid Password!";
            lblSuccessOrError.CssClass = "alert alert-danger w-50";
        }



        //LINQ to SQL
    }

    private void ChangePassword()
    {
        if(txtBoxConfirmPassword.Text == txtBoxNewPassword.Text)
        {
            SqlConnection passwordChangeConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PhiPortalUserDatabase"].ConnectionString);
            passwordChangeConnection.Open();
            SqlCommand changePassword = new SqlCommand("UPDATE UserInfo SET Password = '" + txtBoxNewPassword.Text + "' WHERE Username =@Username AND Password =@Password", passwordChangeConnection);
            changePassword.Parameters.AddWithValue("@Username", Context.User.Identity.Name);
            changePassword.Parameters.AddWithValue("@Password", txtBoxOldPassword.Text);

            int queryStatus = changePassword.ExecuteNonQuery();
            if (queryStatus > 0)
            {
                lblSuccessOrError.Visible = true;
                lblSuccessOrError.Text = "Success! Password changed!";
                lblSuccessOrError.CssClass = "alert alert-success w-50";
                passwordChangeConnection.Close();
            }
            else
            {
                lblSuccessOrError.Visible = true;
                lblSuccessOrError.Text = "ERROR: Something went wrong when changing password. Please contact the website administrator.";
                lblSuccessOrError.CssClass = "alert alert-danger w-50";
                passwordChangeConnection.Close();
            }
        }
        else
        {
            lblSuccessOrError.Visible = true;
            lblSuccessOrError.Text = "ERROR: Confirmation of password does not match new password!";
            lblSuccessOrError.CssClass = "alert alert-danger w-50";
        }

        
    }
}