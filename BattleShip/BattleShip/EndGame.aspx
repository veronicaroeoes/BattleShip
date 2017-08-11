<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EndGame.aspx.cs" Inherits="BattleShip.EndGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="EndGamePage">
<h2><asp:Label ID="LabelWinLoose" runat="server" Text="" CssClass="WinLoose"></asp:Label></h2>
    <br />
    <asp:Label ID="LabelPlayAgain" runat="server" Text="Do you want to play again?"></asp:Label>
    <br />
    <asp:Button ID="ButtonYes" runat="server" Text="Yes" OnClick="ButtonYes_Click" />
    <asp:Button ID="ButtonNo" runat="server" Text="No" />
        </div>
</asp:Content>
