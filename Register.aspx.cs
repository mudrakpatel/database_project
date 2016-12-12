using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    String strQuery, strQuery1;
    OracleCommand cmd, cmd1, cmd2;
    OracleConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        strQuery = "insert into Users (User_name ,Address, Email, Password, Phone) values (:user_name, :Address, :email, :password, :phone)";
        cmd = new OracleCommand(strQuery);
        cmd.BindByName = true;
        cmd.Parameters.Add(":USER_NAME", txt_fullName.Text);
        cmd.Parameters.Add(":Address", txtAddress.Text);
        cmd.Parameters.Add(":Email", txtEmail.Text);
        cmd.Parameters.Add(":Password", txtPassword.Text);
        cmd.Parameters.Add(":Phone", txtPassword.Text);
        InsertUpdateData(cmd);
        Response.Redirect("~/Home.aspx");

    }

    private Boolean InsertUpdateData(OracleCommand cmd)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        OracleConnection con = new OracleConnection(strConnString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
            return false;
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }
    
}