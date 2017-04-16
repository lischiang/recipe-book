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
        HttpCookie cookie;
        cookie = Request.Cookies["theme"];

        if (cookie != null)
        {
            Page.Theme = cookie.Value;
        }
        else
        {
            Page.Theme = "Light";
        }
    }

    protected void ButtonConfirmSetTheme_Click(object sender, EventArgs e)
    {
        HttpCookie cookie;
        cookie = Request.Cookies["theme"];

        if (cookie == null)
        {
            cookie = new HttpCookie("theme");
            if (RadioButtonSetTheme.SelectedItem.Text == "Light")
            {
                cookie.Value = "Light";
            }
            else if (RadioButtonSetTheme.SelectedItem.Text == "Dark")
            {
                
                cookie.Value = "Dark";

            }
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
        }
        else
        {
            if (RadioButtonSetTheme.SelectedItem.Text == "Light")
            {
                cookie.Value = "Light";
            }
            else if (RadioButtonSetTheme.SelectedItem.Text == "Dark")
            {
                cookie.Value = "Dark";
            }
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);
        }
        Response.Redirect("Home.aspx");
    }
}