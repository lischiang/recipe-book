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
                }
                catch (Exception ex)
                {
                    MessageLabel.Text = "ERROR: " + ex.Message;
                }
            }
        }
    }
  
    protected void NewRecipeButton_Click(object sender, EventArgs e)
    {
        // Check if the all the ingredients have a name

        bool ingredientTxtValid = true;

        MessageLabel.Text = IngredientWebUserControl0.DDLUnit.SelectedIndex.ToString();
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
          //// Create the list of objects Ingredient

          List<Ingredient> newListOfIngredients = new List<Ingredient>(); //new list of objects Ingredient

            MessageLabel.Text = IngredientWebUserControl0.IndexName;



            // IngredientWebUserControl0
            //if (IngredientWebUserControl0.IndexName != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl0.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl0.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl0.UnitOfMeasure
            //    };           
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl1
            //if (IngredientWebUserControl1.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl1.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl1.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl1.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl2
            //if (IngredientWebUserControl2.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl2.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl2.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl2.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl3
            //if (IngredientWebUserControl3.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl3.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl3.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl3.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl4
            //if (IngredientWebUserControl4.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl4.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl4.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl4.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl5
            //if (IngredientWebUserControl5.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl5.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl5.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl5.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl6
            //if (IngredientWebUserControl6.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl6.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl6.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl6.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl7
            //if (IngredientWebUserControl7.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl7.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl7.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl7.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl8
            //if (IngredientWebUserControl8.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl8.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl8.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl8.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl9
            //if (IngredientWebUserControl9.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl9.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl9.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl9.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl10
            //if (IngredientWebUserControl10.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl10.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl10.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl10.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl11
            //if (IngredientWebUserControl11.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl11.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl11.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl11.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl12
            //if (IngredientWebUserControl12.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl12.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl12.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl12.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl13
            //if (IngredientWebUserControl13.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl13.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl13.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl13.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}
            //// IngredientWebUserControl14
            //if (IngredientWebUserControl14.Name != "")
            //{
            //    Ingredient newIngredient = new Ingredient
            //    {
            //        Name = IngredientWebUserControl14.Name,
            //        Quantity = Convert.ToDouble(IngredientWebUserControl14.Quantity),
            //        UnitOfMeasure = IngredientWebUserControl14.UnitOfMeasure
            //    };
            //    newListOfIngredients.Add(newIngredient);
            //}

            /*
            Recipe newRecipe = new Recipe
          {
              NameRecipe = NameRecipeText.Text,
              SubmittedBy = SubmittedByText.Text,
              Category = CategoryText.Text,
              PrepareTime = preparationTimeArray[0] + "h " + preparationTimeArray[1] + "min",
              NumberOfServings = NumberOfServingsText.Text,
              Description = RecipeDescriptionText.Text,
              IngredientList = newListOfIngredients
          };

          ((List<Recipe>)Application["recipes"]).Add(newRecipe);

          // Create connnection to RB_RecipeBook database
          SqlConnection conn;
          SqlCommand comm;
          SqlDataReader reader;
          // Read the connection string from Web.config
          string connectionString =
              ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
          conn = new SqlConnection(connectionString);

          // Create sql command with insert statement
          comm = new SqlCommand(
              "INSERT INTO RB_Recipe (RecipeName, PrepareMinutes, NumberServings, " + 
              "RecipeDescription, idCategory, idUser)" + 
              "VALUES(@RecipeName, @@PrepareMinutes, @NumberServings, " + 
              "@RecipeDescription, @idCategory, @idUser);", conn);
          comm.Parameters.Add("@EmployeeID", System.Data.SqlDbType.Int);
          comm.Parameters["@EmployeeID"].Value = 5;

     
        Response.Redirect("ConfirmationNewRecipe.aspx"); // redirect to the confirmation page   
        */
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
}