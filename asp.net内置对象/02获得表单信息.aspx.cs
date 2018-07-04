using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _02获得表单信息 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.Form["username"].ToString();
        Label2.Text = Request.Form["psw"].ToString();

        //Label1.Text=Request.QueryString["username"].ToString();
        //Label2.Text = Request.QueryString["psw"].ToString();
    }
}