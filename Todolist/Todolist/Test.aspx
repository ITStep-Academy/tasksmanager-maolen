<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Todolist.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="count"></asp:Label>
        </div>
        <p>
            <asp:Button runat="server" OnClick="Unnamed_Click" Height="40px" Text="+1" Width="58px"/>
        </p>
    </form>
</body>
</html>
