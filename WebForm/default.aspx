<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebForm._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MonBody" runat="server">
    <asp:TextBox runat="server" ID="MaZoneDeTexte" />&nbsp;
    <asp:Button runat="server" ID="MonBouton" Text="GO !" OnClick="MonBouton_OnClick"/>
    <asp:DataGrid runat="server" ID="MaDataGrid"/>
</asp:Content>
