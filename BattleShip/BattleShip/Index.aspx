<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BattleShip.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav>
        <h1>Welcome to Battleship</h1>

    </nav>
    <div class="gameInfo">
        <table>
            <tr>
                <td>
                    <asp:Label ID="LabelPlayerName" runat="server" Text="Player name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxPlayerName" runat="server" CssClass="TextBoxes"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPlayerName" runat="server" ControlToValidate="TextBoxPlayerName" EnableClientScript="False" ErrorMessage="Please enter player's name" CssClass="Validators"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelRows" runat="server" Text="Rows: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxRows" runat="server" CssClass="TextBoxes"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorRows" runat="server" ControlToValidate="TextBoxRows" EnableClientScript="False" ErrorMessage="Please enter number of rows" CssClass="Validators"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorRow" runat="server" ControlToValidate="TextBoxRows" ErrorMessage="Please enter a number between 5 and 100" MinimumValue="5" MaximumValue="100" EnableClientScript="False" Font-Bold="False" Type="Integer" CssClass="Validators"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelColumns" runat="server" Text="Columns: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxColumns" runat="server" CssClass="TextBoxes"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                <td></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorColumns" runat="server" ControlToValidate="TextBoxColumns" EnableClientScript="False" ErrorMessage="Please enter number of columns" CssClass="Validators"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorColumn" runat="server" ControlToValidate="TextBoxColumns" ErrorMessage="Please enter a number between 5 and 100" MinimumValue="5" MaximumValue="100" EnableClientScript="False" Font-Bold="False" Type="Integer" CssClass="Validators"></asp:RangeValidator>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnPlayGame" runat="server" OnClick="btnPlayGame_Click" Text="Ready to battle?" CssClass="btnPlayGame" />
    </div>
</asp:Content>
