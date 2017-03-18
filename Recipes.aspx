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
        <%--<asp:DataList ID="DataList1" runat="server"></asp:DataList>--%>
        <asp:GridView ID="GridViewRecipes" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridViewRecipes_SelectedIndexChanged">
            <%--onselectedindexchanged="GridViewRecipes_SelectedIndexChanged">--%>
            <Columns>
                <asp:BoundField DataField="RecipeName" HeaderText="Title" />
                <asp:BoundField DataField="UserName" HeaderText="Submitted by" />
                <asp:BoundField DataField="PrepareMinutes" HeaderText="Preparation time" />
                <%--<asp:ButtonField CommandName="ViewDetailPage" Text="View Recipe Details" />--%>
                <asp:ButtonField CommandName="Select" Text="View Recipe Details" />
                </Columns>
        </asp:GridView>
    </form>
</asp:Content>


