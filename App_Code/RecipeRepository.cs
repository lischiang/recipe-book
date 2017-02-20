using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RecipeRepository
/// </summary>
public class RecipeRepository
{
    public RecipeRepository()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<RecipePreview> GetRecipePreviews()
    {
        //List<Recipe> currentListOfRecipes = (List<Recipe>)HttpContext.Current.Application["recipes"];
        List<RecipePreview> currentListOfRecipePreviews = new List<RecipePreview>();
        foreach(Recipe recipe in (List<Recipe>)HttpContext.Current.Application["recipes"])
        {
            RecipePreview newRecipePreview = new RecipePreview
            {
                NameRecipe = recipe.NameRecipe,
                SubmittedBy = recipe.SubmittedBy,
                PrepareTime = recipe.PrepareTime
            };
        }
        return currentListOfRecipePreviews;
    }
}