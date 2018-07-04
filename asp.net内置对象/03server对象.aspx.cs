using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _03server对象 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //server对象的对应物理路径
        Label1.Text = Server.MapPath("~");
    }
}