﻿<%--Lisa Chiang, student number 300925122--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UserProfile.aspx.cs" Inherits="UserProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="headercontainermiddle">
        <h1 class="whiteshadow headertitlesecondary">Recipe Book</h1>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label id="Msg" ForeColor="maroon" runat="server" /><br />

  <table cellpadding="3" border="0">
    <tr>
      <td>E-mail Address:</td>
      <td><asp:Label ID="LabelEmail" runat="server" Text=""></asp:Label></td>        
    </tr>
    <tr>
      <td><a href="ChangePassword.aspx">Change Password</a></td>      
    </tr>
  </table>
    <br />
</asp:Content>
<%--Lisa Chiang, student number 300925122--%>
