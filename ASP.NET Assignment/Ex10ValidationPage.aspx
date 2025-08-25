<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Ex10ValidationPage.aspx.cs" Inherits="SampleWebFormsApp.Ex10ValidationPage" %>

<asp:Content runat="server" ContentPlaceHolderID="mainContent">
    <div class="validationBody">
        <div id="form1">
            <h1 style="text-align: center; color: mediumvioletred">Sign Up :)</h1>
            <hr />
            <br />
            <br />
            <div class="form-container">
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your username "></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername"
                    ErrorMessage="Username is required and can't be empty" ValidationGroup="SignUp" ForeColor="IndianRed" Display="Dynamic" />
                <br />
                <br />

                <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter your password" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                    ErrorMessage="Password is mandatory and can't be skipped" ValidationGroup="SignUp" ForeColor="IndianRed" Display="Dynamic" />
                <br />
                <br />

                <asp:TextBox ID="txtRetypePassword" runat="server" placeholder="Retype your password" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="cvPassword" runat="server" ControlToValidate="txtRetypePassword"
                    ControlToCompare="txtPassword" ErrorMessage="Sorry, passwords do not match" ValidationGroup="SignUp" ForeColor="IndianRed" Display="Dynamic" />
                <br />
                <br />

                <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email id"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Email is required" ValidationGroup="SignUp" ForeColor="IndianRed" Display="Dynamic" />
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="Please enter a valid email" ValidationGroup="SignUp" ForeColor="IndianRed" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" Display="Dynamic" />
                <br />
                <br />

                <asp:TextBox ID="txtDOB" runat="server" placeholder="Enter your username" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ControlToValidate="txtDOB"
                    ErrorMessage="Date of Birth is required " ValidationGroup="SignUp" ForeColor="IndianRed" Display="Dynamic" />
                <asp:RangeValidator ID="rvDOB" runat="server" ControlToValidate="txtDOB"
                    ErrorMessage="Enter the Date between 01-01-1970 to 01-01-2025" Type="Date"
                    MinimumValue="01/01/1970" MaximumValue="01/01/2025" ValidationGroup="SignUp" ForeColor="IndianRed" Display="Dynamic" />
                <br />
                <br />

                <div class="validation-summary">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                    &nbsp;&nbsp;
         <asp:Button ID="txtbtnSignIn" runat="server" Text="Sign In" OnClick="txtbtnSignIn_Click" />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="SignUp" ForeColor="IndianRed" />
                </div>
                <br />
                <br />
                <div>
                    <asp:Label ID="txtDisplay" runat="server" Height="100" Width="540"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>



















