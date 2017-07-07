using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _07html服务器控件 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //将文本框中输入的信息赋给div服务器控件；
        divMessage.InnerHtml = txtInput.Value;

    }
}