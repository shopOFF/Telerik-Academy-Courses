<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MobileBg.aspx.cs" Inherits="HWDataBinding.Task_1.MobileBg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownListBrand"
                OnSelectedIndexChanged="DropDownListBrand_SelectedIndexChanged"
                AutoPostBack="true"
                runat="server">
            </asp:DropDownList>

            <asp:DropDownList ID="DropDownListModel"
                runat="server"> 
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
