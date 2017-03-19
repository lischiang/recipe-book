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
            DataTable storeTable = new DataTable();

            // Read the connection string from Web.config
            string connectionString =
                ConfigurationManager.ConnectionStrings["RB_RecipeBook"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Get data about users from the database
                    SqlDataAdapter adapterUsers = new SqlDataAdapter("SELECT idUser, UserName FROM RB_User", conn);
                    adapterUsers.Fill(storeTable);
                    // Populate dropdownlist
                    SubmittedByDropDownList.DataSource = storeTable;
                    SubmittedByDropDownList.DataTextField = "UserName";
                    SubmittedByDropDownList.DataValueField = "idUser";
                    SubmittedByDropDownList.DataBind();
                    // Add extra item "All"
                    SubmittedByDropDownList.Items.Insert(0, new ListItem("All Users"));

                    // Get data about categories from the database
                    SqlDataAdapter adapterCategories = new SqlDataAdapter("SELECT idCategory, CategoryName FROM RB_Category", conn);
                    adapterCategories.Fill(storeTable);
                    // Populate dropdownlist
                    CategoriesDropDownList.DataSource = storeTable;
                    CategoriesDropDownList.DataTextField = "CategoryName";
                    CategoriesDropDownList.DataValueField = "idCategory";
                    CategoriesDropDownList.DataBind();
                    // Add extra item "All"
                    CategoriesDropDownList.Items.Insert(0, new ListItem("All Categories"));

                    // Get data about ingredients from the database
                    SqlDataAdapter adapterIngredients = new SqlDataAdapter("SELECT idIngredient, IngredientName FROM RB_Ingredient", conn);
                    adapterIngredients.Fill(storeTable);
                    // Populate dropdownlist
                    IngrediensDropDownList.DataSource = storeTable;
                    IngrediensDropDownList.DataTextField = "IngredientName";
                    IngrediensDropDownList.DataValueField = "idIngredient";
                    IngrediensDropDownList.DataBind();
                    // Add extra item "All"
                    IngrediensDropDownList.Items.Insert(0, new ListItem("All Ingredients"));
                }
                catch (Exception ex)
                {
                    messageLabel.Text = "ERROR: " + ex.Message;
                }
            }

            //// Populate dropdown list for hours of preparation/cooking 
            //PrepareTimeHoursDropDownList.Items.Insert(0, new ListItem("--Select--"));
            //for (int i = 1; i < 26; i++)
            //{
            //    string value = (i - 1).ToString();
            //    PrepareTimeHoursDropDownList.Items.Insert(i, new ListItem(value));
            //}

            //// Populate dropdown list for minutes of preparation/cooking (multiple of 5)
            //PrepareTimeMinutesDropDownList.Items.Insert(0, new ListItem("--Select--"));
            //for (int i = 1; i < 61; i++)
            //{
            //    string value = (i - 1).ToString();
            //    PrepareTimeMinutesDropDownList.Items.Insert(i, new ListItem(value));
            //}
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

}