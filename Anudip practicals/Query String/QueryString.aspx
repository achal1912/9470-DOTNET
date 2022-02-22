<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString.aspx.cs" Inherits="Query_String.QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    
                    </td>
                 <td class="auto-style1">
               <asp:TextBox ID="txtname" runat="server"></asp:TextBox>

                    </td>
                </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="City"></asp:Label>

                    </td>
                 <td class="auto-style1">
               <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>

                    </td>
            </tr>
        </table>
            <asp:Button ID="btnsend" runat="server" Text="SEND" OnClick="btnsend_Click" />
            
        </div>
    </form>
</body>
</html>  