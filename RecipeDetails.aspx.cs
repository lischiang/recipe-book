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
        BindDetails();
    }

    private void BindDetails()
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
        comm = new SqlCommand(
            "SELECT RecipeName, PrepareMinutes, NumberServings, RecipeDescription " +
            "FROM RB_Recipe " +
            "WHERE idRecipe=@idRecipe", conn);
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

            // Fill the grid with data
            RecipeDetailView.DataSource = reader;
            RecipeDetailView.DataBind();
            // Close the reader
            reader.Close();

            GridView IngredientGridView = (GridView)RecipeDetailView.FindControl("IngredientsGridView");
            if (IngredientGridView != null)
            {
                comm = new SqlCommand(
                      "SELECT Quantity, UnitName, IngredientName " +
                      "FROM RB_RecipeIngredient, RB_MeasureUnit, RB_Ingredient " +
                      "WHERE (idRecipe=@idRecipe AND " +
                      "RB_RecipeIngredient.idIngredient = RB_Ingredient.idIngredient AND " +
                      "RB_RecipeIngredient.idUnit = RB_MeasureUnit.idUnit)", conn);
                // Add the idRecipe parameter
                comm.Parameters.Add("idRecipe", SqlDbType.Int);
                comm.Parameters["idRecipe"].Value = (int)Application["indRecipeViewDetails"];

                // Enclose database code in Try-Catch-Finally
                try
                {
                    // Execute the command
                    reader = comm.ExecuteReader();

                    // Fill the grid with data
                    IngredientGridView.DataSource = reader;
                    IngredientGridView.DataBind();
                    // Close the reader
                    reader.Close();
                }
                finally
                {
                    // Close the connection
                    conn.Close();
                }

            }
        }
        finally
        {
            // Close the connection
            conn.Close();
        }  
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