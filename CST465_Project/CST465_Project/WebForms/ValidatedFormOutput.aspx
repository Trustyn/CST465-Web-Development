<%@ Page Title="" Language="C#" MasterPageFile="~/WebForms/MasterPage.Master" AutoEventWireup="true" CodeBehind="ValidatedFormOutput.aspx.cs" Inherits="CST465_Project.WebForms.ValidatedFormOutput" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderNav" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:PlaceHolder ID="uxInvalidDataArea" Visible="false" runat="server">
        <p>This form did not receive the parameters expected.</p>
    </asp:PlaceHolder>
    <asp:PlaceHolder ID="uxValidDataArea" Visible="false" runat="server">
        <div>
            Name:
            <asp:Literal ID="uxName" runat="server"></asp:Literal>
        </div>
        <div>
            Favorite Color:
            <asp:Literal ID="uxFavoriteColor" runat="server"></asp:Literal>
        </div>
        <div>
            City:
            <asp:Literal ID="uxCity" runat="server"></asp:Literal>
        </div>
    </asp:PlaceHolder>
</asp:Content>
