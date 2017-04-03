// Lisa Chiang, student number 300925122
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class RecipeDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //BindDetails();
    }

    private void BindDetails()
    {
        //// Define data objects
        //SqlConnection conn;
        //SqlCommand comm;
        //SqlDataReader reader;
        //// Read the connection string from Web.config
        //string connectionString =
        //    ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
        //// Initialize connection
        //conn = new SqlConnection(connectionString);
        //// Create command
        //comm = new SqlCommand(
        //    "SELECT idRecipe, RecipeName, RB_Recipe.idCategory, CategoryName, UserName, PrepareMinutes, NumberServings, RecipeDescription " +
        //    "FROM RB_Recipe, RB_Category, RB_User " +
        //    "WHERE idRecipe=@idRecipe AND RB_Recipe.idCategory=RB_Category.idCategory AND RB_Recipe.idUser=RB_User.idUser ", conn);
        //// Add the EmployeeID parameter
        //comm.Parameters.Add("idRecipe", SqlDbType.Int);
        //comm.Parameters["idRecipe"].Value = (int)Application["indRecipeViewDetails"];

        //// Enclose database code in Try-Catch-Finally
        //try
        //{
        //    // Open the connection
        //    conn.Open();
        //    // Execute the command
        //    reader = comm.ExecuteReader();

        //    // Fill the grid with data
        //    RecipeDetailView.DataSource = reader;
        //    RecipeDetailView.DataBind();
        //    // Close the reader
        //    reader.Close();

        //    GridView IngredientGridView = (GridView)RecipeDetailView.FindControl("IngredientsGridView");
        //    if (IngredientGridView != null)
        //    {
        //        comm = new SqlCommand(
        //              "SELECT Quantity, UnitName, IngredientName " +
        //              "FROM RB_RecipeIngredient, RB_MeasureUnit, RB_Ingredient " +
        //              "WHERE (idRecipe=@idRecipe AND " +
        //              "RB_RecipeIngredient.idIngredient = RB_Ingredient.idIngredient AND " +
        //              "RB_RecipeIngredient.idUnit = RB_MeasureUnit.idUnit)", conn);
        //        // Add the idRecipe parameter
        //        comm.Parameters.Add("idRecipe", SqlDbType.Int);
        //        comm.Parameters["idRecipe"].Value = (int)Application["indRecipeViewDetails"];

        //        // Enclose database code in Try-Catch-Finally
        //        try
        //        {
        //            // Execute the command
        //            reader = comm.ExecuteReader();

        //            // Fill the grid with data
        //            IngredientGridView.DataSource = reader;
        //            IngredientGridView.DataBind();
        //            // Close the reader
        //            reader.Close();
        //        }
        //        finally
        //        {
        //            // Close the connection
        //            conn.Close();
        //        }

        //    }
        //}
        //finally
        //{
        //    // Close the connection
        //    conn.Close();
        //}  
    }

    // Lisa Chiang, student number 300925122
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

    protected void RecipeDetailView_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        //// Save the category of the visualized recipe
        //Label labelCategoryName =
        //   (Label)RecipeDetailView.FindControl("Category");
        //string categoryName = labelCategoryName.Text;

        // Change current mode to the selected one
        RecipeDetailView.ChangeMode(e.NewMode);
        // Rebind the grid
        BindDetails();

        //// set the selected value of the dropdown list to the actual category of the recipe
        //DropDownList newCategoryDropDownList =
        //   (DropDownList)RecipeDetailView.FindControl("editCategoryDropDownList");
   
        //for (int i = 0; i < newCategoryDropDownList.Items.Count; i++)
        //{
        //    if (newCategoryDropDownList.Items[i].ToString() == categoryName)
        //    {
        //        newCategoryDropDownList.SelectedValue = (i + 1).ToString();
        //    }
        //}

    }

    protected void RecipeDetailView_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {

        ////////////>>>>>> NEED TO USE A DATA SOURCE

        //// Read the employee from the DetailsView object
        //int idRecipe = (int)RecipeDetailView.DataKey.Value;

        //// Find the TextBox controls with updated data
        //DropDownList newCategoryDropDownList =
        //   (DropDownList)RecipeDetailView.FindControl("editCategoryDropDownList");
        //TextBox newPrepareMinutesTextBox =
        //   (TextBox)RecipeDetailView.FindControl("editPrepareMinutesTextBox");
        //TextBox newNumberServingsTextBox =
        //   (TextBox)RecipeDetailView.FindControl("editNumberServingsTextBox");
        //TextBox newRecipeDescriptionTextBox =
        //   (TextBox)RecipeDetailView.FindControl("editRecipeDescriptionTextBox");

        //// Extract the updated data from the DropDownList and TextBoxes
        //int newIdCategory = int.Parse(newCategoryDropDownList.SelectedValue);
        //int newPrepareMinutes;
        //if (!int.TryParse(newPrepareMinutesTextBox.Text, out newPrepareMinutes))
        //{
        //    MessageLabel.Text = "ERROR: please verify the inserted data";
        //}
        //MessageLabel.Text = newPrepareMinutes.ToString();
        //int newNumberServings;
        //if (!int.TryParse(newNumberServingsTextBox.Text, out newNumberServings))
        //{
        //    MessageLabel.Text = "ERROR: please verify the inserted data";
        //}
        //string newRecipeDescription = newRecipeDescriptionTextBox.Text;

        ////// Define data objects
        //SqlConnection conn;
        //SqlCommand comm;
        //// Initialize connection
        //string connectionString =
        //   ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
        //// Initialize connection
        //conn = new SqlConnection(connectionString);
        //// Create command 
        ////comm = new SqlCommand(
        ////    "UPDATE RB_Recipe " +
        ////    "SET idCategory=@idCategory, PrepareMinutes=@PrepareMinutes, NumberServings=@NumberServings, RecipeDescription=@RecipeDescription " +
        ////    "WHERE idRecipe=@idRecipe;", conn);
        //comm = new SqlCommand(
        //    "UPDATE RB_Recipe " +
        //    "SET idCategory=5, PrepareMinutes=@PrepareMinutes, NumberServings=3, RecipeDescription='new description' " +
        //    "WHERE idRecipe=@idRecipe;", conn);
        //// Add parameters to the created command
        //comm.Parameters.Add("idRecipe", SqlDbType.Int);
        //comm.Parameters["idRecipe"].Value = (int)Application["indRecipeViewDetails"];
        //comm.Parameters.Add("idCategory", SqlDbType.Int);
        //comm.Parameters["idCategory"].Value = (int)newIdCategory;
        //comm.Parameters.Add("PrepareMinutes", SqlDbType.Int);
        //comm.Parameters["PrepareMinutes"].Value = (int)newPrepareMinutes;
        ////comm.Parameters.Add("NumberServings", SqlDbType.Int);
        ////comm.Parameters["NumberServings"].Value = newNumberServings;
        ////comm.Parameters.Add("RecipeDescription", SqlDbType.NVarChar, 1000);
        ////comm.Parameters["RecipeDescription"].Value = newRecipeDescription;

        //// Enclose database code in Try-Catch-Finally
        //try
        //{
        //    // Open the connection
        //    conn.Open();
        //    // Execute the command
        //    comm.ExecuteNonQuery();
        //}
        //finally
        //{
        //    // Close the connection
        //    conn.Close();
        //}
        //// Exit edit mode
        //RecipeDetailView.ChangeMode(DetailsViewMode.ReadOnly);
        //// Reload the details view
        //BindDetails();
    }


    protected void DeleteRecipeButton_Click(object sender, EventArgs e)
    {
        // Define data objects
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        // Read the connection string from Web.config
        string connectionString =
            ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
        // Initialize connection
        conn = new SqlConnection(connectionString);
        // Create command
        comm = new SqlCommand("DELETE FROM RB_RecipeIngredient WHERE idRecipe=@idRecipe; " +
            "DELETE FROM RB_Recipe WHERE idRecipe = @idRecipe", conn);
        // Add the EmployeeID parameter
        comm.Parameters.Add("idRecipe", SqlDbType.Int);
        comm.Parameters["idRecipe"].Value = (int)Application["indRecipeViewDetails"];

        // Enclose database code in Try-Catch-Finally
        try
        {
            // Open the connection
            conn.Open();
            // Execute the command
            reader = comm.ExecuteReader();
            // Close the reader
            reader.Close();
        }
        finally
        {
            // Close the connection
            conn.Close();
        }

        Response.Redirect("ConfirmationDeleteRecipe.aspx"); // redirect to the recipe detail page
    }
    // Lisa Chiang, student number 300925122
}