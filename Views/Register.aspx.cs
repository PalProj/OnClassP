using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RB_Click(object sender, EventArgs e)
    {
        string Phone = phone.Text;
        string ValidationCode = checkcode.Text;
        string Pw1 = pw1.Text;
        string Pw2 = pw2.Text;
        if (Pw1.Equals(Pw2))
        {
            //数据库交互类
            // UserRegist();
            //错误处理
            Response.Redirect("~/Views/Home");
        }
        else
        {
            Response.Write("<script>alert('两次密码输入不一致')</script>");
        }
    }
}