using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class _10文件上传空间 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //点击上传按钮，将选中的文件重新存储
        //两种情况：1.未选择文件直接点击提交按钮； 2.点击了浏览，可是未选中任何文件；
        if (fileUpload.PostedFile.FileName != null && fileUpload.PostedFile.FileName != "")
        {
            string fullname = fileUpload.PostedFile.FileName;
            string[] filename = fullname.Split('\\');
            //string[] filename2 = Regex.Split(fullname,"\\",RegexOptions.IgnoreCase);
            //string[] filename2 = fullname.Split(new char[2]{'\\','/'});
            string file = filename[filename.Length - 1];
            string newSave = "D:\\" + file;
            fileUpload.PostedFile.SaveAs(newSave);
            divMessage.InnerHtml = "文件已经上传至服务器的" + newSave;
        }
        else
        {
            return;
        }
    }
}