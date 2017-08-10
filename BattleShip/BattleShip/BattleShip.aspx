<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BattleShip.aspx.cs" Inherits="BattleShip.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome to BattelShip</h1>
    <asp:Label ID="LabelPlayerName" runat="server" Text="Player name: "></asp:Label>
    <asp:TextBox ID="TextBoxPlayerName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LabelRows" runat="server" Text="Rows: "></asp:Label>
    <asp:TextBox ID="TextBoxRows" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="LabelColumns" runat="server" Text="Columns: "></asp:Label>
    <asp:TextBox ID="TextBoxColumns" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnPlayGame" runat="server" OnClick="btnPlayGame_Click" Text="Go!" />
</asp:Content>
