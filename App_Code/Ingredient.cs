using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Ingredient is a class object that describes an ingredient of a recipe
/// </summary>
public class Ingredient
{
    public Ingredient()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private string indexIngredient;            // index of the ingredient
    public string IndexIngredient
    {
        get { return indexIngredient; }
        set { indexIngredient = value; }
    }

    private string nameIngredient;            // name of the ingredient
    public string NameIngredient
    {
        get { return nameIngredient; }
        set { nameIngredient = value; }
    }

    private double quantity;        // quantity of the ingredient
    public double Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    private string indexUnitOfMeasure;   // index of the unit of measure 
    public string IndexUnitOfMeasure
    {
        get { return indexUnitOfMeasure; }
        set { indexUnitOfMeasure = value; }
    }

    private string nameUnitOfMeasure;           // name of the unit of measure 
    public string NameUnitOfMeasure
    {
        get { return nameUnitOfMeasure; }
        set { nameUnitOfMeasure = value; }
    }
}