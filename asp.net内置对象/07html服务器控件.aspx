<%@ Page Language="C#" AutoEventWireup="true" CodeFile="07html服务器控件.aspx.cs" Inherits="_07html服务器控件" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1
        {
            height: 31px;
            width: 192px;
        }
        #txtInput
        {
            height: 28px;
            width: 239px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <input id="txtInput" type="text" runat="server"/></div>
    </form>
    <div id="divMessage" runat="server" style="width: 464px; height: 140px">
    </div>
</body>
</html>
