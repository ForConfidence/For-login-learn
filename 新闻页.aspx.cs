using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class 新闻页 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    protected void Bind()
    {
        DataSet dt = SqlHelper.ExecuteDataset(CommandType.Text, " SELECT * FROM [chang].[dbo].[NewsType] WHERE NParentID=0 ");
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = "NTypename";
        DropDownList1.DataValueField = "NTID";
        DropDownList1.DataBind();
        
        
        
        Bind2();
        object w=Request.QueryString["w"];
        if(w!=null)
        {

            DropDownList1.SelectedValue = w.ToString();
            Bind2();        
        }
        
        object NID = Request.QueryString["NID"];
        if (NID != null)
        {

            DataSet dt2 = SqlHelper.ExecuteDataset(CommandType.Text, " SELECT * FROM [chang].[dbo].[News] WHERE NID=" + int.Parse(NID.ToString()) + " ");
            TextBox1.Text = dt2.Tables[0].Rows[0]["NTitle"].ToString();

            TextArea1.InnerHtml = dt2.Tables[0].Rows[0]["NContent"].ToString();
            int NTID = int.Parse(dt2.Tables[0].Rows[0]["NTID"].ToString());

            DataSet dt3 = SqlHelper.ExecuteDataset(CommandType.Text, " SELECT * FROM [chang].[dbo].[NewsType] WHERE NTID=" + NTID + " ");


            int NPTID = int.Parse(dt3.Tables[0].Rows[0]["NParentID"].ToString());

            DropDownList1.SelectedValue = NPTID.ToString();
            Bind2();
            DropDownList2.SelectedValue = NTID.ToString();

        }


    }

    protected void Bind2()
    {
        DataSet dt = SqlHelper.ExecuteDataset(CommandType.Text, " SELECT * FROM [chang].[dbo].[NewsType] WHERE NParentID=" + DropDownList1.SelectedValue + " ");
        DropDownList2.DataSource = dt;
        DropDownList2.DataTextField = "NTypename";
        DropDownList2.DataValueField = "NTID";
        DropDownList2.DataBind();   
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        string title = TextBox1.Text;
        string content = TextArea1.InnerHtml;
        object NID = Request.QueryString["NID"];

        if (NID != null)
        {
            int aa = SqlHelper.ExecuteNonQuery(CommandType.Text, "UPDATE [chang].[dbo].[News] SET [NTID] = " + DropDownList2.SelectedValue + ",[NTitle] = '" + title + "',[NContent] = '" + content + "'   WHERE NID=" + int.Parse(NID.ToString()) + "");
            if (aa > 0)
            {
                Response.Write("<script>alert('更新成功！')</script>");
                Response.Redirect("新闻表.aspx");
            }
            else
            {
                Response.Write("<script>alert('更新失败！')</script>");
                return;
            }

        }
        else
        {
            int a = SqlHelper.ExecuteNonQuery(CommandType.Text, "INSERT INTO [chang].[dbo].[News]   ([NTID],[NTitle],[NContent])  VALUES (" + int.Parse(DropDownList2.SelectedValue) + ",'" + title + "','" + content + "') ");


            if (a > 0)
            {
                Response.Write("<script>alert('插入成功！')</script>");
                Response.Redirect("新闻表.aspx");
            }
            else
            {
                Response.Write("<script>alert('插入失败！')</script>");
                return;
            }
        }



    }




    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Bind2();
        Response.Redirect("新闻页.aspx?w=" + DropDownList1.SelectedValue + "");
    }
}