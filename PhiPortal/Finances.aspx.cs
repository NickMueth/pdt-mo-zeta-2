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

public partial class PhiPortal_Finances : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string firstName = "fillerName", userID = "000", amountMoneyOwed = "000";
        //Open Connection
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PhiPortalUserDatabase"].ConnectionString);
        connection.Open();
        SqlDataReader dataReader = null;

        SqlCommand getID = new SqlCommand("select Id, FirstName from PhiPortalUsers where Username =@Username", connection);
        getID.Parameters.AddWithValue("@Username", Context.User.Identity.Name);
        dataReader = getID.ExecuteReader();

        while (dataReader.Read())
        {
            userID = dataReader["Id"].ToString();
            firstName = dataReader["FirstName"].ToString();
        }
        dataReader.Close();

        SqlDataReader dataReader2 = null;
        //Find money owed
        SqlCommand moneyOwed = new SqlCommand("select Id, AmountOwed from MoneyOwed where Id =@Id", connection);
        moneyOwed.Parameters.AddWithValue("@Id", userID);
        dataReader2 = moneyOwed.ExecuteReader();

        while (dataReader2.Read())
        {
            amountMoneyOwed = dataReader2["AmountOwed"].ToString();
        }
        dataReader2.Close();

        lblAmountOwed.Text = firstName +", you owe the fraternity: $" +amountMoneyOwed;



    }
}