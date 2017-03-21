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

    private string indexCategory;   // category of the recipe
    public string IndexCategory
    {
        get { return indexCategory; }
        set { indexCategory = value; }
    }

    private string prepareTime;      // time of preparation/cooking of the recipe 
                                        // it will i the format Nh Mmin, where N is the numner of hours
                                        // and M the number of minutes
    public string PrepareTime
    {
        get { return prepareTime; }
        set { prepareTime = value; }
    }

    private int numberOfServings;      // number of servings of the recipe                                 
    public int NumberOfServings
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