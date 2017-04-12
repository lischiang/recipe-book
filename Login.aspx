<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="headercontainerdown">
        <h1 class="whiteshadow" style="font-size: 38pt"><b>Recipe Book</b></h1>
    </div>
    <div class="headercontainerup" style="font-size: 18pt">
        <p class="whiteshadow">Your online cookbook!</p>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:login ID="LoginRecipeBook" runat="server"></asp:login>
</asp:Content>

