using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserProfile : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (User.Identity.IsAuthenticated)
        {
            LabelEmail.Text = Membership.GetUser().Email;
        }
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
}