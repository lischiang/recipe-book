using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddRecipe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Populate dropdown list for hours of preparation/cooking 
        PrepareTimeHoursDropDownList.Items.Insert(0, new ListItem("--Select--"));
        for (int i = 0; i<24; i++)
        {
            string value = i.ToString();
            PrepareTimeHoursDropDownList.Items.Insert(i+1, new ListItem(value));
        }

        // Populate dropdown list for minutes of preparation/cooking (multiple of 5)
        PrepareTimeMinutesDropDownList.Items.Insert(0, new ListItem("--Select--"));
        for (int i = 0; i < 12; i++)
        {
            string value = (i*5).ToString();
            PrepareTimeMinutesDropDownList.Items.Insert(i + 1, new ListItem(value));
        }
    }

    protected void NewRecipeButton_Click(object sender, EventArgs e)
    {
        int[] prepareTimeArray = { Convert.ToInt32(PrepareTimeHoursDropDownList.SelectedValue),
                Convert.ToInt32(PrepareTimeHoursDropDownList.SelectedValue)};

        
        if (NameRecipeText.Text == null)
        {
            test.Text = "null";
        }
        else
        {
            test.Text = " no null";
        }
        //((List<Recipe>)Application["students"]).Add(new Recipe
        //{
        //    Name = NameRecipeText.Text,
        //    SubmittedBy = SubmittedByText.Text,
        //    Category = CategoryText.Text,
        //    PrepareTime = prepareTimeArray,
        //    NumberOfServings = Convert.ToInt32(NumberOfServingsText.Text), // check if it is number
        //    Description = RecipeDescriptionText.Text,
            
        //});
        //Response.Redirect("Default2.aspx");
    }
}