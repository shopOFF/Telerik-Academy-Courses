<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Escaping.aspx.cs" Inherits="TelerikAcademyHWWebFormsWebHTMLControls.Escaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Escaping</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxInput" class="form-control" runat="server" ValidateRequestMode="Disabled" />
            <asp:Button ID="Button" class="btn btn-info" Text="Display Text" runat="server" OnClick="Button_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Dangerous Escaped Text"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxOutput" class="form-control" runat="server" ValidateRequestMode="Disabled"></asp:TextBox>
        </div>
    </form>
</body>
</html>
