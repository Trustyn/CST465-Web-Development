<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MasterPage.Master" AutoEventWireup="true" CodeBehind="ValidatedForm.aspx.cs" Inherits="CST465_Project.WebForms.ValidatedForm" %>
<%@ Register TagPrefix="cst" TagName="RequiredTextBox" Src="~/WebForms/RequiredTextBox.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <cst:RequiredTextBox ID="uxName" LabelText="Name: " runat="server" />
    <cst:RequiredTextBox ID="uxFavoriteColor" LabelText="Favorite Color: " runat="server" />
    <cst:RequiredTextBox ID="uxCity" LabelText="City: " runat="server" />
    <%--Submit Button--%>
    <asp:Button ID="uxSubmit" runat="server" OnClick="uxSubmit_Click" Text="SUBMIT"/><br /><br /><br />
</asp:Content>
