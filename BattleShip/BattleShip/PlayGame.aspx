<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PlayGame.aspx.cs" Inherits="BattleShip.PlayGame" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="GameBoardDiv">
        <table id="tableId">
            <tr>
                <td>
                    <button>1,1</button></td>
                <td>
                    <button>1,2</button></td>
                <td>
                    <button>1,3</button></td>
                <td>
                    <button>1,4</button></td>
                <td>
                    <button>1,5</button></td>
            </tr>
            <tr>
                <td>
                    <button>2,1</button></td>
                <td>
                    <button>2,2</button></td>
                <td>
                    <button>2,3</button></td>
                <td>
                    <button>2,4</button></td>
                <td>
                    <button>2,5</button></td>
            </tr>
            <tr>
                <td>
                    <button>3,1</button></td>
                <td>
                    <button>3,2</button></td>
                <td>
                    <button>3,3</button></td>
                <td>
                    <button>3,4</button></td>
                <td>
                    <button>3,5</button></td>
            </tr>
            <tr>
                <td>
                    <button>4,1</button></td>
                <td>
                    <button>4,2</button></td>
                <td>
                    <button>4.3</button></td>
                <td>
                    <button>4,4</button></td>
                <td>
                    <button>4,5</button></td>
            </tr>
        </table>
    </div>
</asp:Content>
