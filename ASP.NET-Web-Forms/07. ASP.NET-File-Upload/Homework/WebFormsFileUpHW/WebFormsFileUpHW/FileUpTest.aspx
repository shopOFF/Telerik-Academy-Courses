<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpTest.aspx.cs" Inherits="WebFormsFileUpHW.FileUpTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUploadTest" runat="server" />
        <br />
        <asp:Button Text="Upload" runat="server" OnClick="UploadBtn_Click" />
        <br />
        <asp:Label ID="Label_Result" runat="server" />
    </div>
    </form>
</body>
</html>
