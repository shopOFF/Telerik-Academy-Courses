<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentsAndCourses.aspx.cs" Inherits="TelerikAcademyHWWebFormsWebHTMLControls.Task_3.StudentsAndCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Students and Courses</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-md-7">
            <div id="container">
                <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
                First Name
        <br />
                <br />
                <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
                Last Name
        <br />
                <br />
                <asp:TextBox ID="TextBoxFacultyNumber" runat="server"></asp:TextBox>
                Faculty Number
        <br />
                <br />
                <asp:DropDownList ID="DropDownListUniversities" runat="server">
                    <asp:ListItem>Sofia University</asp:ListItem>
                    <asp:ListItem>UniBit University</asp:ListItem>
                    <asp:ListItem>NBU</asp:ListItem>
                </asp:DropDownList>
                University
        <br />
                <br />
                <asp:DropDownList ID="DropDownListSpecialties" runat="server">
                    <asp:ListItem>IT</asp:ListItem>
                    <asp:ListItem>Biology</asp:ListItem>
                    <asp:ListItem>Mathematics</asp:ListItem>
                </asp:DropDownList>
                Specialty
         <br />
                <br />
                <asp:Literal ID="LiteralCourses" Text="List of Courses:" runat="server"></asp:Literal>
                <div id="ListContainer">
                    <asp:CheckBoxList ID="CheckBoxListCourses" runat="server">
                        <asp:ListItem>C#</asp:ListItem>
                        <asp:ListItem>JS</asp:ListItem>
                        <asp:ListItem>Fishing</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
            <asp:Button ID="ButtonSubmit" class="btn btn-info" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />

            <br />
            <div id="ResultInfo" runat="server" visible="false">
            </div>
        </div>
    </form>
</body>
</html>
