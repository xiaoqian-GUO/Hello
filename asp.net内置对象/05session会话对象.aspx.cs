using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _05session会话对象 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Session["user"] = 1;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = Convert.ToInt32(Session["user"]);
        Response.Write(i);
        i++;
        Session["user"] = i;
    }
}