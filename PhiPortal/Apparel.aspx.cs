﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PhiPortal_Apparel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUploadApparel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/PhiPortal/UploadApparel/UploadApparel.aspx");
    }
}