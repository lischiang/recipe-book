﻿// Lisa Chiang, student number 300925122
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Recipes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindGrid();
        }
    }

    // Set the theme
    protected void Page_PreInit(object sender, EventArgs e)
    {
        HttpCookie cookie;
        cookie = Request.Cookies["theme"];

        if (cookie != null)
        {
            Page.Theme = cookie.Value;
        }
        else
        {
            Page.Theme = "Light";
        }
    }

    private void BindGrid()
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;
        // Read the connection string from Web.config
        string connectionString =
            ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;
        conn = new SqlConnection(connectionString);

        // Create command 
        comm = new SqlCommand(
            "SELECT idRecipe, RecipeName, UserName, PrepareMinutes " +
            "FROM RB_Recipe, RB_User " +
            "WHERE RB_Recipe.idUser = RB_User.idUser" , conn);

        try
        {
            // Open the connection
            conn.Open();
            reader = comm.ExecuteReader();
            GridViewRecipes.DataSource = reader;
            GridViewRecipes.DataKeyNames = new string[] { "idRecipe" };
            GridViewRecipes.DataBind();
            reader.Close();
        }
        finally
        {
            // Close the connection
            conn.Close();
        }
    }

    protected void GridViewRecipes_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindDetails();
        Response.Redirect("RecipeDetails.aspx"); // redirect to the recipe detail page
    }

    private void BindDetails()
    {
        // Obtain the index of the selected row
        int selectedRowIndex = GridViewRecipes.SelectedIndex;
        Application["indRecipeViewDetails"] = (int)GridViewRecipes.DataKeys[selectedRowIndex].Value;
    }

    // Lisa Chiang, student number 300925122
}
