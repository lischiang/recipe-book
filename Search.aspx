<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div class="recipecontainer">
            <table style="margin-left: auto; margin-right: auto; max-width: 600px">
                <tr style="text-align: center">
                    <th colspan="3" style="height: 100px; align-content: flex-start; vertical-align: top">
                        <h2 style="text-align: center">Search recipes:</h2>
                    </th>
                </tr>
                <tr>
                    <td style="vertical-align: top">
                        Choose Username of the Author:
                    </td>
                    <td>
                        Choose Category of the Recipe:
                    </td>
                    <td>
                        Choose Ingredient contained in the Recipe:
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top">
                        <asp:DropDownList ID="SubmittedByDropDownList" runat="server"></asp:DropDownList>   
                    </td>
                    <td>
                        <asp:DropDownList ID="CategoriesDropDownList" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="IngredientsDropDownList" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="align-content: flex-start; vertical-align: top">
                        &nbsp;
                    </td>
                </tr>
                <tr style="text-align: center">
                    <td colspan="3">
                        <asp:Button ID="SearchButton" runat="server" Text="Search" Height="30" Width="120" OnClick="SearchButton_Click" />
                    </td>
                </tr>

            </table>
        </div>
        &nbsp;
        &nbsp;
        <div>
            <asp:Label ID="MessageLabel" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:GridView ID="GridViewSearchResult" runat="server" AutoGenerateColumns="False" Visible="False">
                <Columns>
                <asp:BoundField DataField="RecipeName" HeaderText="Title" />
                <asp:BoundField DataField="UserName" HeaderText="Submitted by" />
                <asp:BoundField DataField="PrepareMinutes" HeaderText="Preparation time" />
                <asp:ButtonField CommandName="Select" Text="View Recipe Details" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</asp:Content>


