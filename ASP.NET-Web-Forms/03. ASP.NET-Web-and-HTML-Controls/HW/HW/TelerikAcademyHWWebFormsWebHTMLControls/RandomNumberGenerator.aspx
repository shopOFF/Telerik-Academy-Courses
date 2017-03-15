<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumberGenerator.aspx.cs" Inherits="TelerikAcademyHWWebFormsWebHTMLControls.RandomNumberGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="Text1" type="text" runat="server" />
            <asp:Literal Text=" - Enter Range From" runat="server" ID="FromLiteral" />
            <br />
            <input id="Text2" type="text" runat="server" />
            <asp:Literal Text=" - Enter Range To" runat="server" ID="ToLiteral" />
            <br />
            <br />
            <input id="Button1" type="button" value="Generate Random Number" onserverclick="Button1_Click" runat="server" />
            <br />
            <br />
            <asp:Literal Text="Generated Number Is: " runat="server" />
            <asp:Literal ID="GeneratedNumberLiteral" runat="server" />
        </div>
    </form>
</body>
</html>
