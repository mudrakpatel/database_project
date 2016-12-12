using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class search : System.Web.UI.Page
{
    Recipe[] allRecords = null;
    Ingrident[] allIng = null;
    String strQuery, strQuery1;
    OracleCommand cmd1;
    OracleConnection con;
    int receipe_id;
    List<Recipe> lstRecipe = new List<Recipe>();
    List<Ingrident> lstIngrident = new List<Ingrident>();
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
            dataBind1();
        if (!Page.IsPostBack)
        {
            ddlName.Items.Insert(0, "ALL");
            ddlCategory.Items.Insert(0, "ALL");
            ddlIngrident.Items.Insert(0, "ALL");
            foreach (Recipe item in allRecords)
            {

                ddlName.Items.Add(item.RECEIPENAME);
                ddlCategory.Items.Add(item.RECEIPECATEGORY);

            }
            foreach (Ingrident item in allIng)
            {

                ddlIngrident.Items.Add(item.Ing);
                ddlIngrident.Items.Add(item.Ing2);
                ddlIngrident.Items.Add(item.Ing3);
                ddlIngrident.Items.Add(item.Ing4);
                ddlIngrident.Items.Add(item.Ing5);
                
            }
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
                lstRecipe.Add(new Recipe { IDRECIPE = ord.GetInt32(0), RECEIPENAME = ord.GetString(1) , RECEIPECATEGORY=ord.GetString(2)});
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
        strQuery1 = "select IDRECIPE,RECEIPENAME,RECEIPECATEGORY from RECIPE";
        cmd1 = new OracleCommand(strQuery1);
        getIdD(cmd1);
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
            while (ord.Read())
            {
                lstIngrident.Add(new Ingrident { Ing = ord.GetString(0),Ing2=ord.GetString(1), Ing3 = ord.GetString(2), Ing4 = ord.GetString(3), Ing5 = ord.GetString(4)});
            }
            allIng = lstIngrident.ToArray();
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
    protected void dataBind1()
    {
        strQuery1 = "select INGRIDENTNAME1,INGRIDENTNAME2,INGRIDENTNAME3,INGRIDENTNAME4,INGRIDENTNAME5,INGRIDENTNAME6,INGRIDENTNAME7,INGRIDENTNAME8,INGRIDENTNAME9,INGRIDENTNAME10,INGRIDENTNAME11,INGRIDENTNAME12,INGRIDENTNAME13,INGRIDENTNAME14,INGRIDENTNAME15 from INGRIDENT";
        cmd1 = new OracleCommand(strQuery1);
        getIdD1(cmd1);
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (ddlName.SelectedItem.ToString() == "ALL" && ddlCategory.SelectedItem.ToString()=="ALL"&& ddlIngrident.SelectedItem.ToString()=="ALL")
        {
            strQuery = "select * from Recipe";
        }
        if (ddlName.SelectedItem.ToString() != "ALL" && ddlCategory.SelectedItem.ToString() != "ALL" && ddlIngrident.SelectedItem.ToString() == "ALL")
        {
            strQuery = "select * from Recipe where RECEIPECATEGORY="+ddlCategory.SelectedItem.ToString()+ "and SUBMITTEDBY=" + ddlName.SelectedItem.ToString();
        }
        try
        {
            dataBind2();
            if (Page.IsPostBack)
            {
                link.InnerHtml = "";
            }
            foreach (Recipe item in allRecords)
            {
                
                link.InnerHtml += "<a href='ShowRecipe.aspx?RID=" + item.IDRECIPE.ToString() + "'>" + item.RECEIPENAME + "</a><br/>";
                //Label1.Text += "ID="+item.IDRECIPE.ToString()+"Name="+item.RECEIPENAME.ToString()+"<br/>";
            }
        }
        catch (Exception ex)
        {
        }
    }
    private Boolean getIdD2(OracleCommand cmd)
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
    protected void dataBind2()
    {
        cmd1 = new OracleCommand(strQuery1);
        getIdD(cmd1);
    }
}