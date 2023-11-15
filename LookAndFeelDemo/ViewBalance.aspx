<%@ Page Title="" Language="C#" MasterPageFile="~/MyOwnSite.Master" AutoEventWireup="true" CodeBehind="ViewBalance.aspx.cs" Inherits="LookAndFeelDemo.ViewBalance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pageContent" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    Balance : Rs: <asp:Label ID="lblAvailableBalance" runat="server" Text="Label"></asp:Label>
</asp:Content>
