<%@ Page Language="C#" AutoEventWireup="true" CodeFile="12web服务器控件.aspx.cs" Inherits="_12web服务器控件" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="69px" Width="80px" 
            ImageUrl="~/ps1.jpg" onclick="ImageButton1_Click" />
        <br />
        <br />
        <br />
        <asp:LinkButton ID="linkbtn" runat="server" onclick="linkbtn_Click">链接按钮</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btn" runat="server" Text="普通按钮" style="margin-left: 0px" 
            onclick="btn_Click" />
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;<asp:Label ID="lbl" runat="server"></asp:Label>
    </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
