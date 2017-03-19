<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RecipeDetails.aspx.cs" Inherits="RecipeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat="server">
        <asp:DetailsView ID="RecipeDetailView" runat="server" Height="50px" Width="700px" 
            AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" 
            BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <EditRowStyle BackColor="#c1c1d7" Font-Bold="True" ForeColor="White" />
            <FieldHeaderStyle Font-Bold="True"/>
            <Fields>
                <asp:BoundField DataField="PrepareMinutes" HeaderText="Preparation Time"/>
                <asp:BoundField DataField="NumberServings" HeaderText="Number of Servings" />
                <asp:TemplateField HeaderText="Ingredients">
                    <ItemTemplate> 
                        <asp:GridView ID="IngredientsGridView" runat="server" ShowHeader="False">
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="RecipeDescription" HeaderText="Directions" />             
            </Fields> 
            <HeaderStyle Font-Bold="true" Font-Size="Larger" Height="70px" HorizontalAlign="Center" BackColor="Black" ForeColor="White"/>
            <HeaderTemplate>
                <%#Eval("RecipeName")%>
            </HeaderTemplate>  
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        </asp:DetailsView>

        <p>
            <asp:button ID="DeleteRecipeButton" runat="server" text="Delete Recipe" OnClick="DeleteRecipeButton_Click" />
        </p>
    </form>
    <p>
        <a href="Recipes.aspx">Go back to the list of recipes</a>
    </p>
</asp:Content>

