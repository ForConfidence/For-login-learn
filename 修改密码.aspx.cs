using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class 修改密码 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {




    }





    protected void Button1_Click(object sender, EventArgs e)
    {
     




        string name = Session["name1"].ToString();




        string oldPwd = txtOldpwd.Text;
        string newPwd = txtNewpwd.Text;
        string newPwd2= txtNewpwd2.Text;


        if (oldPwd == newPwd)
        {
            Response.Write("<script>alert('新旧密码不能相同')</script>");
            return;

        }

        if (newPwd != newPwd2)
        {
            Response.Write("<script>alert('两次密码不一致')</script>");
            return;
        
        }


        

        DataSet dt1 = SqlHelper.ExecuteDataset(CommandType.Text, "SELECT * FROM [chang].[dbo].[login] WHERE txtName='" + name + "' AND txtPwd='" + oldPwd + "' ");
        if (dt1.Tables[0].Rows.Count <= 0)
        {
            Response.Write("<script>alert('密码不正确')</script>");
            return;

        }

        int a = SqlHelper.ExecuteNonQuery(CommandType.Text, "UPDATE [chang].[dbo].[login] SET [txtPwd] = '" + newPwd + "' WHERE txtName='" + name + "'");

        if (a > 0)
        {
            Response.Redirect("login.aspx");

        }
        else
        {

            Response.Write("<script>alert('修改失败')</script>");
            return;
        
        
        }

    }
}