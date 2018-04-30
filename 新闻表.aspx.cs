using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class 新闻表 : System.Web.UI.Page
{
    public string table = "";
    public string numPage = "";
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }


    protected void Bind()
    {
        int pageIndex = 0;
        object page = Request.QueryString["page"];
        if (page != null && page.ToString()!="")
        {
            pageIndex = int.Parse(page.ToString());
            pageIndex--;
        }

        

        int pageRowCount = 3;
        int totalRowCount=(int)SqlHelper.ExecuteScalar(CommandType.Text,"SELECT count(*) FROM [chang].[dbo].[News]");
        int pageCount = (int)Math.Ceiling(totalRowCount / (double)pageRowCount);
        //page1.a = pageCount;
        Pager(pageCount);
        int offset = pageIndex * pageRowCount;
        string sql = "";
        if (offset > 0)
        {
            DataSet dt = SqlHelper.ExecuteDataset(CommandType.Text, "SELECT TOP " + offset + " [NID] FROM [chang].[dbo].[News] ORDER BY NID DESC");
            int minID = int.Parse(dt.Tables[0].Rows[dt.Tables[0].Rows.Count - 1]["NID"].ToString());

            sql = "SELECT TOP " + pageRowCount + " * FROM [chang].[dbo].[News] WHERE NID<" + minID + " ORDER BY NID DESC";


        }
        else
        {
            sql = "SELECT TOP " + pageRowCount + " * FROM [chang].[dbo].[News]  ORDER BY NID DESC";
        
        
        
        }
        DataSet dt2 = SqlHelper.ExecuteDataset(CommandType.Text,sql);

        for (int i = 0; i < dt2.Tables[0].Rows.Count; i++)
        {
            string NID = dt2.Tables[0].Rows[i]["NID"].ToString();
            string NTID = dt2.Tables[0].Rows[i]["NTID"].ToString();
            string NTitle = dt2.Tables[0].Rows[i]["NTitle"].ToString();
            

            DataSet dt3 = SqlHelper.ExecuteDataset(CommandType.Text, "SELECT * FROM [chang].[dbo].[NewsType] WHERE NTID=" + NTID + "   ");

            string subType = dt3.Tables[0].Rows[0]["NTypename"].ToString();
            string parentID = dt3.Tables[0].Rows[0]["NTID"].ToString();



            DataSet dt4 = SqlHelper.ExecuteDataset(CommandType.Text, "SELECT * FROM [chang].[dbo].[NewsType] WHERE NTID=" + parentID + "   ");

            string parentType = dt4.Tables[0].Rows[0]["NTypename"].ToString();
            table += @"<tr>
    <td>" + NID + @"</td>    
    <td>" + parentType + @"</td>
    <td>" + subType + @"</td>
    <td>" + NTitle + @"</td>
    <td><a href='新闻页.aspx?NID="+ NID +   @"'>编辑</a></td>
    </tr>
";


        }


    }
    protected void Pager(int a)
    {
        for (int i = 0; i < a;i++ )
        {

            numPage += "<a href='新闻表.aspx?page="+ (i+1) +"'>"+ (i+1) + "</a>";


        }
    
    
    }



}