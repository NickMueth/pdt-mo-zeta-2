using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string[] FilePaths = Directory.GetFiles(Server.MapPath("~/Images/MemberPhotos/"), "*.jpg");
        //int imgCount = Directory.GetFiles(Server.MapPath("~/Images/MemberPhotos/"), "*.jpg").Length;

        ////Set the counter to 0
        //int counter = 0;

        ////Create a panel called pnlWrapper for the rows of images
        //Panel pnlWrapper = new Panel();
        //pnlWrapper.Attributes["class"] = "row";
        ////Create a panel called pnlImgCol for the individual columns within the rows
        //Panel pnlImgCol = new Panel();
        //pnlImgCol.Attributes["class"] = "col-md-3";
        ////Create an image called imgExecImage
        //Image imgExecImage = new Image();

        //foreach (string file in FilePaths)
        //{
        //    string fileName = Path.GetFileName(file);
        //    if (counter == imgCount/4)
        //    {
        //        //Attach old row to placeholder
        //        plhExecImages.Controls.Add(pnlWrapper);

        //        //Make a new row
        //        pnlWrapper = new Panel();
        //        pnlWrapper.Attributes["class"] = "row";

        //        //Make the space in the row for the image
        //        pnlImgCol = new Panel();
        //        pnlImgCol.Attributes["class"] = "col-md-3 py-3";

        //        //Make the image itself
        //        imgExecImage = new Image();
        //        imgExecImage.Attributes["class"] = "clickable-image shadow";
        //        imgExecImage.ImageUrl = "http://127.0.0.1:8887/MemberPhotos/member1.jpg";
        //        System.Diagnostics.Debug.WriteLine(imgExecImage.ImageUrl.ToString());
        //        //Add the image to the image column
        //        pnlImgCol.Controls.Add(imgExecImage);
        //        //Add the image column to the image row
        //        pnlWrapper.Controls.Add(pnlImgCol);

        //        //Increment counter by 1
        //        counter++;
        //    }
        //    else
        //    {
        //        //Make the space in the row for the image
        //        pnlImgCol = new Panel();
        //        pnlImgCol.Attributes["class"] = "col-md-3 py-3";

        //        //Make the image itself
        //        imgExecImage = new Image();
        //        imgExecImage.Attributes["class"] = "clickable-image shadow";
        //        imgExecImage.ImageUrl = "http://127.0.0.1:8887/MemberPhotos/member1.jpg";
        //        System.Diagnostics.Debug.WriteLine(imgExecImage.ImageUrl.ToString());

        //        //Add the image to the image column
        //        pnlImgCol.Controls.Add(imgExecImage);
        //        //Add the image column to the image row
        //        pnlWrapper.Controls.Add(pnlImgCol);

        //        //Increment counter by 1
        //        counter++;
        //    }
        //}
    }
}