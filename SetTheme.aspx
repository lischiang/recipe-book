<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SetTheme.aspx.cs" Inherits="SetTheme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <p>Set the web site theme: 
        <asp:RadioButtonList ID="RadioButtonSetTheme" runat="server" 
            RepeatDirection="Horizontal" RepeatLayout="Table">
            <asp:ListItem Text="Light" Value="Light" Selected="True"></asp:ListItem>
            <asp:ListItem Text="Dark" Value="Dark"></asp:ListItem>
        </asp:RadioButtonList> 
    </p>
         
    <asp:button ID="ButtonConfirmSetTheme" runat="server" text="Confirm" OnClick="ButtonConfirmSetTheme_Click" />
    
</asp:Content>

