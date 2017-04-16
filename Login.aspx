<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recipe Book</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
        <div class="banner">
            <div class="headercontainerdown">
            <h1 class="whiteshadow" style="font-size: 38pt"><b>Recipe Book</b></h1>
        </div>
        <div class="headercontainerup" style="font-size: 18pt">
            <p class="whiteshadow">Your online cookbook!</p>
        </div> 
        </div> 
        
        <div>
            <asp:Login ID="LoginRecipeBook" runat="server"></asp:Login>
        </div>
        <table style="max-width: 1000px; margin: auto">
        <tr style="height: 400px">
            <td>
                <p>
                    <i>With <b>Recipe Book</b> you can create your personalized online cookbook and access it 
                from your computer with a simple click!</i>
                </p>
                <br />
                <p>
                    <i>It is easy: just click on 'Add Recipe' and create your personal recipes. 
                    You can add all the information of your culinary masterpieces.
                    
                    </i>
                </p>
                <br />
                <p>
                    <i>Then you can find all your 
                    recipes in the 'Recipes' section, subdivided by category if you need, and you can search 
                    for them in the 'Search' page.</i>
                </p>
                <br />
                <p style="font-size: 13pt">
                    <i>Have fun!</i>
                </p>
            </td>
            <td>
                <img src="images/cook.png" height="250" /></td>

        </tr>

    </table>
    </form>
</body>
</html>
