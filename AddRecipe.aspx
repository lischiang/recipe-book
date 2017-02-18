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
    <form runat="server" style="align-content: center">
        <div class="recipecontainer">
            <table style="margin-left: auto; margin-right: auto; max-width: 600px; max-height: none">
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
                        SetFocusOnError ="true" ForeColor="Red"/>
                    </td>
                    
                </tr>

                <%--"Submitted by" new recipe--%>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Submitted by:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="SubmittedByText" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSubmittedBy" 
                        runat="server" ControlToValidate = "SubmittedByText" 
                        ErrorMessage="Name of the recipe author missing" Text="*"
                        SetFocusOnError ="true" ForeColor="Red"/>
                    </td>
                </tr>

                <%--Category new recipe--%>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Category:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="CategoryText" runat="server"></asp:TextBox>
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
                        &nbsp;
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
                        SetFocusOnError ="true" ForeColor="Red"/>
                    </td>
                </tr>

                <%--Recipe description new recipe--%>
                <tr>
                    <td style="vertical-align: top">
                        <asp:Label runat="server" Text="Recipe description:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="RecipeDescriptionText" runat="server" Height="150px" Width="167.5px" TextMode ="MultiLine" style="margin-left: 0px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorRecipeDescription" 
                        runat="server" ControlToValidate = "RecipeDescriptionText" 
                        ErrorMessage="Recipe description missing" Text="*"
                        SetFocusOnError ="true" ForeColor="Red"/>
                    </td>   
                </tr>

                <%--Ingredients new recipe--%>
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Ingredients:"></asp:Label>
                        <%--REMOVE--%>
                        <asp:TextBox ID="test" runat="server"></asp:TextBox>
                        <%-- --%>

                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl0" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl1" />
                    </td>  
                </tr>
                <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl2" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl3" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl4" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl5" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl6" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl7" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl8" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl9" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl10" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl11" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl12" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl13" />
                    </td>  
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td  style="height: 60px">
                        <uc1:IngredientWebUserControl runat="server" ID="IngredientWebUserControl14" />
                    </td>  
                </tr>

                

                <tr style="text-align: center">
                    <td colspan="3" style="display: flex">
                        <div style="margin-right: 10px">
                            <asp:Button ID="Reset" runat="server" Text="Reset" Height="50" Width="150" />
                        </div>
                        <div style="margin-left: 10px">
                            <asp:Button ID="NewRecipeButton" runat="server" Text="Finished!" Height="50" Width="150" OnClick="NewRecipeButton_Click" />
                        </div>
                    </td>
                </tr>

            </table>

            <%--<div style="border: 3px solid #808080; max-width: 500px; margin-left:50px">
                ...Sketch of the recipe under construction, updated every time an ingredient or a step is added...
            </div>--%>
        </div>
    </form>

</asp:Content>

