using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SetTheme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // Set the theme
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

    protected void ButtonConfirmSetTheme_Click(object sender, EventArgs e)
    {
        //if(RadioButtonSetTheme.it)
        

        if(RadioButtonSetTheme.SelectedItem.Text=="Light")
        {
            Session["theme"] = "Light";
        }
        else if (RadioButtonSetTheme.SelectedItem.Text == "Dark")
        {
            Session["theme"] = "Dark";
        }
        Response.Redirect("Home.aspx");
    }
}