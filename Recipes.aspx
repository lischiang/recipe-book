<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Recipes.aspx.cs" Inherits="Recipes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div> 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat="server">
        <div>
            <ul>
                <li><a href="#">All the recipes</a></li>
                <li><a href="#">Your favourite recipes</a></li>
                <li><a href="#">Recently added recipes</a></li>
                <li>Recipes by category:
                    <asp:DropDownList ID="CategoriesDropDownList" runat="server">
                    </asp:DropDownList>
                </li>
            </ul>
        </div>
    </form>

        <table class="recipecontainer">
          <tr>
            <td style="width:400px">
                <h2><u>Recipe 1</u></h2>
                <div>
                    <h4>Ingredients</h4>
                    <ul>
                        <li>Ingredient 1</li>
                        <li>Ingredient 2</li>
                        <li>Ingredient 3</li>
                    </ul>
                </div>

                <h4>Directions</h4>
                <div>
                    ...Steps to prepare the dish...
                </div>
            </td>
            <td>
                <img src="images/empty_dish.jpg" style="width:304px;height:228px;"/>
            </td>
          </tr>
        </table>

</asp:Content>


