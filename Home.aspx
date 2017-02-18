<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="headercontainerdown">
        <h1 class="whiteshadow" style="font-size: 38pt"><b>Recipe Book</b></h1>
    </div>
    <div class="headercontainerup" style="font-size: 18pt">
        <p class="whiteshadow">Your online cookbook!</p>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
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
</asp:Content>
