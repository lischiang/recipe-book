<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ConfirmationNewRecipe.aspx.cs" Inherits="ConfirmationNewRecipe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <div class="headercontainermiddle" style="font-size:x-large">
         <p>Your new recipe has been saved!</p>
    </div>
     <div class="headercontainermiddle">
         <p>Check the complete list of the recipes <a href="Recipes.aspx">here</a>.</p>
     </div>
</asp:Content>

