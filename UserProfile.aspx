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
    <%--<tr>
      <td>Receive news by email:</td>     
      <td><asp:RadioButtonList ID="RadioButtonReceiveEmail" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table">
            <asp:ListItem Text="Yes" Value="Yes" Selected="True"></asp:ListItem>
            <asp:ListItem Text="No" Value="No"></asp:ListItem>
          </asp:RadioButtonList></td>       
    </tr>--%>
    <tr>
      <td><a href="ChangePassword.aspx">Change Password</a></td>      
    </tr>
  </table>
    <br />
    <%--<asp:Button ID="ConfirmButton" runat="server" Text="Confirm Changes" />--%>
</asp:Content>

