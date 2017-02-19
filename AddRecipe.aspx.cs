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
        if (!Page.IsPostBack)
        {
            // Populate dropdown list for hours of preparation/cooking 
            PrepareTimeHoursDropDownList.Items.Insert(0, new ListItem("--Select--"));
            for (int i = 1; i < 26; i++)
            {
                string value = (i-1).ToString();
                PrepareTimeHoursDropDownList.Items.Insert(i, new ListItem(value));
            }

            // Populate dropdown list for minutes of preparation/cooking (multiple of 5)
            PrepareTimeMinutesDropDownList.Items.Insert(0, new ListItem("--Select--"));
            for (int i = 1; i < 61; i++)
            {
                string value = (i - 1).ToString();
                PrepareTimeMinutesDropDownList.Items.Insert(i, new ListItem(value));
            }
        }
    }

    protected void NewRecipeButton_Click(object sender, EventArgs e)
    {
        // save the preparation/cooking time selected by the user
        int[] preparationTimeArray = new int[2];
        if (PrepareTimeHoursDropDownList.SelectedIndex == 0 &&
            PrepareTimeMinutesDropDownList.SelectedIndex != 0)
        // in case the user selects just N minutes we set the time 0h Nmin
        {
            preparationTimeArray[0] = 0;
            preparationTimeArray[1] = Convert.ToInt32(
                PrepareTimeMinutesDropDownList.SelectedValue);
        }
        else if (PrepareTimeHoursDropDownList.SelectedIndex != 0 &&
            PrepareTimeMinutesDropDownList.SelectedIndex == 0)
            // in case the user selects just N hours we set the time Nh 0min
        {
            preparationTimeArray[0] = Convert.ToInt32(
                PrepareTimeHoursDropDownList.SelectedValue);
            preparationTimeArray[1] = 0;
        }
        else if (PrepareTimeHoursDropDownList.SelectedIndex == 0 &&
            PrepareTimeMinutesDropDownList.SelectedIndex == 0)
            // in case the user has not selected anything we set the time at 0h 0min
        {
            preparationTimeArray[0] = 0; preparationTimeArray[1] = 0;
        }
        else
        // in case both dropdownlists have been selected we save both the selected hours and minutes
        {
            preparationTimeArray[0] = Convert.ToInt32(
                PrepareTimeHoursDropDownList.SelectedValue);
            preparationTimeArray[1] = Convert.ToInt32(
                PrepareTimeMinutesDropDownList.SelectedValue);
        }

        //test.Text = preparationTimeArray[0] + "h and " + preparationTimeArray[1] + "min";

        //////////////////////////////////////////////////////////////////////////
        // Save the ingredients inserted by the user in the Ingredient object

        // IngredientWebUserControl0
        if (IngredientWebUserControl0.Quantity != "" || 
            IngredientWebUserControl0.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl0.Name == "")
            {

            }
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