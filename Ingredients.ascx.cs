using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ingredients : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    public string TxtNameValue
    {
        get { return txtName.Text; }
    }
    public string TxtQuantityValue
    {
        get { return txtQuantity.Text; }
    }
    public string TxtUnitOfMeasure
    {
        get { return txtUnitOfMeasure.Text; }
    }
}