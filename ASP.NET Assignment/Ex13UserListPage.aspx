<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Ex13UserListPage.aspx.cs" Inherits="SampleWebFormsApp.Ex13UserListPage" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="userlistBody">
        <div id="form1" runat="server">
            <h2>User Profiles :)</h2>
            <hr />
            <div class="card-container" runat="server">
                <asp:Repeater ID="rptUsers" runat="server">
                    <ItemTemplate>
                        <div class="card">
                            <div class="username"><%# Eval("Username") %></div>
                            <div class="dob"><%# Eval("DOB","{0:MM-dd-yyyy}") %></div>
                            <div class="email"><%# Eval("Email") %></div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>

