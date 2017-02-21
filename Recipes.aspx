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
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSourceRecipeRepository" GroupItemCount="3">
            <AlternatingItemTemplate>
                <td runat="server" style="background-color:#FFF8DC;">Name Recipe:
                    <asp:Label ID="NameRecipeLabel" runat="server" Text='<%# Eval("NameRecipe") %>' />
                    <br />Submitted By:
                    <asp:Label ID="SubmittedByLabel" runat="server" Text='<%# Eval("SubmittedBy") %>' />
                    <br />Prepare Time:
                    <asp:Label ID="PrepareTimeLabel" runat="server" Text='<%# Eval("PrepareTime") %>' />
                    <br /></td>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <td runat="server" style="background-color:#008A8C;color: #FFFFFF;">Name Recipe:
                    <asp:TextBox ID="NameRecipeTextBox" runat="server" Text='<%# Bind("NameRecipe") %>' />
                    <br />Submitted By:
                    <asp:TextBox ID="SubmittedByTextBox" runat="server" Text='<%# Bind("SubmittedBy") %>' />
                    <br />Prepare Time:
                    <asp:TextBox ID="PrepareTimeTextBox" runat="server" Text='<%# Bind("PrepareTime") %>' />
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    <br /></td>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>The list of the recipes is still empty.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
<td runat="server" />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>
            <InsertItemTemplate>
                <td runat="server" style="">Name Recipe:
                    <asp:TextBox ID="NameRecipeTextBox" runat="server" Text='<%# Bind("NameRecipe") %>' />
                    <br />Submitted By:
                    <asp:TextBox ID="SubmittedByTextBox" runat="server" Text='<%# Bind("SubmittedBy") %>' />
                    <br />Prepare Time:
                    <asp:TextBox ID="PrepareTimeTextBox" runat="server" Text='<%# Bind("PrepareTime") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    <br /></td>
            </InsertItemTemplate>
            <ItemTemplate>
                <td runat="server" style="background-color:#DCDCDC;color: #000000;">Name Recipe:
                    <asp:Label ID="NameRecipeLabel" runat="server" Text='<%# Eval("NameRecipe") %>' />
                    <br />Submitted By:
                    <asp:Label ID="SubmittedByLabel" runat="server" Text='<%# Eval("SubmittedBy") %>' />
                    <br />Prepare Time:
                    <asp:Label ID="PrepareTimeLabel" runat="server" Text='<%# Eval("PrepareTime") %>' />
                    <br /></td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr id="groupPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                            <asp:DataPager ID="DataPager1" runat="server" PageSize="12">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <td runat="server" style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">Name Recipe:
                    <asp:Label ID="NameRecipeLabel" runat="server" Text='<%# Eval("NameRecipe") %>' />
                    <br />Submitted By:
                    <asp:Label ID="SubmittedByLabel" runat="server" Text='<%# Eval("SubmittedBy") %>' />
                    <br />Prepare Time:
                    <asp:Label ID="PrepareTimeLabel" runat="server" Text='<%# Eval("PrepareTime") %>' />
                    <br /></td>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:ObjectDataSource ID="ObjectDataSourceRecipeRepository" runat="server" SelectMethod="GetRecipePreviews" TypeName="RecipeRepository"></asp:ObjectDataSource>
    </form>
</asp:Content>


