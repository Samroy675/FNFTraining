<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWords.aspx.cs" Inherits="SampleWebFormsApp.MyWords" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Words</title>
    <style>
        body {
            font-family: 'Roboto', sans-serif;
            background-color: #f4f6f8;
            margin: 0;
            padding: 20px;
        }

        .section {
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 2px 8px rgba(0,0,0,0.1);
            padding: 20px;
            margin-bottom: 20px;
            max-width: 600px;
            margin-left: auto;
            margin-right: auto;
        }

        h2 {
            color: #333;
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-top: 10px;
            font-weight: bold;
        }

        input[type="text"], .aspNetTextBox {
            width: 100%;
            padding: 8px;
            margin-top: 5px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .aspNetButton {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 16px;
            border-radius: 4px;
            cursor: pointer;
            margin-top: 10px;
        }

        .aspNetButton:hover {
            background-color: #0056b3;
        }

        .aspNetLabel {
            display: block;
            margin-top: 10px;
            font-size: 14px;
        }

        .aspNetGridView {
            width: 100%;
            border-collapse: collapse;
            margin-top: 15px;
        }

        .aspNetGridView th, .aspNetGridView td {
            border: 1px solid #ddd;
            padding: 8px;
        }

        .aspNetGridView th {
            background-color: #007bff;
            color: white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="section">
            <h2>Search Word</h2>
            <label for="txtSearch">English Word:</label>
            <asp:TextBox ID="txtSearch" runat="server" CssClass="aspNetTextBox" />
            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="aspNetButton" OnClick="btnSearch_Click" />
            <asp:Label ID="lblSearchResult" runat="server" CssClass="aspNetLabel" ForeColor="Green" />
        </div>

        <div class="section">
            <h2>Add to My Words</h2>
            <label for="txtWord">Word:</label>
            <asp:TextBox ID="txtWord" runat="server" CssClass="aspNetTextBox" />
            <label for="txtTranslation">Translation:</label>
            <asp:TextBox ID="txtTranslation" runat="server" CssClass="aspNetTextBox" />
            <asp:Button ID="btnAdd" runat="server" Text="Add to My Words" CssClass="aspNetButton" OnClick="btnAdd_Click" />
        </div>

        <div class="section">
            <h2>My Words List</h2>
            <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="False" CssClass="aspNetGridView">
                <Columns>
                    <asp:BoundField DataField="Word" HeaderText="Word" />
                    <asp:BoundField DataField="Translation" HeaderText="Translation" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
