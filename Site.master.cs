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
        if (HttpContext.Current.User.Identity.IsAuthenticated)
        {
            hplManageAndWelcome.Visible = true;
            hplManageAndWelcome.Text = "Welcome " + Context.User.Identity.Name;
            hplPortal_Logout.Visible = true;
            hplPortal_Login.Visible = false;
        }
    }
}
