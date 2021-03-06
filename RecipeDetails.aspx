﻿<%--Lisa Chiang, student number 300925122--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RecipeDetails.aspx.cs" Inherits="RecipeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:DetailsView ID="RecipeDetailView" runat="server" Height="50px" Width="700px" 
        AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" 
        BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical"
        DataSourceID="recipeDataSource" 
        DataKeyNames="idRecipe" onmodechanging="RecipeDetailView_ModeChanging">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <EditRowStyle BackColor="#c1c1d7" Font-Bold="True" ForeColor="White" />
        <FieldHeaderStyle Font-Bold="True"/>
        <Fields>
            <asp:TemplateField HeaderText="Category">
                <EditItemTemplate>
                    <asp:DropDownList ID="editCategoryDropDownList" runat="server" 
                        DataSourceID="categoryDataSource" 
                        DataTextField="CategoryName" DataValueField="idCategory"
                            SelectedValue='<%# Bind("idCategory")%>'>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Category" runat="server" Text='<%# Bind("CategoryName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="UserName" HeaderText="Submitted by" InsertVisible="False" ReadOnly="True"/>                
            <asp:TemplateField HeaderText="Preparation Time">
                <EditItemTemplate>
                    <asp:TextBox ID="editPrepareMinutesTextBox" runat="server" Text='<%# Bind("PrepareMinutes") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="PrepareMinutes" runat="server" Text='<%# Bind("PrepareMinutes") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number of Servings">
                <EditItemTemplate>
                    <asp:TextBox ID="editNumberServingsTextBox" runat="server" Text='<%# Bind("NumberServings") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="NumberServings" runat="server" Text='<%# Bind("NumberServings") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Directions">
                <EditItemTemplate>
                    <asp:TextBox ID="editRecipeDescriptionTextBox" runat="server" Text='<%# Bind("RecipeDescription") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="RecipeDescription" runat="server" Text='<%# Bind("RecipeDescription") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="True" />         
        </Fields> 
        <HeaderStyle Font-Bold="true" Font-Size="Larger" Height="70px" HorizontalAlign="Center" BackColor="Black" ForeColor="White"/>
        <HeaderTemplate>
            <%#Eval("RecipeName")%>
        </HeaderTemplate>  
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
    </asp:DetailsView>
    <br />
    <%--Gridview for ingredients--%>
    <asp:GridView ID="IngredientsGridView" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />

    </asp:GridView>


    <%--Data source for recipe--%>
    <asp:SqlDataSource ID="recipeDataSource" runat="server"
            ConnectionString="<%$ ConnectionStrings:RB_RecipeBook %>"
        SelectCommand="SELECT [idRecipe], [RecipeName], [UserName], [RB_Recipe].[idCategory], [CategoryName], [PrepareMinutes], [NumberServings], [RecipeDescription] 
        FROM [RB_Category], [RB_Recipe], [RB_User] WHERE [RB_Category].[idCategory]=[RB_Recipe].[idCategory] AND [RB_Recipe].[idUser]=[RB_User].[idUser] AND idRecipe=@idRecipe"
        UpdateCommand="UPDATE RB_Recipe SET idCategory=@idCategory, PrepareMinutes=@PrepareMinutes, NumberServings=@NumberServings, RecipeDescription=@RecipeDescription 
        WHERE idRecipe=@idRecipe">  
        <SelectParameters>
            <asp:Parameter Name="idRecipe" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="idRecipe" Type="Int32" />
            <asp:Parameter Name="idCategory" Type="Int32" />
            <asp:Parameter Name="PrepareMinutes" Type="Int32" />
            <asp:Parameter Name="NumberServings" Type="Int32" />
            <asp:Parameter Name="RecipeDescription" Type="String" />
        </UpdateParameters>      
    </asp:SqlDataSource>
    <%--Data source for category drop down list--%>
    <asp:SqlDataSource ID="categoryDataSource" runat="server"
        ConnectionString="<%$ ConnectionStrings:RB_RecipeBook %>"
        SelectCommand="SELECT [idCategory], [CategoryName] FROM [RB_Category]">
    </asp:SqlDataSource>      
    <p>
        <asp:button ID="DeleteRecipeButton" runat="server" text="Delete Recipe" OnClick="DeleteRecipeButton_Click" />
    </p>
    <asp:label ID="MessageLabel" runat="server" text=""></asp:label>
    <%--<asp:label ID="MessageLabel1" runat="server" text="Label"></asp:label>--%>

    <p>
        <a href="Recipes.aspx">Go back to the list of recipes</a>
    </p>
</asp:Content>

