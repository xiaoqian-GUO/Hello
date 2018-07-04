using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _11web : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtbox_TextChanged(object sender, EventArgs e)
    {
        //当文本信息出现变动的时候，触发该事件；
        lbl.Text = txtbox.Text;
    }
    protected void txtbox_Init(object sender, EventArgs e)
    {
        //在加载该页面时，初始化控件，并为控件注册一个事件；
        txtbox.Attributes.Add("onblur",Page.ClientScript.GetPostBackEventReference(this.txtbox,"OnBlur"));
    }

    // 编写onblur事件
    private void OnBlurHandle(string ctrl,string args)
    { 
        if(ctrl==this.txtbox.UniqueID&&args=="OnBlur")
        {
            lbl.Text = txtbox.Text;
        }
    }
}