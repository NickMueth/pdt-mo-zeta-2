using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PhiPortal_UploadApparel_UploadApparel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUploadApparel_Click(object sender, EventArgs e)
    {
        if (uplApparelPhoto.HasFile)
        {
            try
            {
                string filename = Path.GetFileName(uplApparelPhoto.FileName);
                uplApparelPhoto.SaveAs(Server.MapPath("~/PhiPortal/ApparelPhotos/") + filename);
                lblUploadStatus.Visible = true;
                lblUploadStatus.CssClass = "bg-success";
                lblUploadStatus.Text = "File uploaded successfully!";
            }
            catch
            {
                lblUploadStatus.Visible = true;
                lblUploadStatus.CssClass = "bg-danger";
                lblUploadStatus.Text = "ERROR: File not uploaded.";
            }
        }
    }
}