using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string Name
    {
        get { return NameIngredientText.Text; }
        set { NameIngredientText.Text = value; }
    }

    public string Quantity
    {
        get { return QuantityText.Text; }
        set { QuantityText.Text = value; }
    }

    public string UnitOfMeasure
    {
        get { return UnitOfMeasureText.Text; }
        set { UnitOfMeasureText.Text = value; }
    }
}