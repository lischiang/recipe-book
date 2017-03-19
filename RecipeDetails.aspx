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
        <asp:DetailsView ID="RecipeDetailView" runat="server" Height="50px" Width="700px" AutoGenerateRows="False">
            <Fields>
                <asp:BoundField DataField="PrepareMinutes" HeaderText="Preparation Time" />
                <asp:BoundField DataField="NumberServings" HeaderText="Number of Servings" />
               <%-- <asp:TemplateField HeaderText="Ingredients">
                    <ItemTemplate> --%>
                        <%--<asp:GridView ID="IngredientsGridView" runat="server"></asp:GridView>--%>
                        <%--<asp:Label ID="label" Runat="Server" Text="nulla"/>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:BoundField DataField="RecipeDescription" HeaderText="Directions" />    
            </Fields>
            <HeaderStyle Font-Bold="true" Font-Size="Larger" Height="70px" HorizontalAlign="Center"/>
            <HeaderTemplate>
                <%#Eval("RecipeName")%>
            </HeaderTemplate>
            
        </asp:DetailsView>
        <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
    </form>
</asp:Content>

