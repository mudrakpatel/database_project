<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container" Runat="Server">
<div class="container">
    <div class="row">
	    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
           Submitted By: <asp:DropDownList ID="ddlName" runat="server"></asp:DropDownList>
            Category: <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
            Name Of Ingrident:<asp:DropDownList ID="ddlIngrident" runat="server"></asp:DropDownList>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        </div>
        <div id="link" runat="server"></div>
    </div>
</div>
</asp:Content>

