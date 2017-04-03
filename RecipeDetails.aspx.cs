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
            // Open the connection
            conn.Open();
            // Execute the command
            reader = comm.ExecuteReader();

            // Fill the grid with data
            IngredientsGridView.DataSource = reader;
            IngredientsGridView.DataBind();
            // Close the reader
            reader.Close();
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