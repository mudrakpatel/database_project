using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowRecipe : System.Web.UI.Page
{
    String strQuery, strQuery1;
    OracleCommand cmd1;
    OracleConnection con;
    int rid;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string theme = (string)Session["theme"];
        if (theme != null)
        {
            Page.Theme = theme;
        }
        else
        {
            Page.Theme = "Light";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
        rid = Convert.ToInt32(Request.QueryString["RID"]);
        dataBind();
        dataBind1();
        dataBind2();
    }

    private Boolean getIdD(OracleCommand cmd)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        OracleConnection con = new OracleConnection(strConnString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            OracleDataReader ord = cmd.ExecuteReader();
            {
                while (ord.Read())
                {
                    lblName.Text = "Recipe Name:  "+ord[1] as string+"<br/>";
                    lblSubmittedby.Text = "Submitted By:  "+ord[2] as string + "<br/>";
                    lblCategory.Text = "Category:  " + ord[3] as string + "<br/>";
                    lblCookingTime.Text = "Cooking Time:  " + ord[4] as string + "<br/>";
                    lblNoOfServing.Text = "Number Of Serving:  " + ord[5] as string + "<br/>";
                    lblDiscription.Text = "Discription:  " + ord[6] as string + "<br/>";
                }
            }
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
    private Boolean getId21(OracleCommand cmd)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        OracleConnection con = new OracleConnection(strConnString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            OracleDataReader ord = cmd.ExecuteReader();
            {
                while (ord.Read())
                {
                    lblName.Text = "Recipe Name:  " + ord[1] as string + "<br/>";
                    lblSubmittedby.Text = "Submitted By:  " + ord[2] as string + "<br/>";
                    lblCategory.Text = "Category:  " + ord[3] as string + "<br/>";
                    lblCookingTime.Text = "Cooking Time:  " + ord[4] as string + "<br/>";
                    lblNoOfServing.Text = "Number Of Serving:  " + ord[5] as string + "<br/>";
                    lblDiscription.Text = "Discription:  " + ord[6] as string + "<br/>";
                }
            }
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
    private Boolean getIdD1(OracleCommand cmd)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        OracleConnection con = new OracleConnection(strConnString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            OracleDataReader ord = cmd.ExecuteReader();
            {
                while (ord.Read())
                {
                    string fname = ord.GetString(0);
                    fname = fname.Replace("Image_", "");
                    img.Src = "../Images/" + fname;  
                }
            }
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
    protected void dataBind()
    {
        strQuery1 = "select * from RECIPE where IDRECIPE="+rid;
        cmd1 = new OracleCommand(strQuery1);
        getIdD(cmd1);
    }
    protected void dataBind1()
    {
        strQuery1 = "select * from INGRIDENT1 where IDRECIPE=" + rid;
        cmd1 = new OracleCommand(strQuery1);
        getId21(cmd1);
    }
    protected void dataBind2()
    {
        strQuery1 = "select ImageName from Image where IDRECIPE=" + rid;
        cmd1 = new OracleCommand(strQuery1);
        getIdD1(cmd1);
    }
    protected void datadelete()
    {
        strQuery1 = "delete from INGRIDENT1 where IDRECIPE=" + rid;
        cmd1 = new OracleCommand(strQuery1);
        delete(cmd1);
    }
    protected void datadelete1()
    {
        strQuery1 = "delete from RECIPE where IDRECIPE=" + rid;
        cmd1 = new OracleCommand(strQuery1);
        delete(cmd1);
    }
    private Boolean delete(OracleCommand cmd)
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
   
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        datadelete();
        datadelete1();
        Response.Redirect("~/Home.aspx");
    }
}