<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs" Inherits="HWDataBinding.Task_2.EmpDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label id="OutputLabel" runat="server"></label>
            <br />
            <asp:DetailsView ID="DetailsViewOutput" runat="server" Height="50px" Width="125px" AutoGenerateRows="true" AllowPaging="True" OnPageIndexChanging="DetailsViewOutput_PageIndexChanging">
           
            </asp:DetailsView>
            <asp:Button ID="ButtonBack" runat="server" Text="Go Back" OnClick="ButtonBack_Click" />
        </div>
    </form>
</body>
</html>
