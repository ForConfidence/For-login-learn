using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string pwd = TextBox2.Text;

        if (name == "")
        {
            Response.Write("<script>alert'用户名不能为空!'</script>");
            return;
        }

        DataSet dt = SqlHelper.ExecuteDataset(CommandType.Text, "SELECT * FROM login WHERE txtName='" + name + "' ");
        if (dt.Tables[0].Rows.Count <= 0)
        {
            Response.Write("<script>alert('该用户不存在！')</script>");
            return;

        }


        DataSet dt1 = SqlHelper.ExecuteDataset(CommandType.Text, "SELECT * FROM login WHERE txtName='" + name + "' AND txtPwd='"+ pwd +"' ");

        if (dt1.Tables[0].Rows.Count > 0)
        {
            Session["name1"] = name;

            Response.Redirect("update.aspx");
        }
        else
        {

            Response.Write("<script>alert('密码错误!')</script>");
            return;

        }


        
    }
}