<%@ Control Language="C#" AutoEventWireup="true" CodeFile="IngredientWebUserControl.ascx.cs" Inherits="WebUserControl" %>

<table style="margin-left: auto; margin-right: auto; max-width: 200px">
    <tr style="vertical-align: bottom">
        <td>
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
        <td style="width:300px">
            <asp:CustomValidator id="CustomValidatorNameIngredient"
               ControlToValidate="DropDownListNameIngredient"
               onservervalidate="IngredientValidity"
               ErrorMessage="Missing ingredient name!"
                InitialValue="--Select ingredient--"
               Text="*" ForeColor="Red"
               runat="server" ValidateEmptyText="True"
               ValidationGroup="MissingFields"/>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidatorIngredientName" runat="server" 
                ControlToValidate="DropDownListNameIngredient"
                onservervalidate="IngredientValidity"
                ErrorMessage="Select the name of the Ingredient." 
                InitialValue="--Select ingredient--"
                Text="*" ForeColor="Red"
                ValidationGroup="MissingFields"/>--%>
            <%--InitialValue="--Select ingredient--"--%>

            <asp:RegularExpressionValidator id="RegularExpressionValidatorQuantityIsNumber" 
                runat="server" controltovalidate="QuantityText" 
                validationexpression="^\d*\.{0,1}\d+$" 
                ErrorMessage="Quantity of ingredient must be a numeric value!"
                Text="*" ForeColor="Red"
                ValidationGroup="MissingFields"/>
            <%--<asp:TextBox ID="NameIngredientText" runat="server" Width="100px"></asp:TextBox>--%>
            <asp:DropDownList ID="DropDownListNameIngredient" runat="server"></asp:DropDownList>
        </td>
        <td>
            <asp:TextBox ID="QuantityText" runat="server" Width="50px"></asp:TextBox>

        </td>
        <td>
            <%--<asp:TextBox ID="UnitOfMeasureText" runat="server" Width="80px"></asp:TextBox>--%>
            <asp:DropDownList ID="DropDownListUnitOfMeasure" runat="server"></asp:DropDownList>
        </td>
    </tr>
</table>
<asp:Label ID="MessageLabel" runat="server" Text="" Visible="false"></asp:Label>
