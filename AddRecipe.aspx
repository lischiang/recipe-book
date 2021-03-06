﻿<%--Lisa Chiang, student number 300925122--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddRecipe.aspx.cs" Inherits="AddRecipe" %>

<%@ Register Src="~/IngredientWebUserControl.ascx" TagPrefix="uc1" TagName="IngredientWebUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <%--Form to add a new recipe--%>
    <div class="recipecontainer">
        <table style="margin-left: auto; margin-right: auto; max-width: 1000px; max-height: none">
            <tr>
                <%--Header of the form--%>
                <th colspan="3" style="height: 100px; align-content: flex-start; vertical-align: top">
                    <h2 style="text-align: center">Create a new recipe!</h2>
                </th>
            </tr>

            <asp:ValidationSummary 
                ID="ValidationSummaryAddRecipe" 
                runat="server" 
                HeaderText="We cannot submit your recipe:" 
                ShowMessageBox="false" 
                DisplayMode="BulletList" 
                ShowSummary="true"
                ValidationGroup="MissingFields"
                Width="450"
                ForeColor="Red"
                Font-Italic="true" Height="500px"
                />

            <%--Name new recipe--%>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Name of your recipe:"></asp:Label>
                </td>
                <td>
                    <asp:textbox id="NameRecipeText" runat="server" CssClass="form-control span6"></asp:textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNameRecipe" 
                    runat="server" ControlToValidate = "NameRecipeText" 
                    ErrorMessage="Name of the recipe missing" Text="*"
                        ValidationGroup="MissingFields"
                    SetFocusOnError ="true" ForeColor="Red"/>
                </td>
                    
            </tr>

            <%--"Submitted by" new recipe--%>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Submitted by:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="SubmittedByDropDownList" runat="server" 
                        DataTextField="UserName" DataValueField="idUser">
                    </asp:DropDownList>
                </td>
            </tr>

            <%--Category new recipe--%>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Category:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownListCategory" runat="server" DataSourceID="categoryDataSource" 
                        DataTextField="CategoryName" DataValueField="idCategory">
                    </asp:DropDownList>
                    <asp:LinkButton ID="addNewCategoryLinkButton" runat="server" Text="Add new Category..." OnClick="addNewCategoryLinkButton_Click"></asp:LinkButton>
                    <asp:TextBox ID="newCategoryTextBox" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                    <asp:Button ID="newCategoryConfirmButton" runat="server" Text="Save New Category" visible="false" OnClick="newCategoryConfirmButton_Click"/>
                </td>
            </tr>

            <%--Prepare/Cooking time new recipe--%>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Prepare/Cooking time:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="PrepareTimeHoursDropDownList" runat="server"></asp:DropDownList>
                    <asp:Label runat="server" Text="hours" Font-Size="X-Small"></asp:Label>
                    &nbsp; &nbsp;
                    <asp:DropDownList ID="PrepareTimeMinutesDropDownList" runat="server"></asp:DropDownList>
                    <asp:Label runat="server" Text="minutes" Font-Size="X-Small"></asp:Label>
                </td>
            </tr>

            <%--Number of servings new recipe--%>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Number of servings:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="NumberOfServingsText" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumberOfServings" 
                    runat="server" ControlToValidate = "NumberOfServingsText" 
                    ErrorMessage="Number of servings missing" Text="*"
                    ValidationGroup="MissingFields"
                    SetFocusOnError ="true" ForeColor="Red"/>
                </td>
            </tr>

            <%--Recipe description new recipe--%>
            <tr>
                <td style="vertical-align: top">
                    <asp:Label runat="server" Text="Recipe description:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="RecipeDescriptionText" runat="server" Height="150px" 
                        Width="167.5px" TextMode ="MultiLine" 
                        style="margin-left: 0px; max-width: 300px; max-height:350px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorRecipeDescription" 
                    runat="server" ControlToValidate = "RecipeDescriptionText" 
                    ErrorMessage="Recipe description missing" Text="*"
                        ValidationGroup="MissingFields"
                    SetFocusOnError ="true" ForeColor="Red"/>
                </td>   
            </tr>

            <%--Lisa Chiang, student number 300925122--%>

            <%--Ingredients new recipe--%>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Ingredients:"></asp:Label>
                </td>
                <td>
                    <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl0" />
                    <asp:Button ID="addIngredientButton" runat="server" Text="Add Ingredient" OnClick="addIngredientButton_Click" />
                </td>
            </tr>

            <tr>
                <td>                   
                </td>
                <td>   
                    <asp:GridView ID="ingredientsGridView" runat="server" AutoGenerateColumns="False" EnableViewState="false" OnRowEditing="ingredientsGridView_RowEditing" OnRowUpdating="ingredientsGridView_RowUpdating" OnRowCancelingEdit="ingredientsGridView_RowCancelingEdit">
                        <Columns>
                            <asp:TemplateField HeaderText="Ingredient Name">
                                <ItemTemplate>
                                    <asp:Label ID="IngredientNameLabel" runat="server" 
                                        Text="<%# ((Ingredient) Container.DataItem).NameIngredient %>">>
                                    </asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:DropDownList ID="editIngredientNameDropDownList" runat="server" DataSourceID="ingredientDataSource" 
                                        DataTextField="IngredientName" DataValueField="idIngredient" SelectedValue="<%# ((Ingredient) Container.DataItem).IndexIngredient %>">
                                    </asp:DropDownList>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Quantity">
                                <ItemTemplate>
                                    <asp:Label ID="IngredientQuantityLabel" runat="server" 
                                        Text="<%# ((Ingredient) Container.DataItem).Quantity %>">>
                                    </asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="editIngredientQuantityTextBox" runat="server" Text="<%# ((Ingredient) Container.DataItem).Quantity %>"></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Unit of Measure">
                                <ItemTemplate>
                                    <asp:Label ID="IngredientUnitOFMeasureLabel" runat="server" 
                                        Text="<%# ((Ingredient) Container.DataItem).NameUnitOfMeasure %>">>
                                    </asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:DropDownList ID="editIngredientUnitOFMeasureDropDownList" runat="server" DataSourceID="unitsOfMeasureDataSource" 
                                        DataTextField="UnitName" DataValueField="idUnit" SelectedValue="<%# ((Ingredient) Container.DataItem).IndexUnitOfMeasure %>">
                                    </asp:DropDownList>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ShowEditButton="True" />
                        </Columns>
                    </asp:GridView>           
                </td>
            </tr>
                
            <tr style="text-align: center">
                <td colspan="3" style="display: flex">
                    <div style="margin-right: 10px">
                        <%--Reset button--%>
                        <asp:Button ID="Reset" runat="server" 
                            Text="Cancel" Height="50" Width="150" 
                            CausesValidation="False" OnClick="Reset_Click" />
                    </div>
                    <div style="margin-left: 10px">
                        <%--Save button--%>
                        <asp:Button ID="NewRecipeButton" runat="server" Text="Save" 
                            Height="50" Width="150" OnClick="NewRecipeButton_Click" 
                            ValidationGroup="MissingFields"/>
                    </div>                      
                </td>
            </tr>
            <tr style="text-align: center">
                <td colspan="3" style="display: flex">
                    <div style="margin-left: 10px">
                        <%--Send email checkbox--%>
                        <asp:CheckBox ID="CheckBoxSendEmail" runat="server" text="Send confirmation email"/>
                    </div>
                </td>
            </tr>
        </table>

        <%--Data source for category drop down list--%>
        <asp:SqlDataSource ID="categoryDataSource" runat="server"
            ConnectionString="<%$ ConnectionStrings:RB_RecipeBook %>"
            SelectCommand="SELECT [idCategory], [CategoryName] FROM [RB_Category]">
        </asp:SqlDataSource>   
            <%--Data source for ingredients drop down list--%>
        <asp:SqlDataSource ID="ingredientDataSource" runat="server"
            ConnectionString="<%$ ConnectionStrings:RB_RecipeBook %>"
            SelectCommand="SELECT [idIngredient], [IngredientName] FROM [RB_Ingredient]">
        </asp:SqlDataSource>   
        <%--Data source for units of measure drop down list--%>
        <asp:SqlDataSource ID="unitsOfMeasureDataSource" runat="server"
            ConnectionString="<%$ ConnectionStrings:RB_RecipeBook %>"
            SelectCommand="SELECT [idUnit], [UnitName] FROM [RB_MeasureUnit]">
        </asp:SqlDataSource>          
    </div>

    <div>
        <asp:Label ID="MessageLabel" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </div>
<%--Lisa Chiang, student number 300925122--%>
</asp:Content>



