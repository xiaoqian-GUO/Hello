<%@ Page Language="C#" AutoEventWireup="true" CodeFile="内置对象.aspx.cs" Inherits="内置对象" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="C#" runat="server">
        void Event_click(object src,EventArgs abc)
        {
            Label1.Text = "我是一个内置对象！";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Event_click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <%=5+5 %>
        <% Response.Write("你猜这是什么~"); %>
    </div>
    </form>
</body>
</html>
