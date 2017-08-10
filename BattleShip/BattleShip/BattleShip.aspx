<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BattleShip.aspx.cs" Inherits="BattleShip.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav>
        <h1>Welcome to BattleShip</h1>
    </nav>
    <div class="gameInfo">
        <table>
            <tr>
                <td>
                    <asp:Label ID="LabelPlayerName" runat="server" Text="Player name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxPlayerName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPlayerName" runat="server" ControlToValidate="TextBoxPlayerName" EnableClientScript="False" ErrorMessage="Please enter player's name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelRows" runat="server" Text="Rows: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxRows" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorRows" runat="server" ControlToValidate="TextBoxRows" EnableClientScript="False" ErrorMessage="Please enter number of rows"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorRow" runat="server" ControlToValidate="TextBoxRows" ErrorMessage="Please enter a number between 5 and 100" MinimumValue="5" MaximumValue="100" EnableClientScript="False" Font-Bold="False" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelColumns" runat="server" Text="Columns: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxColumns" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorColumns" runat="server" ControlToValidate="TextBoxColumns" EnableClientScript="False" ErrorMessage="Please enter number of columns"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorColumn" runat="server" ControlToValidate="TextBoxColumns" ErrorMessage="Please enter a number between 5 and 100" MinimumValue="5" MaximumValue="100" EnableClientScript="False" Font-Bold="False" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnPlayGame" runat="server" OnClick="btnPlayGame_Click" Text="Go!" CssClass="btnPlayGame" />
    </div>
</asp:Content>
