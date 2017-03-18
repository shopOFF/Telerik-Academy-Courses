<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCalculator.aspx.cs" Inherits="TelerikAcademyHWWebFormsWebHTMLControls.Task_5.WebCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Calculator</title>
    <link href="Styles/CalculatorStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="calculator-container">
                <asp:TextBox ID="TextBoxOutput" runat="server"></asp:TextBox>
                <br />
                <div id="buttons-container">
                    <asp:Button ID="Button1" runat="server" Text="1" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="2" OnClick="Button2_Click" />
                    <asp:Button ID="Button3" runat="server" Text="3" OnClick="Button3_Click" />
                    <asp:Button ID="ButtonPlus" runat="server" Text="+" OnClick="ButtonPlus_Click" />
                    <br />
                    <asp:Button ID="Button4" runat="server" Text="4" OnClick="Button4_Click" />
                    <asp:Button ID="Button5" runat="server" Text="5" OnClick="Button5_Click" />
                    <asp:Button ID="Button6" runat="server" Text="6" OnClick="Button6_Click" />
                    <asp:Button ID="ButtonMinus" runat="server" Text="-" OnClick="ButtonMinus_Click" />
                    <br />
                    <asp:Button ID="Button7" runat="server" Text="7" OnClick="Button7_Click" />
                    <asp:Button ID="Button8" runat="server" Text="8" OnClick="Button8_Click" />
                    <asp:Button ID="Button9" runat="server" Text="9" OnClick="Button9_Click" />
                    <asp:Button ID="ButtonMultiply" runat="server" Text="x" OnClick="ButtonMultiply_Click" />
                    <br />
                    <asp:Button ID="ButtonClear" runat="server" Text="Clear" OnClick="ButtonClear_Click" />
                    <asp:Button ID="Button0" runat="server" Text="0" OnClick="Button0_Click" />
                    <asp:Button ID="ButtonDivis" runat="server" Text="/" OnClick="ButtonDivis_Click" />
                    <asp:Button ID="ButtonSquareRoot" runat="server" Text="√" OnClick="ButtonSquareRoot_Click" />
                    <br />
                    <asp:Button ID="ButtonEquals" runat="server" Text="=" OnClick="ButtonEquals_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
