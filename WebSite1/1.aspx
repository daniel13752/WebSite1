<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1.aspx.cs" Inherits="_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="חישוב" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>

            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="שאלה הבאה" />

        </div>
    </form>
</body>
</html>
