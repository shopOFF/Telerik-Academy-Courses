<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="HWDataBinding.Task_2.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewEmployees" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeID" DataSourceID="SqlDataSourceEmployees">
                <Columns>
                    <asp:HyperLinkField DataTextField="FirstName" DataNavigateUrlFields="EmployeeID" DataNavigateUrlFormatString="EmpDetails.aspx"
                        HeaderText="First Name" />
                    <asp:HyperLinkField DataTextField="LastName" DataNavigateUrlFields="EmployeeID" DataNavigateUrlFormatString="EmpDetails.aspx"
                        HeaderText="Last Name" />
                    <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSourceEmployees" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT [FirstName], [LastName], [EmployeeID] FROM [Employees]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
