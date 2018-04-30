<%@ Page Language="C#" AutoEventWireup="true" CodeFile="新闻表.aspx.cs" Inherits="新闻表" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    
    <table>
    <tr>
    <td>NID</td>
    <td>父类</td>
    <td>子类</td>
    <td>标题</td>
    <td>编辑</td>
    </tr>

    <%=table %>
    
        </table>
    <%--<uc1:page ID="page1" runat="server"  file="新闻表"/>--%>
       
    <%=numPage %>
    
    </div>
    </form>
</body>
</html>
