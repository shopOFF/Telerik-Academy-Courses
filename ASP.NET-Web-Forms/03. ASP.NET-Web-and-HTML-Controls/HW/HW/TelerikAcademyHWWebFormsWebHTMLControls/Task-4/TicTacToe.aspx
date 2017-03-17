<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="TelerikAcademyHWWebFormsWebHTMLControls.Task_4.TicТacТoe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tic Tac Toe</title>
    <link href="StylesTicTacToe.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="main-container">
            <asp:Button ID="ButtonFirstRowLeft" runat="server" Text=" " OnClick="ButtonFirstRowLeft_Click" />
            <asp:Button ID="ButtonFirstRowMiddle" runat="server" Text=" " OnClick="ButtonFirstRowMiddle_Click" />
            <asp:Button ID="ButtonFirstRowRight" runat="server" Text=" " OnClick="ButtonFirstRowRight_Click" />
            <br />
            <asp:Button ID="ButtonSecondRowLeft" runat="server" Text=" " OnClick="ButtonSecondRowLeft_Click" />
            <asp:Button ID="ButtonSecondRowMiddle" runat="server" Text=" " OnClick="ButtonSecondRowMiddle_Click" />
            <asp:Button ID="ButtonSecondRowRight" runat="server" Text=" " OnClick="ButtonSecondRowRight_Click" />
            <asp:Label ID="LabelResult" Visible="False" runat="server"></asp:Label>
            <br />
            <asp:Button ID="ButtonThirdRowLeft" runat="server" Text=" " OnClick="ButtonThirdRowLeft_Click" />
            <asp:Button ID="ButtonThirdRowMiddle" runat="server" Text=" " OnClick="ButtonThirdRowMiddle_Click" />
            <asp:Button ID="ButtonThirdRowRight" runat="server" Text=" " OnClick="ButtonThirdRowRight_Click" />
            <div id="restart-container" >
                <asp:Button ID="ButtonRestart" runat="server" Text="Restart" OnClick="ButtonRestart_Click" Height="50px" />
            </div>
        </div>

    </form>
</body>
</html>
