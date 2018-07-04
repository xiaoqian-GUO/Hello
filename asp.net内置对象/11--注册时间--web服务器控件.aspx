<%@ Page Language="C#" AutoEventWireup="true" CodeFile="11--注册时间--web服务器控件.aspx.cs" Inherits="_11web" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;<br />
        <asp:TextBox ID="txtbox" runat="server" Height="27px" oninit="txtbox_Init" 
            ontextchanged="txtbox_TextChanged" TextMode="MultiLine" Width="303px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbl" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="84px" Width="98px" />
        <br />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
