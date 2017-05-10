<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Continents.aspx.cs" Inherits="DSourceControlsHW.Continents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="ListBoxContinets"
             runat="server"
             DataSourceID="EntityDataSourceContinents"
             DataTextField="Name" 
             DataValueField="Name"
            ></asp:ListBox>
        <asp:EntityDataSource ID="EntityDataSourceContinents" runat="server" ConnectionString="name=EarthEntities" DefaultContainerName="EarthEntities" EnableFlattening="False" EntitySetName="Continents">
        </asp:EntityDataSource>
    </form>
</body>
</html>
