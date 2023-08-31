<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SquareRoot.aspx.cs" Inherits="Assesment_15.SquareRoot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 337px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2"><h2 style="text-align:center">Square Root Evaluation</h2></td>
                </tr>
                <tr>
                    <td class="auto-style2">Imput the Number</td>
                    <td>
                        <asp:TextBox ID="TxtSqRoot" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="BtnClick" runat="server" Text="ResultDisplay" OnClick="BtnClick_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LblMsg" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
