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
                <tr>
                    <th style="height: 100px; align-content: flex-start; vertical-align: top">
                        <h2 style="text-align: center">Search recipe:</h2>
                    </th>
                </tr>
                <tr>
                    <td style="align-content: flex-start; vertical-align: top">
                        <%--<asp:TextBox ID="SearchText" runat="server" Width="300pt"></asp:TextBox>--%>
                        <asp:Button ID="SearchButton" runat="server" Text="Search" Height="30" Width="120" />
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top">Filter by category:
                        <asp:DropDownList ID="SubmittedByDropDownList" runat="server"></asp:DropDownList>
                        <asp:DropDownList ID="CategoriesDropDownList" runat="server"></asp:DropDownList>
                        <asp:DropDownList ID="IngrediensDropDownList" runat="server"></asp:DropDownList>
                    </td>
                </tr>

            </table>
        </div>
        <div>
            <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</asp:Content>


