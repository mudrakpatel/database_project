<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container" Runat="Server">
    <div class="container">
	<div class="row">
	<div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
	<h1 class="text-center">Welcome to Food World!!</h1>
	<div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
		<h3><strong>About</strong></h3>
          
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
         <div id="link" runat="server">
            
         </div>
            <br/>
            &nbsp;
	    </div>
   
    
    </div>
    
   </div>
	</div>
</asp:Content>

