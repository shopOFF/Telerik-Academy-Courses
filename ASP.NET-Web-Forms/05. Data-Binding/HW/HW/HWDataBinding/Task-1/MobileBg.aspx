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
            <br />
            <br />
            <p>Extras</p>
            <asp:CheckBoxList ID="CheckBoxListExtras" runat="server">
            </asp:CheckBoxList>
            <br />
            <p>Engine Type</p>
            <asp:RadioButtonList ID="RadioButtonListEngines" runat="server" RepeatDirection="Horizontal">
            </asp:RadioButtonList>

            <asp:Button ID="ButtonSubmit" runat="server" Text="Search" OnClick="ButtonSubmit_Click" />
        </div>
    </form>
</body>
</html>
