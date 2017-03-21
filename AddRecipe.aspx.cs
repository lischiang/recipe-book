// Lisa Chiang, student number 300925122

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                string value = (i - 1).ToString();
                PrepareTimeHoursDropDownList.Items.Insert(i, new ListItem(value));
            }

            // Populate dropdown list for minutes of preparation/cooking (multiple of 5)
            PrepareTimeMinutesDropDownList.Items.Insert(0, new ListItem("--Select--"));
            for (int i = 1; i < 61; i++)
            {
                string value = (i - 1).ToString();
                PrepareTimeMinutesDropDownList.Items.Insert(i, new ListItem(value));
            }

            ////// Populate dropdown list for ingredients and measure units:
            // Read the connection string from Web.config
            string connectionString =
                ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    /////////////IngredientWebUserControl0
                    // Get data about ingredients from the database
                    SqlDataAdapter adapterIngredients = new SqlDataAdapter("SELECT idIngredient, IngredientName FROM RB_Ingredient", conn);
                    DataTable storeTableIngredient = new DataTable();    // table to store the sql command
                    adapterIngredients.Fill(storeTableIngredient);
                    // Populate dropdownlist
                    IngredientWebUserControl0.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl0.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl0.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl0.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl0.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Get data about ingredients from the database
                    SqlDataAdapter adapterUnits = new SqlDataAdapter("SELECT idUnit, UnitName FROM RB_MeasureUnit", conn);
                    DataTable storeTableUnits = new DataTable();    // table to store the sql command
                    adapterUnits.Fill(storeTableUnits);
                    // Populate dropdownlist
                    IngredientWebUserControl0.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl0.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl0.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl0.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl0.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl1
                    // Populate dropdownlist
                    IngredientWebUserControl1.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl1.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl1.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl1.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl1.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl1.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl1.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl1.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl1.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl1.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl2
                    // Populate dropdownlist
                    IngredientWebUserControl2.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl2.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl2.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl2.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl2.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl2.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl2.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl2.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl2.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl2.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl3
                    // Populate dropdownlist
                    IngredientWebUserControl3.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl3.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl3.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl3.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl3.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl3.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl3.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl3.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl3.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl3.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl4
                    // Populate dropdownlist
                    IngredientWebUserControl4.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl4.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl4.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl4.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl4.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl4.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl4.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl4.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl4.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl4.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl5
                    // Populate dropdownlist
                    IngredientWebUserControl5.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl5.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl5.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl5.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl5.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl5.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl5.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl5.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl5.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl5.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl6
                    // Populate dropdownlist
                    IngredientWebUserControl6.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl6.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl6.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl6.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl6.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl6.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl6.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl6.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl6.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl6.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl7
                    // Populate dropdownlist
                    IngredientWebUserControl7.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl7.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl7.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl7.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl7.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl7.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl7.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl7.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl7.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl7.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl8
                    // Populate dropdownlist
                    IngredientWebUserControl8.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl8.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl8.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl8.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl8.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl8.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl8.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl8.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl8.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl8.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl9
                    // Populate dropdownlist
                    IngredientWebUserControl9.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl9.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl9.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl9.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl9.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl9.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl9.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl9.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl9.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl9.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl10
                    // Populate dropdownlist
                    IngredientWebUserControl10.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl10.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl10.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl10.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl10.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl10.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl10.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl10.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl10.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl10.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl11
                    // Populate dropdownlist
                    IngredientWebUserControl11.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl11.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl11.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl11.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl11.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl11.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl11.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl11.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl11.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl11.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl12
                    // Populate dropdownlist
                    IngredientWebUserControl12.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl12.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl12.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl12.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl12.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl12.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl12.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl12.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl12.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl12.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl13
                    // Populate dropdownlist
                    IngredientWebUserControl13.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl13.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl13.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl13.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl13.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl13.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl13.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl13.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl13.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl13.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////IngredientWebUserControl14
                    // Populate dropdownlist
                    IngredientWebUserControl14.DDLName.DataSource = storeTableIngredient;
                    IngredientWebUserControl14.DDLName.DataTextField = "IngredientName";
                    IngredientWebUserControl14.DDLName.DataValueField = "idIngredient";
                    IngredientWebUserControl14.DDLName.DataBind();
                    // Add default item 
                    IngredientWebUserControl14.DDLName.Items.Insert(0, new ListItem("--Select ingredient--"));

                    // Populate dropdownlist
                    IngredientWebUserControl14.DDLUnit.DataSource = storeTableUnits;
                    IngredientWebUserControl14.DDLUnit.DataTextField = "UnitName";
                    IngredientWebUserControl14.DDLUnit.DataValueField = "idUnit";
                    IngredientWebUserControl14.DDLUnit.DataBind();
                    // Add default item 
                    IngredientWebUserControl14.DDLUnit.Items.Insert(0, new ListItem("--Select measure unit--"));

                    /////////////DropDownListCategory
                    // Get data about categories from the database
                    SqlDataAdapter adapterCategories = new SqlDataAdapter("SELECT idCategory, CategoryName FROM RB_Category", conn);
                    DataTable storeTableCategory = new DataTable();    // table to store the sql command
                    adapterCategories.Fill(storeTableCategory);
                    // Populate dropdownlist
                    DropDownListCategory.DataSource = storeTableCategory;
                    DropDownListCategory.DataTextField = "CategoryName";
                    DropDownListCategory.DataValueField = "idCategory";
                    DropDownListCategory.DataBind();
                    // Add default item 
                    DropDownListCategory.Items.Insert(0, new ListItem("--Select category--"));


                }
                catch (Exception ex)
                {
                    MessageLabel.Text = "ERROR: " + ex.Message;
                }
            }
        }
    }

    // Lisa Chiang, student number 300925122

    protected void NewRecipeButton_Click(object sender, EventArgs e)
    {
        // Check if all the ingredients have a name

        bool ingredientTxtValid = true;

        // IngredientWebUserControl0
        if (IngredientWebUserControl0.Quantity != "" || 
            IngredientWebUserControl0.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl0.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl1
        if (IngredientWebUserControl1.Quantity != "" ||
            IngredientWebUserControl1.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl1.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl2
        if (IngredientWebUserControl2.Quantity != "" ||
          IngredientWebUserControl2.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl2.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl3
        if (IngredientWebUserControl3.Quantity != "" ||
          IngredientWebUserControl3.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl3.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl4
        if (IngredientWebUserControl4.Quantity != "" ||
          IngredientWebUserControl4.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl4.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl5
        if (IngredientWebUserControl5.Quantity != "" ||
          IngredientWebUserControl5.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl5.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl6
        if (IngredientWebUserControl6.Quantity != "" ||
          IngredientWebUserControl6.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl6.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl7
        if (IngredientWebUserControl7.Quantity != "" ||
          IngredientWebUserControl7.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl7.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }
        // IngredientWebUserControl8
        if (IngredientWebUserControl8.Quantity != "" ||
          IngredientWebUserControl8.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl8.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl9
        if (IngredientWebUserControl9.Quantity != "" ||
          IngredientWebUserControl9.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl9.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl10
        if (IngredientWebUserControl10.Quantity != "" ||
          IngredientWebUserControl10.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl10.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl11
        if (IngredientWebUserControl11.Quantity != "" ||
           IngredientWebUserControl11.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl11.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl12
        if (IngredientWebUserControl12.Quantity != "" ||
          IngredientWebUserControl12.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl12.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl13
        if (IngredientWebUserControl13.Quantity != "" ||
          IngredientWebUserControl13.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl13.DDLName.SelectedIndex == 0)
            {
                ingredientTxtValid = false;
            }
        }

        // IngredientWebUserControl14
        if (IngredientWebUserControl14.Quantity != "" ||
          IngredientWebUserControl14.DDLUnit.SelectedIndex != 0)
        {
            if (IngredientWebUserControl14.DDLName.SelectedIndex == 0)
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

            /////////////////////////////////////////////////////////////////////////////////
            //// Create the list of Ingredients

            List<Ingredient> newListOfIngredients = new List<Ingredient>(); //new list of Ingredients

            //IngredientWebUserControl0
            if (IngredientWebUserControl0.IndexName != "--Select ingredient--")
            {
                double quantity = 0;
                if (!String.IsNullOrEmpty(IngredientWebUserControl0.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl0.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl0.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl0.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl1
            if (IngredientWebUserControl1.IndexName != "--Select ingredient--")
            {
                double quantity = 1;
                if (!String.IsNullOrEmpty(IngredientWebUserControl1.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl1.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl1.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl1.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl2
            if (IngredientWebUserControl2.IndexName != "--Select ingredient--")
            {
                double quantity = 2;
                if (!String.IsNullOrEmpty(IngredientWebUserControl2.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl2.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl2.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl2.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl3
            if (IngredientWebUserControl3.IndexName != "--Select ingredient--")
            {
                double quantity = 3;
                if (!String.IsNullOrEmpty(IngredientWebUserControl3.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl3.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl3.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl3.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl4
            if (IngredientWebUserControl4.IndexName != "--Select ingredient--")
            {
                double quantity = 4;
                if (!String.IsNullOrEmpty(IngredientWebUserControl4.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl4.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl4.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl4.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl5
            if (IngredientWebUserControl5.IndexName != "--Select ingredient--")
            {
                double quantity = 5;
                if (!String.IsNullOrEmpty(IngredientWebUserControl5.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl5.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl5.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl5.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl6
            if (IngredientWebUserControl6.IndexName != "--Select ingredient--")
            {
                double quantity = 6;
                if (!String.IsNullOrEmpty(IngredientWebUserControl6.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl6.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl6.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl6.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl7
            if (IngredientWebUserControl7.IndexName != "--Select ingredient--")
            {
                double quantity = 7;
                if (!String.IsNullOrEmpty(IngredientWebUserControl7.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl7.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl7.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl7.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl8
            if (IngredientWebUserControl8.IndexName != "--Select ingredient--")
            {
                double quantity = 8;
                if (!String.IsNullOrEmpty(IngredientWebUserControl8.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl8.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl8.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl8.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl9
            if (IngredientWebUserControl9.IndexName != "--Select ingredient--")
            {
                double quantity = 9;
                if (!String.IsNullOrEmpty(IngredientWebUserControl9.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl9.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl9.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl9.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl10
            if (IngredientWebUserControl10.IndexName != "--Select ingredient--")
            {
                double quantity = 10;
                if (!String.IsNullOrEmpty(IngredientWebUserControl10.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl10.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl10.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl10.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl11
            if (IngredientWebUserControl11.IndexName != "--Select ingredient--")
            {
                double quantity = 11;
                if (!String.IsNullOrEmpty(IngredientWebUserControl11.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl11.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl11.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl11.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl12
            if (IngredientWebUserControl12.IndexName != "--Select ingredient--")
            {
                double quantity = 12;
                if (!String.IsNullOrEmpty(IngredientWebUserControl12.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl12.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl12.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl12.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl13
            if (IngredientWebUserControl13.IndexName != "--Select ingredient--")
            {
                double quantity = 13;
                if (!String.IsNullOrEmpty(IngredientWebUserControl13.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl13.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl13.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl13.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }
            //IngredientWebUserControl14
            if (IngredientWebUserControl14.IndexName != "--Select ingredient--")
            {
                double quantity = 14;
                if (!String.IsNullOrEmpty(IngredientWebUserControl14.Quantity))
                {
                    quantity = Convert.ToDouble(IngredientWebUserControl14.Quantity);
                }
                Ingredient newIngredient = new Ingredient
                {
                    IndexIngredient = IngredientWebUserControl14.IndexName,
                    Quantity = quantity,
                    IndexUnitOfMeasure = IngredientWebUserControl14.IndexUnitOfMeasure
                };
                newListOfIngredients.Add(newIngredient);
            }

            // get category
            string indexCategory = "";
            if (DropDownListCategory.SelectedValue != "--Select ingredient--")
            {
                indexCategory = DropDownListCategory.SelectedValue;
            }

            Recipe newRecipe = new Recipe
            {
                NameRecipe = NameRecipeText.Text,
                SubmittedBy = SubmittedByText.Text,
                IndexCategory = indexCategory,
                PrepareTime = preparationTimeArray[0] + "h " + preparationTimeArray[1] + "min",
                NumberOfServings = Convert.ToInt32(NumberOfServingsText.Text),
                Description = RecipeDescriptionText.Text,
                IngredientList = newListOfIngredients
            };

            ((List<Recipe>)Application["recipes"]).Add(newRecipe);    // add new recipe instance to the list of recipes

            // Create connnection to RB_RecipeBook database
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;
            // Read the connection string from Web.config
            string connectionString =
                ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
            conn = new SqlConnection(connectionString);

            // Create sql command with insert statement
            comm = new SqlCommand("INSERT RB_Recipe (RecipeName, PrepareMinutes, NumberServings, " +
            "RecipeDescription, idCategory, idUser) " +
            "VALUES(@RecipeName, @PrepareMinutes, @NumberServings, " +
            "@RecipeDescription, @idCategory, @idUser);", conn);

            comm.Parameters.Add("@RecipeName", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@RecipeName"].Value = newRecipe.NameRecipe;
            comm.Parameters.Add("@PrepareMinutes", System.Data.SqlDbType.Int);
            comm.Parameters["@PrepareMinutes"].Value = preparationTimeArray[0] * 60 + preparationTimeArray[1];
            comm.Parameters.Add("@NumberServings", System.Data.SqlDbType.Int);
            comm.Parameters["@NumberServings"].Value = newRecipe.NumberOfServings;
            comm.Parameters.Add("@RecipeDescription", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@RecipeDescription"].Value = newRecipe.Description;
            comm.Parameters.Add("@idCategory", System.Data.SqlDbType.Int);
            comm.Parameters["@idCategory"].Value = !string.IsNullOrEmpty(newRecipe.IndexCategory) ?
                Convert.ToInt32(newRecipe.IndexCategory) : (object)DBNull.Value;
            comm.Parameters.Add("@idUser", System.Data.SqlDbType.Int);
            comm.Parameters["@idUser"].Value = (int)Application["idCurrentUser"];   // this is supposed to be the userid of the person that did login

            try
            {
                conn.Open();
                comm.ExecuteNonQuery();

                // get the index on the new recipe just created
                comm = new SqlCommand(
                    "SELECT MAX(idRecipe) FROM RB_Recipe;", conn);
                int maxRecipeIndex = 0;
                var returnValue = comm.ExecuteScalar();
                if (returnValue != null)
                {
                    maxRecipeIndex = Convert.ToInt32(returnValue);
                }

                // for each ingredient, we create a record in the RecipeIngredient table
                foreach(Ingredient ingred in newRecipe.IngredientList)
                {
                    // Create sql command with insert statement
                    comm = new SqlCommand("INSERT RB_RecipeIngredient (idRecipe, idIngredient, idUnit, Quantity) " +
                    "VALUES(@idRecipe, @idIngredient, @idUnit, @Quantity);" , conn);

                    // Create parameters
                    comm.Parameters.Add("@idRecipe", System.Data.SqlDbType.Int);
                    comm.Parameters["@idRecipe"].Value = maxRecipeIndex;
                    comm.Parameters.Add("@idIngredient", System.Data.SqlDbType.Int);
                    comm.Parameters["@idIngredient"].Value = Convert.ToInt32(ingred.IndexIngredient);
                    comm.Parameters.Add("@idUnit", System.Data.SqlDbType.Int);
                    comm.Parameters["@idUnit"].Value = Convert.ToInt32(ingred.IndexUnitOfMeasure);
                    comm.Parameters.Add("@Quantity", System.Data.SqlDbType.Float);
                    comm.Parameters["@Quantity"].Value = ingred.Quantity;

                    try
                    {
                        // Execute the command
                        comm.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageLabel.Text = "Error submitting the recipe. Try again!";
                    }

                }
                Response.Redirect("ConfirmationNewRecipe.aspx"); // redirect to the confirmation page
            }
            catch
            {
                MessageLabel.Text = "Error submitting the recipe. Try again!";
            }
            finally
            {
                conn.Close();
            }
        }

    }


    protected void Reset_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddRecipe.aspx");
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

    // Lisa Chiang, student number 300925122
}