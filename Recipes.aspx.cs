using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Recipes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CategoriesDropDownList.Items.Insert(0, new ListItem("--Select a category--"));
        CategoriesDropDownList.Items.Insert(1, new ListItem("Appetizers & Snacks"));
        CategoriesDropDownList.Items.Insert(2, new ListItem("Salads"));
        CategoriesDropDownList.Items.Insert(3, new ListItem("Meals"));
        CategoriesDropDownList.Items.Insert(4, new ListItem("Breakfast & Brunch"));
        CategoriesDropDownList.Items.Insert(5, new ListItem("Desserts"));
        CategoriesDropDownList.Items.Insert(6, new ListItem("World Cuisine"));
    }
}