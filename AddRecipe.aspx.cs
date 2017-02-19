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
        // Check if the all the ingredients have a name

        bool ingredientTxtValid = true;

        // IngredientWebUserControl0
        if (IngredientWebUserControl0.Quantity != "" || 
            IngredientWebUserControl0.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl0.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl1
        if (IngredientWebUserControl1.Quantity != "" ||
            IngredientWebUserControl1.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl1.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl2
        if (IngredientWebUserControl2.Quantity != "" ||
            IngredientWebUserControl2.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl2.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl3
        if (IngredientWebUserControl3.Quantity != "" ||
            IngredientWebUserControl3.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl3.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl4
        if (IngredientWebUserControl4.Quantity != "" ||
            IngredientWebUserControl4.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl4.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl5
        if (IngredientWebUserControl5.Quantity != "" ||
            IngredientWebUserControl5.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl5.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl6
        if (IngredientWebUserControl6.Quantity != "" ||
            IngredientWebUserControl6.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl1.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl7
        if (IngredientWebUserControl7.Quantity != "" ||
            IngredientWebUserControl7.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl7.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl8
        if (IngredientWebUserControl8.Quantity != "" ||
            IngredientWebUserControl8.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl8.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl9
        if (IngredientWebUserControl9.Quantity != "" ||
            IngredientWebUserControl9.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl9.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl10
        if (IngredientWebUserControl10.Quantity != "" ||
            IngredientWebUserControl10.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl10.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl11
        if (IngredientWebUserControl11.Quantity != "" ||
            IngredientWebUserControl11.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl11.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl12
        if (IngredientWebUserControl12.Quantity != "" ||
            IngredientWebUserControl12.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl12.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl13
        if (IngredientWebUserControl13.Quantity != "" ||
            IngredientWebUserControl13.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl13.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl14
        if (IngredientWebUserControl14.Quantity != "" ||
            IngredientWebUserControl14.UnitOfMeasure != "")
        {
            if (IngredientWebUserControl14.Name == "")
            {
                ingredientTxtValid = false;
            }
        }
       
        // if all the ingredients have a name, then we proceed to saving the information of the recipe;
        // if one the web user controls for the ingredients has a name missing, we do not save the recipe
        if (ingredientTxtValid)
        {
            // Save the preparation/cooking time selected by the user
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

            test.Text = preparationTimeArray[0] + "h and " + preparationTimeArray[1] + "min";



            ((List<Recipe>)Application["students"]).Add(new Recipe
            {
                Name = NameRecipeText.Text,
                SubmittedBy = SubmittedByText.Text,
                Category = CategoryText.Text,
                PrepareTime = preparationTimeArray,
                NumberOfServings = Convert.ToInt32(NumberOfServingsText.Text), // check if it is number
                Description = RecipeDescriptionText.Text,

            });
            //Response.Redirect("Default2.aspx");
        }


    }

   
}