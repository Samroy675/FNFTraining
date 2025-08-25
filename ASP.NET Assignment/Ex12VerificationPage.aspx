<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Ex12VerificationPage.aspx.cs" Inherits="SampleWebFormsApp.Ex12VerificationPage" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="verificationBody">
        <div id="form1">
            <h1 style="text-align: center; color: mediumvioletred">Sign In :)</h1>
            <div class="form-container">
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your username "></asp:TextBox>
                <br />
                <br />

                <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter your password" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <div>
                    <asp:Button ID="txtLogin" runat="server" Text="Login" OnClick="txtLogin_Click" />
                    <asp:Button ID="txtSignUp" runat="server" Text="SignUp" OnClick="txtSignUp_Click" />
                </div>
                <br />
                <br />
                <div>
                    <asp:Label ID="txtDisplay" runat="server" ForeColor="IndianRed" Height="100" Width="540"></asp:Label>
                </div>
            </div>
        </div>
    </div>

</asp:Content>




