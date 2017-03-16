<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Escaping.aspx.cs" Inherits="TelerikAcademyHWWebFormsWebHTMLControls.Escaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBoxInput" runat="server"/>  
        <asp:Button ID ="Button" Text="Submit Text" runat="server" OnClick="Button_Click"  />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Output Text"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxOutput" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
