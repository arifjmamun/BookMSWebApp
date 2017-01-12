<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookMSWebApp.UI.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Book | Book Management System</title>
    <style>
        * {
            font-family: "Helvetica";
        }
        body {
            width: 100%;
            margin-top: 200px;
            margin-left: 0;
            margin-right: 0;
        }
        fieldset {
            width: 30%;
            margin: auto;
            padding: 20px;
        }
        table {
            float: none;
            padding-left: 76px;
        }
        .pull-right {
            float: right !important;
        }
        button, input[type="submit"] {
            margin-top: 3px;
            height: 28px;
            width: 70px;
        }
        input[type="text"] {
            height: 20px;
            min-width: 200px;
        }
        .auto-style1 {
            width: 70px;
        }
        legend {
            font-size: 25px;
        }
        .msg-label {
            line-height: 20px;
            font-size: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset>
            <legend>Add Book</legend>
            <table>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="bookNameTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="ISBN"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="isbnTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        
                    </td>
                    <td>
                        <asp:Button ID="saveButton" runat="server" Text="Save" CssClass="pull-right" OnClick="saveButton_Click"/>
                    </td>
                </tr>
            </table>
            <asp:Label ID="msgLabel" runat="server" CssClass="msg-label"></asp:Label>
        </fieldset>        
    </div>
    </form>
</body>
</html>
