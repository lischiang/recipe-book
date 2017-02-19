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
            <asp:TextBox ID="NameIngredientText" runat="server" Width="100px"></asp:TextBox>
            <asp:CustomValidator id="CustomValidatorNameIngredient"
               ControlToValidate="NameIngredientText"
               ClientValidationFunction="ClientValidate"
               ErrorMessage="Missing ingredient name!"
               Text="*" ForeColor="Red"
               runat="server"
               ValidationGroup="MissingFields"/>
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidatorNameIngredient" 
                runat="server" ErrorMessage="Ingredient name missing" 
                Text="*" ForeColor="Red"
                ControlToValidate="NameIngredientText"
                ValidationGroup="MissingFields"
                ></asp:RequiredFieldValidator>--%>
        </td>
        <td>
            <asp:TextBox ID="QuantityText" runat="server" Width="50px"></asp:TextBox>

        </td>
        <td>
            <asp:TextBox ID="UnitOfMeasureText" runat="server" Width="80px"></asp:TextBox>
        </td>
    </tr>
</table>

<script type="text/javascript">
    function ClientValidate(s, args) {
        <%--var nameTxt = document.getElementById("<%= NameIngredientText.ClientID %>").value;--%>
        if (args.Value == "ciao") {
            args.IsValid = true;
        } else {
            args.IsValid = false;
        }
        <%--if (nameTxt != "") {
            if (document.getElementById("<%= QuantityText.ClientID %>").value != "" ||
                document.getElementById("<%= UnitOfMeasureText.ClientID %>").value != "") {

                args.IsValid = false;
            }
            else {
                args.IsValid = true;
            }
        }--%>
    }
</script>

