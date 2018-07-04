using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class _14dropdownList控件 : System.Web.UI.Page
{
    //DropDownList ddl = new DropDownList();
    protected void Page_Init(object sender, EventArgs e)
    {
        //DropDownList ddl = new DropDownList();
        ddl.AutoPostBack = true;
        ddl.Items.Add(new ListItem("国家", "c"));
        ddl.Items.Add(new ListItem("中国", "c1"));
        ddl.Items.Add(new ListItem("美国", "c2"));
        ddl.Items.Add(new ListItem("澳大利亚","c3"));
        ddl.SelectedIndexChanged += new EventHandler(ddl_SelectedIndexChanged);
        //this.Form.Controls.Add(ddl); 
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DropDownList dl = (DropDownList)sender;
        //Response.Write("<script>alert('" + dl.SelectedValue + "')</script>");
        if (ddl.SelectedItem.Text == "中国")
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("上海");
            dataList.Add("北京");
            dataList.Add("成都");
            dataList.Add("广州");
            dataList.Add("深圳");
            listbox.DataSource = dataList;
            listbox.DataBind();
        }
        if (ddl.SelectedItem.Text == "美国")
        {
            ArrayList dataList2 = new ArrayList();
            dataList2.Add("纽约");
            dataList2.Add("洛杉矶");
            dataList2.Add("芝加哥");
            dataList2.Add("修士顿");
            dataList2.Add("费城");
            listbox.DataSource = dataList2;
            listbox.DataBind();
        }
        if (ddl.SelectedItem.Text == "澳大利亚")
        {
            ArrayList dataList3 = new ArrayList();
            dataList3.Add("堪培拉");
            dataList3.Add("墨尔本");
            dataList3.Add("悉尼");
            listbox.DataSource = dataList3;
            listbox.DataBind();
        }
    }

    protected void dropdown_Init(object sender, EventArgs e)
    {

    }
}