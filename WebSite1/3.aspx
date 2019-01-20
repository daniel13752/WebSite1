<%@ Page Language="C#" AutoEventWireup="true" CodeFile="3.aspx.cs" Inherits="_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            שם מוצר
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            תיאור<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="הוספה" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="שאלה הבאה" />
        </div>
    </form>
</body>
</html>
