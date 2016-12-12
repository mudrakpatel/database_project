<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowRecipe.aspx.cs" Inherits="ShowRecipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1" runat="server">
        </div>
        <div>
    <img id="img"  src="a" runat="server" style="height:100px; width:100px;"/>
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblSubmittedby" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblCategory" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblCookingTime" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblNoOfServing" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblDiscription" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName1" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity1" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure1" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName2" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity2" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure2" runat="server" Text=""></asp:Label>
         <asp:Label ID="lblIngName3" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity3" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure3" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName4" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity4" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure4" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName5" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity5" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure5" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName6" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity6" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure6" runat="server" Text=""></asp:Label>
         <asp:Label ID="lblIngName7" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity7" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure7" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName8" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity8" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure8" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName9" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity9" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure9" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName10" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity10" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure10" runat="server" Text=""></asp:Label>
         <asp:Label ID="lblIngName11" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity11" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure11" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName12" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity12" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure12" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName13" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity13" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure13" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName14" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity14" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure14" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblIngName15" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblQuantity15" runat="server" Text=""></asp:Label>
        <asp:Label ID="lblUnitOfMeasure15" runat="server" Text=""></asp:Label>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
    </div>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="FeedBack"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Comment:"></asp:Label>
        <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" />
    </form>
</body>
</html>
