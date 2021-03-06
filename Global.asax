﻿<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        List<Recipe> recipes = new List<Recipe>();
        Application["recipes"] = recipes;       // application variable: list of the recipes

        int indRecipeViewDetails = -1;
        Application["indRecipeViewDetails"] = indRecipeViewDetails;

        int idCurrentUser = 1; // this value needs to be updated at the login of a certain user. Set to 1 for example
        Application["idCurrentUser"] = idCurrentUser;

        List<Ingredient> newListOfIngredients = new List<Ingredient>(); //new list of Ingredients
        Application["ingredients"] = newListOfIngredients;       // application variable: list of ingredients
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
