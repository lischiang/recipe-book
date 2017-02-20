using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// This class is used to visualize the preview of the recipes saved in the application,
/// as it contains just the name of the recipe, the name of the person who submitted the 
/// recipe and the time for preparation/cooking
/// </summary>
public class RecipePreview
{
    public RecipePreview()
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

    private string prepareTime;      // time of preparation/cooking of the recipe 
                                     // it will i the format Nh Mmin, where N is the numner of hours
                                     // and M the number of minutes
    public string PrepareTime
    {
        get { return prepareTime; }
        set { prepareTime = value; }
    }
}