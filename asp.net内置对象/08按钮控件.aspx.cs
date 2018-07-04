using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _08按钮控件 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //对于输入的用户名和密码，进行身份验证，验证通过显示内容，不然提示用户名或密码不符！
        if (txtname.Value == "abc" && txtpwd.Value == "123")
        {
            divMessage.InnerHtml = "当前用户是" + txtname.Value + "," + "密码是" + txtpwd.Value;
        }
        else
        {
            divMessage.InnerHtml = "用户名和密码不符！";
        }
    }
}