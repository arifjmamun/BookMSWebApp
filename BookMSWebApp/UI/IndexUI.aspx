<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="BookMSWebApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page | Book Management System</title>
    <style>
        * {
            font-family: "Helvetica";
        }
        li {
            list-style: none;
            font-size: 25px;
            line-height: 40px;
        }
        ul {
            padding: 0;
            text-align: center;
        }
        legend {
            font-size: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td width="40%">&nbsp;</td>
                <td>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
                <td width="40%">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <fieldset>
                        <legend>Index</legend>
                        <ul>
                            <li><a href="AddBook.aspx" target="_blank">Add Book</a></li>
                            <li><a href="ShowBook.aspx" target="_blank">Show Book</a></li>
                        </ul>
                    </fieldset>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
