using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class insert : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        string pwd = txtPwd.Text;
        string pwd2 = txtPwd2.Text;
        string address1 = address.Text;
        string phone1 = phone.Text;



        DataSet dt = SqlHelper.ExecuteDataset(CommandType.Text, "SELECT * FROM [login] WHERE txtName='" + name + "' ");
        if(dt.Tables[0].Rows.Count>0)
        {
            Response.Write("<script>alert('该用户已存在')</script>");
            return;     
        
        }

        if (pwd != pwd2)
        {
            Response.Write("<script>alert('两次密码不一致')</script>");
            return;        
        }

        int a = SqlHelper.ExecuteNonQuery(CommandType.Text, "INSERT INTO [chang].[dbo].[login]([txtName],[txtPwd] ,[txtAddress],[txtPhone]) VALUES('" + name + "','" + pwd + "','" + address1 + "','" + phone1 + "')");


        if (a > 0)
        {
            Response.Write("<script>alert('注册成功')</script>");
            return;
        }
        else
        {
            Response.Write("<script>alert('注册失败')</script>");
            return;
        }
    }
}