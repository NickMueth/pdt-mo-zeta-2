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
using System.IO;
using System.Web.UI.HtmlControls;

public partial class Gallery : System.Web.UI.Page
{
    /* (2/11/19)
     * OK!
     * You don't even understand the bear that this code is. See, for security purposes, most browsers won't let you load local resources, like our images. So I looked into putting them on a database. But everyone warned against loading them from a database because it's hard to put images on a database efficiently. So back to going to physical paths. Everyone warns against physical paths as well. I am so freaking confused right now... 
     
        (2/19/19)
        Hello! I have figured out the problem and have come across a solution! As follows:
        I have created a database table in our PhiPortalUserDB that contains all the image file names of the images, along with an ID and when they were created. From there, I populate a DataTable in C# called "dt". I create a panel called "pnlWrapper", and four image column panels "pnlImgCol1-4". Foreach row in our DataTable, and using the counter as an iterator of sorts, I use modulus to assign the image to a column, going in order of 1, 2, 3, 4, 1, 2, 3, 4, etc. The CSS deals with the styling such as stacking them neatly, applying a rounded edge, shadows, and opacity on hover. I am currently building the modal system to open up an enlarged view of the image when clicked.
         
         */
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PhiPortalUserDB"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM GalleryImagePaths", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            System.Diagnostics.Debug.WriteLine("ERROR: datatable not filled from GalleryImagePaths table in DB PhiPortalUserDB");
        }

        //Set the counter to 1
        int counter = 1;

        //Create a panel called pnlWrapper for the rows of images
        Panel pnlWrapper = new Panel();
        pnlWrapper.Attributes["class"] = "gal_wrapper";

        //Create four columns for the gallery
        Panel pnlImgCol1 = new Panel();
        pnlImgCol1.Attributes["class"] = "gal_column col-3";
        Panel pnlImgCol2 = new Panel();
        pnlImgCol2.Attributes["class"] = "gal_column col-3";
        Panel pnlImgCol3 = new Panel();
        pnlImgCol3.Attributes["class"] = "gal_column col-3";
        Panel pnlImgCol4 = new Panel();
        pnlImgCol4.Attributes["class"] = "gal_column col-3";

        //Create an image object called imgGalleryImage
        HtmlImage imgGalleryImage;

        foreach (DataRow imageInfo in dt.Rows)
        {
            string fileName = imageInfo[1].ToString();

            string idName = imageInfo[1].ToString();
            idName = idName.Substring(0, idName.IndexOf('.'));

            if (counter % 4 == 1)
            {
                imgGalleryImage = new HtmlImage();
                imgGalleryImage.Attributes["id"] = idName;
                imgGalleryImage.Attributes["class"] = "modal_img";
                imgGalleryImage.Attributes["onclick"] = "return img_click('" + idName + "')";
                imgGalleryImage.Attributes["src"] = "http://127.0.0.1:8887/Gallery/" + fileName;
                imgGalleryImage.Attributes["alt"] = imageInfo[2].ToString();
                pnlImgCol1.Controls.Add(imgGalleryImage);
            }
            else if (counter % 4 == 2)
            {
                imgGalleryImage = new HtmlImage();
                imgGalleryImage.Attributes["id"] = idName;
                imgGalleryImage.Attributes["class"] = "modal_img";
                imgGalleryImage.Attributes["onclick"] = "return img_click('" + idName + "')";
                imgGalleryImage.Attributes["src"] = "http://127.0.0.1:8887/Gallery/" + fileName;
                imgGalleryImage.Attributes["alt"] = imageInfo[2].ToString();
                pnlImgCol2.Controls.Add(imgGalleryImage);
            }
            else if (counter % 4 == 3)
            {
                imgGalleryImage = new HtmlImage();
                imgGalleryImage.Attributes["id"] = idName;
                imgGalleryImage.Attributes["class"] = "modal_img";
                imgGalleryImage.Attributes["onclick"] = "return img_click('" + idName + "')";
                imgGalleryImage.Attributes["src"] = "http://127.0.0.1:8887/Gallery/" + fileName;
                imgGalleryImage.Attributes["alt"] = imageInfo[2].ToString();
                pnlImgCol3.Controls.Add(imgGalleryImage);
            }
            else
            {
                imgGalleryImage = new HtmlImage();
                imgGalleryImage.Attributes["id"] = idName;
                imgGalleryImage.Attributes["class"] = "modal_img";
                imgGalleryImage.Attributes["onclick"] = "return img_click('" + idName + "')";
                imgGalleryImage.Attributes["src"] = "http://127.0.0.1:8887/Gallery/" + fileName;
                imgGalleryImage.Attributes["alt"] = imageInfo[2].ToString();
                pnlImgCol4.Controls.Add(imgGalleryImage);
            }

            counter++;
        }
        pnlWrapper.Controls.Add(pnlImgCol1);
        pnlWrapper.Controls.Add(pnlImgCol2);
        pnlWrapper.Controls.Add(pnlImgCol3);
        pnlWrapper.Controls.Add(pnlImgCol4);

        plhGallery.Controls.Add(pnlWrapper);
        con.Close();
    }
}