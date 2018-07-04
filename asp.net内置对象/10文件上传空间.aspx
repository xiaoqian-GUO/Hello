<%@ Page Language="C#" AutoEventWireup="true" CodeFile="10文件上传空间.aspx.cs" Inherits="_10文件上传空间" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #File1
        {
            height: 18px;
            width: 315px;
        }
        #fileUpload
        {
            width: 308px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <input id="fileUpload" runat="server" type="file" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="28px" onclick="Button1_Click" 
            Text="上传" Width="59px" />
        <br />
        <br />
        <div style="height: 92px; width: 572px" id="divMessage" runat="server">
        </div>
        <br />
    
    </div>
    </form>
</body>
</html>
