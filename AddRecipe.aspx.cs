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

    protected void addNewCategoryLinkButton_Click(object sender, EventArgs e)
    {
        addNewCategoryLinkButton.Visible = false;

        newCategoryTextBox.Visible = true;
        newCategoryTextBox.Enabled = true;
        newCategoryTextBox.Focus();
        newCategoryConfirmButton.Visible = true;

    }

    protected void newCategoryConfirmButton_Click(object sender, EventArgs e)
    {
        // Create connnection to RB_RecipeBook database
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        // Read the connection string from Web.config
        string connectionString =
            ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
        conn = new SqlConnection(connectionString);

        // Create sql command with insert statement
        comm = new SqlCommand("INSERT RB_Category (CategoryName) " +
        "VALUES(@CategoryName);", conn);

        // Create parameters
        comm.Parameters.Add("@CategoryName", System.Data.SqlDbType.NVarChar);
        comm.Parameters["@CategoryName"].Value = newCategoryTextBox.Text;

        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
        }
        catch
        {
            MessageLabel.Text = "Error while adding the new category. Try again!";
        }
        finally
        {
            conn.Close();
        }

        // Hyde new category objects
        newCategoryTextBox.Visible = false;
        newCategoryTextBox.Enabled = false;
        newCategoryConfirmButton.Visible = false;

        DropDownListCategory.DataBind();


    }
}