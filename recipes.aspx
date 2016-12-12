<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="recipes.aspx.cs" Inherits="recipes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="container" Runat="Server">
<div class="container">
    <div class="row">
	    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetRecipes" TypeName="RecipeRpository"></asp:ObjectDataSource>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1">
                <AlternatingItemTemplate>
                    <tr style="background-color:#FFF8DC;">
                        <td>
                            <asp:Label ID="RecipeNameLabel" runat="server" Text='<%# Eval("RecipeName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="UsernameLabel" runat="server" Text='<%# Eval("Username") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CookingTimeLabel" runat="server" Text='<%# Eval("CookingTime") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="background-color:#008A8C;color: #FFFFFF;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:TextBox ID="RecipeNameTextBox" runat="server" Text='<%# Bind("RecipeName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="UsernameTextBox" runat="server" Text='<%# Bind("Username") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CookingTimeTextBox" runat="server" Text='<%# Bind("CookingTime") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        </td>
                        <td>
                            <asp:TextBox ID="RecipeNameTextBox" runat="server" Text='<%# Bind("RecipeName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="UsernameTextBox" runat="server" Text='<%# Bind("Username") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CookingTimeTextBox" runat="server" Text='<%# Bind("CookingTime") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="background-color:#DCDCDC;color: #000000;">
                        <td>
                            <asp:Label ID="RecipeNameLabel" runat="server" Text='<%# Eval("RecipeName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="UsernameLabel" runat="server" Text='<%# Eval("Username") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CookingTimeLabel" runat="server" Text='<%# Eval("CookingTime") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                        <th runat="server">Recipe Name</th>
                                        <th runat="server">Submitted by</th>
                                        <th runat="server">Prep Time</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                        </tr>
                    </table>
                    <br />
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                        <td>
                            <asp:Label ID="RecipeNameLabel" runat="server" Text='<%# Eval("RecipeName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="UsernameLabel" runat="server" Text='<%# Eval("Username") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CookingTimeLabel" runat="server" Text='<%# Eval("CookingTime") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
        </div>
    </div>
</div>
</asp:Content>


