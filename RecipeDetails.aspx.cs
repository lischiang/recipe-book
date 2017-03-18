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
            RecipeDetailView.DataKeyNames = new string[] { "EmployeeID" };
            RecipeDetailView.DataBind();
            // Close the reader
            reader.Close();
        }
        finally
        {
            // Close the connection
            conn.Close();
        }
    }

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