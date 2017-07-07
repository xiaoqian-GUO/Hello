<%@ Page Language="C#" AutoEventWireup="true" CodeFile="08按钮控件.aspx.cs" Inherits="_08按钮控件" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1
        {
            width: 635px;
            height: 45px;
            margin-top: 11px;
        }
        #button
        {
            width: 58px;
            height: 35px;
        }
    </style>
    <script language="javascript" type="text/javascript">
// <![CDATA[

 
// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        用户名： <input id="txtname" runat="server" type="text" /><br />
        <br />
        密码：&nbsp; &nbsp; 
        <input id="txtpwd" runat="server" type="password" /><br />
        <br />
        备注信息：<br />
        <textarea id="TextArea1"  runat="server" name="S1"></textarea><br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Height="37px" onclick="Button1_Click" 
            Text="提交" Width="60px" />
    </div>
    </form>
    <div style="height: 68px" id="divMessage" runat="server">
    </div>
</body>
</html>
