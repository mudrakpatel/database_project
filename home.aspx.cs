using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Recipe[] allRecords = null;
    String strQuery, strQuery1;
    OracleCommand cmd1;
    OracleConnection con;
    int receipe_id;
    List<Recipe> lstRecipe = new List<Recipe>();

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
        dataBind();
        foreach (Recipe item in allRecords)
        {
            link.InnerHtml += "<a href='ShowRecipe.aspx?RID="+item.IDRECIPE.ToString()+"'>"+item.RECEIPENAME+"</a><br/>";
            //Label1.Text += "ID="+item.IDRECIPE.ToString()+"Name="+item.RECEIPENAME.ToString()+"<br/>";
        }
       
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
            while (ord.Read())
            {
                lstRecipe.Add(new Recipe { IDRECIPE = ord.GetInt32(0), RECEIPENAME = ord.GetString(1) });
            }
            allRecords = lstRecipe.ToArray();
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
        strQuery1 = "select IDRECIPE,RECEIPENAME from RECIPE";
        cmd1 = new OracleCommand(strQuery1);
        getIdD(cmd1);   
    }
}