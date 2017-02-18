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

    private string name;            // name of the ingredient
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private double quantity;        // quantity of the ingredient
    public double Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    private string unitOfMeasure;   // unit of measure of the ingredient
    public string UnitOfMeasure
    {
        get { return unitOfMeasure; }
        set { unitOfMeasure = value; }
    }
}