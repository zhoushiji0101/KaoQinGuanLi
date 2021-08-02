using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        LoginBLL l = new LoginBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var username = this.userName.Text;
            var userpwd = this.userPwd.Text;
            int count = l.login(username, userpwd);
            if (count > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('登录成功')", true);
                //跳转到对应页面
            }
            else {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "alert('登录失败')", true);
            }
        }
    }
}