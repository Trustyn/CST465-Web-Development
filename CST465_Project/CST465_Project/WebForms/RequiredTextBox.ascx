<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RequiredTextBox.ascx.cs" Inherits="CST465_Project.WebForms.RequiredTextBox" %>

<%--Required Text Field--%>
<asp:label ID="lblRequiredTextBox" AssociatedControlID="uxRequiredTextBox" runat="server" Text="Required Text Box"></asp:label><br />
<asp:TextBox ID="uxRequiredTextBox" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="valRequiredTextBox" ControlToValidate="uxRequiredTextBox" ErrorMessage="Field Required" Text="*" runat="server"></asp:RequiredFieldValidator>