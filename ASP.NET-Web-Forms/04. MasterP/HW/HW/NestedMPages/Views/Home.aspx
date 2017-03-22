<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs"
     Inherits="NestedMPages.Views.Home" MasterPageFile="~/Site.Master"%>

<asp:Content ID="ContentPage" runat="server"
             ContentPlaceHolderID="PageContentPlaceHolder">
    <asp:HyperLink runat="server" NavigateUrl="~/Views/Bulgaria/Home.aspx" Text="Bulgaria" CssClass="bg-icon"/>
    <asp:HyperLink runat="server" NavigateUrl="~/Views/England/Home.aspx" Text="England" CssClass="uk-icon"/>
</asp:Content>
