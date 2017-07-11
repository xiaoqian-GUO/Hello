using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _12web服务器控件 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        lbl.Text = "您单击了普通按钮;";
    }
    protected void linkbtn_Click(object sender, EventArgs e)
    {
        lbl.Text = "您单击了链接按钮;";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        lbl.Text = "您单击了图像按钮;";
    }
}