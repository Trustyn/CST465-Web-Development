<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="CST465_Project.WebForms.Contact" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title>Lab 3: ASP.NET Controls</title>
</head>
<body>
    <h1>LAB 3: Working with ASP.NET Controls</h1>
    <form method="post" runat="server">
        <%--Name Text Field--%>
        <asp:label AssociatedControlID="uxName" runat="server" Text="Name:"></asp:label><br />
        <asp:TextBox ID="uxName" runat="server"></asp:TextBox><br /><br />
        <%--Priority Dropdown List--%>
        <asp:label AssociatedControlID="uxPriority" runat="server" Text="Priority:"></asp:label><br />
        <asp:DropDownList ID="uxPriority" runat="server">
            <asp:ListItem Text="High" Value="High"></asp:ListItem>
            <asp:ListItem Text="Medium" Value="medium"></asp:ListItem>
            <asp:ListItem Text="Low" Value="low"></asp:ListItem>
        </asp:DropDownList><br /><br />
        <%--Subject Text Field--%>
        <asp:label AssociatedControlID="uxSubject" runat="server" Text="Subject:"></asp:label><br />
        <asp:TextBox ID="uxSubject" runat="server"></asp:TextBox><br /><br />
        <%--Description Text Area--%>
        <asp:label AssociatedControlID="uxDescription" runat="server" Text="Description:"></asp:label><br />
        <asp:textbox TextMode="MultiLine" ID="uxDescription" runat="server"></asp:textbox><br /><br />
        <%--Submit Button--%>
        <asp:Button ID="uxSubmit" runat="server" OnClick="uxSubmit_Click" Text="SUBMIT"/><br /><br /><br />
        <%--Literal FormOutput--%>
        <asp:Literal ID="uxFormOutput" runat="server" Text="<b>Form Output</b>"></asp:Literal><br /><br /><br />
        <%--Literal EventOutput--%>
        <asp:Literal ID="uxEventOutput" runat="server" Text="<b>Event Output</b>"></asp:Literal><br /><br /><br />
    </form>
</body>
</html>
