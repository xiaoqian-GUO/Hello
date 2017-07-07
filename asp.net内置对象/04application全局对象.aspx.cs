using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _04application全局对象 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if(Application["sum"]==null)
            {
                Application.Lock();
                Application["sum"] = 10;
                Application.UnLock();
            }
            
            
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = Convert.ToInt32(Application["sum"]);
        Response.Write(i);
        i++;
        Application.Lock();
        Application["sum"] = i;
        Application.UnLock();
    }
}