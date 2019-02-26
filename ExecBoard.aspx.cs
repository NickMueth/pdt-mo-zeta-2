using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class ExecBoard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PhiPortalUserDB"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM ExecutiveBoard", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            System.Diagnostics.Debug.WriteLine("ERROR: datatable not filled from ExecutiveBoard table in DB PhiPortalUserDB");
        }

        //Set the counter to 1
        int counter = 1;

        //Create a panel called pnlWrapper for the rows of images
        Panel pnlWrapper = new Panel();
        pnlWrapper.Attributes["class"] = "gal_wrapper";

        //Create four columns for the gallery
        Panel pnlImgCol1 = new Panel();
        pnlImgCol1.Attributes["class"] = "gal_column col-4";
        Panel pnlImgCol2 = new Panel();
        pnlImgCol2.Attributes["class"] = "gal_column col-4";
        Panel pnlImgCol3 = new Panel();
        pnlImgCol3.Attributes["class"] = "gal_column col-4";

        //Create an image object called imgExecImage
        HtmlImage imgExecImage;

        foreach (DataRow imageInfo in dt.Rows)
        {
            string fileName = imageInfo[4].ToString();

            string idName = imageInfo[4].ToString();
            idName = idName.Substring(0, idName.IndexOf('.'));

            if (counter % 3 == 1)
            {
                imgExecImage = new HtmlImage();
                imgExecImage.Attributes["id"] = idName;
                imgExecImage.Attributes["class"] = "modal_img";
                imgExecImage.Attributes["onclick"] = "return img_click('" + idName + "')";
                imgExecImage.Attributes["src"] = "http://127.0.0.1:8887/MemberPhotos" +"/" + fileName;
                imgExecImage.Attributes["alt"] = imageInfo[1].ToString();
                pnlImgCol1.Controls.Add(imgExecImage);
            }
            else if (counter % 3 == 2)
            {
                imgExecImage = new HtmlImage();
                imgExecImage.Attributes["id"] = idName;
                imgExecImage.Attributes["class"] = "modal_img";
                imgExecImage.Attributes["onclick"] = "return img_click('" + idName + "')";
                imgExecImage.Attributes["src"] = "http://127.0.0.1:8887/MemberPhotos" + "/" + fileName;
                imgExecImage.Attributes["alt"] = imageInfo[1].ToString();
                pnlImgCol2.Controls.Add(imgExecImage);
            }
            else
            {
                imgExecImage = new HtmlImage();
                imgExecImage.Attributes["id"] = idName;
                imgExecImage.Attributes["class"] = "modal_img";
                imgExecImage.Attributes["onclick"] = "return img_click('" + idName + "')";
                imgExecImage.Attributes["src"] = "http://127.0.0.1:8887/MemberPhotos" + "/" + fileName;
                imgExecImage.Attributes["alt"] = imageInfo[1].ToString();
                pnlImgCol3.Controls.Add(imgExecImage);
            }

            counter++;
        }
        pnlWrapper.Controls.Add(pnlImgCol1);
        pnlWrapper.Controls.Add(pnlImgCol2);
        pnlWrapper.Controls.Add(pnlImgCol3);

        plhExecBoard.Controls.Add(pnlWrapper);
        con.Close();
    }
}