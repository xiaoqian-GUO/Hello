<%@ Page Language="C#" AutoEventWireup="true" CodeFile="01表单.aspx.cs" Inherits="_01表单" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="02获得表单信息.aspx" method="post">
    <div>
    <table>
    <tr>
    <td>用户名：</td>
    <td> 
        <input name="username" type="text" /></td>
    </tr>
    <tr>
    <td>密码：</td>
    <td> 
        <input name="psw" type="text" /></td>
    </tr>
    </table>
        <input id="Submit1" type="submit" value="提交" />
        <input id="Reset1" type="reset" value="重置" />
    </div>
    </form>
</body>
</html>
