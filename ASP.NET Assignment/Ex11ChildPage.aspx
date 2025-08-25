<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ex11ChildPage.aspx.cs" Inherits="SampleWebFormsApp.Ex11ChildPage" %>
<asp:Content ContentPlaceHolderID="mainContent" runat="server">
     <h1 class="header">Welcome to Child Pages</h1>
    <hr />
    <p class="menu">
        Child Pages cannot have any direct HTML Elements in it. The elements must always be within the Content control. 
    </p>
    <p class="menu">
        Please explore other pages and see how it behaves....
    </p>
</asp:Content>