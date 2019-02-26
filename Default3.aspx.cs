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

public partial class Default3 : System.Web.UI.Page
{
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