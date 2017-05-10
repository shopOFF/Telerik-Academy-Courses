<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesFormView.aspx.cs" Inherits="HWDataBinding.Task_2.EmployeesFormView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FormView ID="FormViewEmployees" runat="server" DataSourceID="SqlDataSourceFormView"></asp:FormView>
        <asp:SqlDataSource ID="SqlDataSourceFormView" runat="server"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
