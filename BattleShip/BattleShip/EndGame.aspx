<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EndGame.aspx.cs" Inherits="BattleShip.EndGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <asp:Label ID="LabelWinLoose" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="ButtonYes" runat="server" Text="Yes" OnClick="ButtonYes_Click" />
    <asp:Button ID="ButtonNo" runat="server" Text="No" />
</asp:Content>
