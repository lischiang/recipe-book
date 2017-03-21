//Lisa Chiang, student number 300925122
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            

            // Read the connection string from Web.config
            string connectionString =
                ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Get data about users from the database
                    SqlDataAdapter adapterUsers = new SqlDataAdapter("SELECT idUser, UserName FROM RB_User", conn);
                    DataTable storeTableUsers = new DataTable();    // table to store the sql command
                    adapterUsers.Fill(storeTableUsers);
                    // Populate dropdownlist
                    SubmittedByDropDownList.DataSource = storeTableUsers;
                    SubmittedByDropDownList.DataTextField = "UserName";
                    SubmittedByDropDownList.DataValueField = "idUser";
                    SubmittedByDropDownList.DataBind();
                    // Add extra item "All"
                    SubmittedByDropDownList.Items.Insert(0, new ListItem("All Users"));

                    // Get data about categories from the database
                    SqlDataAdapter adapterCategories = new SqlDataAdapter("SELECT idCategory, CategoryName FROM RB_Category", conn);
                    DataTable storeTableCategories = new DataTable();    // table to store the sql command
                    adapterCategories.Fill(storeTableCategories);
                    // Populate dropdownlist
                    CategoriesDropDownList.DataSource = storeTableCategories;
                    CategoriesDropDownList.DataTextField = "CategoryName";
                    CategoriesDropDownList.DataValueField = "idCategory";
                    CategoriesDropDownList.DataBind();
                    // Add extra item "All"
                    CategoriesDropDownList.Items.Insert(0, new ListItem("All Categories"));

                    // Get data about ingredients from the database
                    SqlDataAdapter adapterIngredients = new SqlDataAdapter("SELECT idIngredient, IngredientName FROM RB_Ingredient", conn);
                    DataTable storeTableIngredients = new DataTable();    // table to store the sql command
                    adapterIngredients.Fill(storeTableIngredients);
                    // Populate dropdownlist
                    IngredientsDropDownList.DataSource = storeTableIngredients;
                    IngredientsDropDownList.DataTextField = "IngredientName";
                    IngredientsDropDownList.DataValueField = "idIngredient";
                    IngredientsDropDownList.DataBind();
                    // Add extra item "All"
                    IngredientsDropDownList.Items.Insert(0, new ListItem("All Ingredients"));
                }
                catch (Exception ex)
                {
                    MessageLabel.Text = "ERROR: " + ex.Message;
                }
            }
        }
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


    protected void SearchButton_Click(object sender, EventArgs e)
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        // Read the connection string from Web.config
        string connectionString =
            ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
        conn = new SqlConnection(connectionString);

        if (SubmittedByDropDownList.SelectedIndex == 0)
        {
            if (CategoriesDropDownList.SelectedIndex == 0)
            {
                if (IngredientsDropDownList.SelectedIndex == 0)
                {
                    // Create command for all the recipes
                    comm = new SqlCommand("SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser", conn);
                }
                else
                {
                    // Create command for recipes specified ingredient
                    comm = new SqlCommand(
                        "SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User, RB_RecipeIngredient " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser AND " +
                        "RB_RecipeIngredient.idRecipe = RB_Recipe.idRecipe AND " +
                        "RB_RecipeIngredient.idIngredient=@idIngredient", conn);
                    // Add the idIngredient parameter
                    comm.Parameters.Add("idIngredient", SqlDbType.Int);
                    comm.Parameters["idIngredient"].Value = IngredientsDropDownList.SelectedIndex;
                }
            }
            else
            {
                if (IngredientsDropDownList.SelectedIndex == 0)
                {
                    // Create command for recipes specified category
                    comm = new SqlCommand(
                        "SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User, RB_Category " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser AND " +
                        "RB_Category.idCategory = RB_Recipe.idCategory AND " +
                        "RB_Category.idCategory=@idCategory", conn);
                    // Add the idCategory parameter
                    comm.Parameters.Add("idCategory", SqlDbType.Int);
                    comm.Parameters["idCategory"].Value = CategoriesDropDownList.SelectedIndex;
                }
                else
                {
                    // Create command for recipes specified category and ingredient
                    comm = new SqlCommand(
                        "SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User, RB_RecipeIngredient, RB_Category " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser AND " +
                        "RB_RecipeIngredient.idRecipe = RB_Recipe.idRecipe AND " +
                        "RB_Category.idCategory = RB_Recipe.idCategory AND " +
                        "RB_Category.idCategory=@idCategory AND " +
                        "RB_RecipeIngredient.idIngredient=@idIngredient", conn);
                    // Add the idCategory and idIngredient parameters
                    comm.Parameters.Add("idCategory", SqlDbType.Int);
                    comm.Parameters["idCategory"].Value = CategoriesDropDownList.SelectedIndex;
                    comm.Parameters.Add("idIngredient", SqlDbType.Int);
                    comm.Parameters["idIngredient"].Value = IngredientsDropDownList.SelectedIndex;
                }
            }
        }
        else
        {
            if (CategoriesDropDownList.SelectedIndex == 0)
            {
                if (IngredientsDropDownList.SelectedIndex == 0)
                {
                    // Create command for recipes specified User
                    comm = new SqlCommand("SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser AND " +
                        "RB_Recipe.idUser=@idUser", conn);
                    // Add the idUser parameter
                    comm.Parameters.Add("idUser", SqlDbType.Int);
                    comm.Parameters["idUser"].Value = SubmittedByDropDownList.SelectedIndex;
                }
                else
                {
                    // Create command for recipes specified user and ingredient
                    comm = new SqlCommand(
                        "SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User, RB_RecipeIngredient " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser AND " +
                        "RB_RecipeIngredient.idRecipe = RB_Recipe.idRecipe AND " +
                        "RB_Recipe.idUser=@idUser AND " +
                        "RB_RecipeIngredient.idIngredient=@idIngredient", conn);
                    // Add the idUser and idIngredient parameters
                    comm.Parameters.Add("idUser", SqlDbType.Int);
                    comm.Parameters["idUser"].Value = SubmittedByDropDownList.SelectedIndex;
                    comm.Parameters.Add("idIngredient", SqlDbType.Int);
                    comm.Parameters["idIngredient"].Value = IngredientsDropDownList.SelectedIndex;
                }
            }
            else
            {
                if (IngredientsDropDownList.SelectedIndex == 0)
                {
                    // Create command for recipes specified User and category
                    comm = new SqlCommand("SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User, RB_Category " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser AND " +
                        "RB_Category.idCategory = RB_Recipe.idCategory AND " +
                        "RB_Category.idCategory=@idCategory AND " +
                        "RB_Recipe.idUser=@idUser", conn);
                    // Add the idUser and idCategory parameters
                    comm.Parameters.Add("idCategory", SqlDbType.Int);
                    comm.Parameters["idCategory"].Value = CategoriesDropDownList.SelectedIndex;
                    comm.Parameters.Add("idUser", SqlDbType.Int);
                    comm.Parameters["idUser"].Value = SubmittedByDropDownList.SelectedIndex;
                }
                else
                {
                    // Create command for recipes specified user, category, and ingredient
                    comm = new SqlCommand(
                        "SELECT RB_Recipe.idRecipe, RecipeName, UserName, PrepareMinutes " +
                        "FROM RB_Recipe, RB_User, RB_RecipeIngredient, RB_Category " +
                        "WHERE RB_Recipe.idUser = RB_User.idUser AND " +
                        "RB_Category.idCategory = RB_Recipe.idCategory AND " +
                        "RB_RecipeIngredient.idRecipe = RB_Recipe.idRecipe AND " +
                        "RB_Recipe.idUser=@idUser AND " +
                        "RB_Category.idCategory=@idCategory AND " +
                        "RB_RecipeIngredient.idIngredient=@idIngredient", conn);
                    // Add the idUser, idCategory, and idIngredient parameters
                    comm.Parameters.Add("idUser", SqlDbType.Int);
                    comm.Parameters["idUser"].Value = SubmittedByDropDownList.SelectedIndex;
                    comm.Parameters.Add("idCategory", SqlDbType.Int);
                    comm.Parameters["idCategory"].Value = CategoriesDropDownList.SelectedIndex;
                    comm.Parameters.Add("idIngredient", SqlDbType.Int);
                    comm.Parameters["idIngredient"].Value = IngredientsDropDownList.SelectedIndex;
                }
            }
        }

        // Enclose database code in Try-Catch-Finally
        try
        {
            // Open the connection
            conn.Open();
            // Execute the command
            reader = comm.ExecuteReader();

            // Fill the grid with data
            GridViewSearchResult.DataSource = reader;
            GridViewSearchResult.DataKeyNames = new string[] { "idRecipe" };
            GridViewSearchResult.DataBind();
            GridViewSearchResult.Visible = true;

            // Show header of the gridview containing the result of the search
            ResultLabel.Visible = true;

            // Close the reader
            reader.Close();
        }
        finally
        {
            // Close the connection
            conn.Close();
        }
    }

    protected void GridViewSearchResult_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDetails();
        Response.Redirect("RecipeDetails.aspx"); // redirect to the recipe detail page
    }

    private void BindDetails()
    {
        // Obtain the index of the selected row
        int selectedRowIndex = GridViewSearchResult.SelectedIndex;
        Application["indRecipeViewDetails"] = (int)GridViewSearchResult.DataKeys[selectedRowIndex].Value;
    }

    //Lisa Chiang, student number 300925122
}