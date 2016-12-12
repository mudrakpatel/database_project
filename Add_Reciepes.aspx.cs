using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class addRecipes : System.Web.UI.Page
{
    String strQuery,strQuery1, fileupld;
    OracleCommand cmd,cmd1,cmd2;
    OracleConnection con;
    int receipe_id;
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
    private Boolean getIdD(OracleCommand cmd)
    {
        String strConnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        OracleConnection con = new OracleConnection(strConnString);
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;
        try
        {
            con.Open();
            receipe_id=Convert.ToInt32(cmd.ExecuteScalar());
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
    
    public void uploadimg0()
    {
        String rand = (DateTime.Now).ToString() + (DateTime.Now.Millisecond).ToString();
        string[] validFileTypes = { ".bmp", ".gif", ".png", ".jpg", ".jpeg" };
        string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
        string filename = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.PostedFile.FileName);
        bool isValidFile = false;
        bool isValidSize = true;
        for (int i = 0; i < validFileTypes.Length; i++)
        {
            if (ext == validFileTypes[i])
            {
                isValidFile = true;
                break;
            }
        }
        if (FileUpload1.FileBytes.Length > 3146842)
        {
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "File must be less than 3 MB.";
            isValidSize = false;
        }
        if (!isValidFile)
        {
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "Invalid File. Please upload a File with extension " +
                           string.Join(",", validFileTypes);
        }
        else if (isValidSize)
        {
            if (FileUpload1.HasFile && FileUpload1.PostedFile.ContentLength > 0)
            {
                string fname = filename + rand.ToString() + ext;
                fname = fname.Replace(" ", "");
                fname = fname.Replace(":", "");
                fname = fname.Replace(";", "");
                fname = fname.Replace("/", "");
                byte[] filebyte = FileUpload1.FileBytes;
                System.Data.Linq.Binary fileBinary = new System.Data.Linq.Binary(filebyte);
                FileUpload1.SaveAs(Server.MapPath("~/Images/") + fname);
                fileupld = fname;
            }
            Label1.ForeColor = System.Drawing.Color.Green;
            Label1.Text = "File uploaded successfully.";
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        uploadimg0();
        
        using (OracleConnection objConn = new OracleConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
        {
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = "insert_recipe";
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add("receipename", OracleDbType.Varchar2).Value = txtBxRecipeName.Text;
            objCmd.Parameters.Add("submittedby", OracleDbType.Varchar2).Value = txtBxUsername.Text;
            objCmd.Parameters.Add("receipecategory", OracleDbType.Varchar2).Value = txtBxCategory.Text;
            objCmd.Parameters.Add("cookingtime", OracleDbType.Varchar2).Value = txtBxCookingTime.Text;
            objCmd.Parameters.Add("no_of_serving", OracleDbType.Varchar2).Value = txtBxServings.Text;
            objCmd.Parameters.Add("receipediscription", OracleDbType.Varchar2).Value = txtBxDescription.Text;

            try
            {
                objConn.Open();
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               
            }

            objConn.Close();
        }
        using (OracleConnection objConn = new OracleConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
        {
            strQuery1 = "SELECT MAX(idrecipe) FROM recipe";
            cmd1 = new OracleCommand(strQuery1);
            getIdD(cmd1);
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = "insert_ingrident1";
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add("INGRIDENTNAME1", OracleDbType.Varchar2).Value = Ingredients1.TxtNameValue;
            objCmd.Parameters.Add("QUANTITY1", OracleDbType.Varchar2).Value = Ingredients1.TxtQuantityValue;
            objCmd.Parameters.Add("UNITOFMEASURE1", OracleDbType.Varchar2).Value = Ingredients1.TxtUnitOfMeasure;
            objCmd.Parameters.Add("INGRIDENTNAME2", OracleDbType.Varchar2).Value = Ingredients2.TxtNameValue;
            objCmd.Parameters.Add("QUANTITY2", OracleDbType.Varchar2).Value = Ingredients2.TxtQuantityValue;
            objCmd.Parameters.Add("UNITOFMEASURE2", OracleDbType.Varchar2).Value = Ingredients2.TxtUnitOfMeasure;
            objCmd.Parameters.Add("INGRIDENTNAME3", OracleDbType.Varchar2).Value = Ingredients3.TxtNameValue;
            objCmd.Parameters.Add("QUANTITY3", OracleDbType.Varchar2).Value = Ingredients3.TxtQuantityValue;
            objCmd.Parameters.Add("UNITOFMEASURE3", OracleDbType.Varchar2).Value = Ingredients3.TxtUnitOfMeasure;
            objCmd.Parameters.Add("INGRIDENTNAME4", OracleDbType.Varchar2).Value = Ingredients4.TxtNameValue;
            objCmd.Parameters.Add("QUANTITY4", OracleDbType.Varchar2).Value = Ingredients4.TxtQuantityValue;
            objCmd.Parameters.Add("UNITOFMEASURE4", OracleDbType.Varchar2).Value = Ingredients4.TxtUnitOfMeasure;
            objCmd.Parameters.Add("INGRIDENTNAME5", OracleDbType.Varchar2).Value = Ingredients5.TxtNameValue;
            objCmd.Parameters.Add("QUANTITY5", OracleDbType.Varchar2).Value = Ingredients5.TxtQuantityValue;
            objCmd.Parameters.Add("UNITOFMEASURE5", OracleDbType.Varchar2).Value = Ingredients5.TxtUnitOfMeasure;
            objCmd.Parameters.Add("IDRECIPE", OracleDbType.Int32).Value = receipe_id;
            try
            {
                objConn.Open();
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            objConn.Close();
        }
        using (OracleConnection objConn = new OracleConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
        {
            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = "Insert_Image";
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add("ImageName", OracleDbType.Varchar2).Value = fileupld;
            objCmd.Parameters.Add("IDRecipe", OracleDbType.Int32).Value = receipe_id;
           
            try
            {
                objConn.Open();
                objCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            objConn.Close();
        }


    }
}