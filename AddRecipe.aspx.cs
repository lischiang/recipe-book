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

            //test.Text = preparationTimeArray[0] + "h and " + preparationTimeArray[1] + "min";
            //if (CategoryText.Text == "")
            //{
            //    test.Text = "empty string";
            //}
            //else
            //{
            //    test.Text = "something else string";
            //}

            /////////////////////////////////////////////////////////////////////////////////
            //// Create the list of objects Ingredient

            List<Ingredient> newListOfIngredients = new List<Ingredient>(); //new list of objects Ingredient

            // IngredientWebUserControl0
            if (IngredientWebUserControl0.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl0.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl0.Quantity),
                    UnitOfMeasure = IngredientWebUserControl0.UnitOfMeasure
                };           
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl1
            if (IngredientWebUserControl1.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl1.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl1.Quantity),
                    UnitOfMeasure = IngredientWebUserControl1.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl2
            if (IngredientWebUserControl2.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl2.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl2.Quantity),
                    UnitOfMeasure = IngredientWebUserControl2.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl3
            if (IngredientWebUserControl3.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl3.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl3.Quantity),
                    UnitOfMeasure = IngredientWebUserControl3.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl4
            if (IngredientWebUserControl4.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl4.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl4.Quantity),
                    UnitOfMeasure = IngredientWebUserControl4.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl5
            if (IngredientWebUserControl5.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl5.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl5.Quantity),
                    UnitOfMeasure = IngredientWebUserControl5.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl6
            if (IngredientWebUserControl6.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl6.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl6.Quantity),
                    UnitOfMeasure = IngredientWebUserControl6.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl7
            if (IngredientWebUserControl7.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl7.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl7.Quantity),
                    UnitOfMeasure = IngredientWebUserControl7.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl8
            if (IngredientWebUserControl8.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl8.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl8.Quantity),
                    UnitOfMeasure = IngredientWebUserControl8.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl9
            if (IngredientWebUserControl9.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl9.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl9.Quantity),
                    UnitOfMeasure = IngredientWebUserControl9.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl10
            if (IngredientWebUserControl10.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl10.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl10.Quantity),
                    UnitOfMeasure = IngredientWebUserControl10.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl11
            if (IngredientWebUserControl11.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl11.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl11.Quantity),
                    UnitOfMeasure = IngredientWebUserControl11.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl12
            if (IngredientWebUserControl12.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl12.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl12.Quantity),
                    UnitOfMeasure = IngredientWebUserControl12.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl13
            if (IngredientWebUserControl13.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl13.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl13.Quantity),
                    UnitOfMeasure = IngredientWebUserControl13.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            // IngredientWebUserControl14
            if (IngredientWebUserControl14.Name != "")
            {
                Ingredient newIngredient = new Ingredient
                {
                    Name = IngredientWebUserControl14.Name,
                    Quantity = Convert.ToDouble(IngredientWebUserControl14.Quantity),
                    UnitOfMeasure = IngredientWebUserControl14.UnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            

            ((List<Recipe>)Application["recipes"]).Add(new Recipe
            {
                NameRecipe = NameRecipeText.Text,
                SubmittedBy = SubmittedByText.Text,
                Category = CategoryText.Text,
                PrepareTime = preparationTimeArray,
                NumberOfServings = NumberOfServingsText.Text,
                Description = RecipeDescriptionText.Text,
                IngredientList = newListOfIngredients
            });
            //Response.Redirect("Default2.aspx");

            //test.Text = ((List<Recipe>)Application["recipes"]).Count().ToString();
            //test.Text = "1)" + ((List<Recipe>)Application["recipes"]).ElementAt(0).NameRecipe + "," +
            //    ((List<Recipe>)Application["recipes"]).ElementAt(0).IngredientList.ElementAt(0).Name +
            //    "2)" + ((List<Recipe>)Application["recipes"]).ElementAt(0).NameRecipe + "," +
            //    ((List<Recipe>)Application["recipes"]).ElementAt(0).IngredientList.ElementAt(1).Name;
        }


    }

   
}