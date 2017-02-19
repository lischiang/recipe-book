using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Recipe is a class object that describes a recipe
/// </summary>
public class Recipe
{
    public Recipe()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private string nameRecipe;            // name of the recipe
    public string NameRecipe
    {
        get { return nameRecipe; }
        set { nameRecipe = value; }
    }

    private string submittedBy;        // name of the person that submitted the recipe
    public string SubmittedBy
    {
        get { return submittedBy; }
        set { submittedBy = value; }
    }

    private string category;   // category of the recipe
    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    private int[] prepareTime;      // time of preparation/cooking of the recipe 
                                        // (will be an array of lenght 2 {hours,minutes})
    public int [] PrepareTime
    {
        get { return prepareTime; }
        set { prepareTime = value; }
    }

    private string numberOfServings;      // number of servings of the recipe                                 
    public string NumberOfServings
    {
        get { return numberOfServings; }
        set { numberOfServings = value; }
    }

    private string description;   // description of the recipe
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    private List<Ingredient> ingredientList;   // list of the ingredients of the recipe
    public List<Ingredient> IngredientList
    {
        get { return ingredientList; }
        set { ingredientList = value; }
    }

}