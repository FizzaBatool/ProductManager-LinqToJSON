<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductForm.aspx.cs" Inherits="Linq_To_Json.ProductForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 37px;
        }
        .auto-style2 {
            margin-left: 46px;
        }
        .auto-style3 {
            margin-left: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="auto-style1">
                    &nbsp;<td>
                    <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Title"></asp:Label>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Expire"></asp:Label>
                    <asp:TextBox ID="txtExpiry" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Manufacturer"></asp:Label>
                    <asp:TextBox ID="txtManufacturer" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Stock"></asp:Label>
                    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"></asp:Button>
                    <asp:Button ID="BtnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"></asp:Button>
                    <asp:Button ID="BtnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"></asp:Button>
                    <asp:Button ID="BtnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"></asp:Button>
                </td>
            </tr>

        </table>

        <asp:TextBox runat="server" ID="txtMain" TextMode="MultiLine" Rows="10" Height="143px" Width="729px" CssClass="auto-style2"></asp:TextBox><br />
        <asp:Button ID="btnSaveToFile" runat="server" Text="Save To File" OnClick="btnSaveToFile_Click" CssClass="auto-style3"></asp:Button>
        <br /><br /><br />
        <asp:GridView ID="gridView" runat="server" Width="736px" CssClass="auto-style2">
        </asp:GridView>
    </form>
</body>
</html>
