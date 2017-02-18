<%@ Control Language="C#" AutoEventWireup="true" CodeFile="IngredientWebUserControl.ascx.cs" Inherits="WebUserControl" %>

<table style="margin-left: auto; margin-right: auto; max-width: 200px">
    <tr style="vertical-align: bottom">
        <td style="width: 40px; height: 20px">
            <asp:Label ID="LabelNameIngredient" runat="server" Text="Ingredient Name" Font-Size="X-Small"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LabelQuantity" runat="server" Text="Quantity" Font-Size="X-Small"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LabelUnitOfMeasure" runat="server" Text="Unit of measure" Font-Size="X-Small"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 400px">
            <asp:TextBox ID="NameIngredient" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="Quantity" runat="server" Width="50px"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="UnitOfMeasure" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
