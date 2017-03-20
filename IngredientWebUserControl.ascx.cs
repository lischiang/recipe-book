using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    public string IndexName
    {
        get { return DropDownListNameIngredient.SelectedValue; }
        set { DropDownListNameIngredient.SelectedValue = value; }
    }

    public DropDownList DDLName
    {
        get { return DropDownListNameIngredient; }
        set { DropDownListNameIngredient = value; }
    }

    public string Quantity
    {
        get { return QuantityText.Text; }
        set { QuantityText.Text = value; }
    }

    public string IndexUnitOfMeasure
    {
        get { return DropDownListUnitOfMeasure.SelectedValue; }
        set { DropDownListUnitOfMeasure.SelectedValue = value; }
    }
    public DropDownList DDLUnit
    {
        get { return DropDownListUnitOfMeasure; }
        set { DropDownListUnitOfMeasure = value; }
    }

    protected void IngredientValidity(object sender, ServerValidateEventArgs e)
    {
        if (QuantityText.Text != "" || DropDownListUnitOfMeasure.SelectedIndex != 0)
        {
            if(DropDownListNameIngredient.SelectedIndex != 0)
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }
        }
        else
        {
            e.IsValid = true;
        }
    }


}