<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Ingredients.ascx.cs" Inherits="Ingredients" %>
<asp:Label ID="lblName" runat="server" Text="Ingredient Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
<br />
<asp:Label ID="lblQunatity" runat="server" Text="Quantity:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtQuantity" runat="server" ></asp:TextBox>
<asp:RegularExpressionValidator ID="REVQuantity" runat="server" ControlToValidate="txtQuantity" ErrorMessage="Quantity must be a number." ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>
<br />
<asp:Label ID="lblUnitOfMeasure" runat="server" Text="Unit of Measure:"></asp:Label>
&nbsp;
<asp:TextBox ID="txtUnitOfMeasure" runat="server"></asp:TextBox>
<br />
<br />