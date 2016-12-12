using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    String un;
    String strQuery;
    OracleCommand cmd1;
    OracleConnection conn;
    int userId;
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    private bool getIdD(OracleCommand cmd1)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        OracleConnection conn = new OracleConnection(strConnString);
        cmd1.CommandType = CommandType.Text;
        cmd1.Connection = conn;
        try
        {
            conn.Open();
            OracleDataReader ord = cmd1.ExecuteReader();
            while (ord.Read())
            {
                un = ord.GetString(0);
            }
                return true;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
            return false;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        strQuery = "SELECT user_name FROM users where User_Name = '" +txtUserName.Text+"' and password = '"+txtPassword.Text+"'";
        cmd1 = new OracleCommand(strQuery);
        getIdD(cmd1);
        if (un != null)
        {
            Response.Redirect("Home.aspx?name=" + un);
        }
        else
        {
            Label3.Text = "UserName or password Incorrect!!";
        }
       
    }
}