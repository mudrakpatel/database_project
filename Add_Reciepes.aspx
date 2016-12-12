<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add_Reciepes.aspx.cs" Inherits="addRecipes" %>

<%@ Register src="Ingredients.ascx" tagname="Ingredients" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container" Runat="Server">
    <div class="container">
    <div class="row">
	    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
	        <h1 class="text-center"><strong>Add a Recipe</strong></h1>
            <div class="well well-lg">
			    <ul class="list-group">
				    <li class="list-group-item">
                        <h2>Recipe Information</h2>
                        <asp:Label ID="lblRecipeName" runat="server" Text="Recipe name:"></asp:Label>
                        &nbsp;<asp:TextBox ID="txtBxRecipeName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtBxRecipeName" ID="RFVRecipeName" runat="server" ErrorMessage="Recipe name is a required field."></asp:RequiredFieldValidator>
				    </li>
				    <li class="list-group-item">
                        <asp:Label ID="lblUsername" runat="server" Text="Submitted by:"></asp:Label>
                        &nbsp;<asp:TextBox ID="txtBxUsername" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtBxUsername" ID="RFVUsername" runat="server" ErrorMessage="Submitted by is a required field."></asp:RequiredFieldValidator>
				    </li>
				    <li class="list-group-item">
                        <asp:Label ID="lblCategory" runat="server" Text="Category:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBxCategory" runat="server"></asp:TextBox>
				    </li>
                    <li class="list-group-item">
                        <asp:Label ID="lblCookingTime" runat="server" Text="Cooking time:"></asp:Label>
                        &nbsp;<asp:TextBox ID="txtBxCookingTime" runat="server"></asp:TextBox>
				    </li>
                    <li class="list-group-item">
                        <asp:Label ID="lblServings" runat="server" Text="Number of servings:"></asp:Label>
                        <asp:TextBox ID="txtBxServings" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtBxServings" ID="RFVServings" runat="server" ErrorMessage="Servings is a required field."></asp:RequiredFieldValidator>
				    </li>
                    <li class="list-group-item">
                        <asp:Label ID="lblDescription" runat="server" Text="Recipe description:"></asp:Label>
                        <asp:TextBox ID="txtBxDescription" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="txtBxDescription" ID="RFVDescription" runat="server" ErrorMessage="Recipe description is a required field."></asp:RequiredFieldValidator>
				    </li>
                    <li class="list-group-item">
                        <h2>Ingredients</h2>
				        <uc1:Ingredients ID="Ingredients1" runat="server" />
                        <uc1:Ingredients ID="Ingredients2" runat="server" />
                        <uc1:Ingredients ID="Ingredients3" runat="server" />
                        <uc1:Ingredients ID="Ingredients4" runat="server" />
                        <uc1:Ingredients ID="Ingredients5" runat="server" />
				    </li>
			    </ul>
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
	            <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
	        </div>
        </div>
    </div>
</div>
</asp:Content>

