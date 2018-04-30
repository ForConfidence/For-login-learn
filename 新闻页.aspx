<%@ Page Language="C#" AutoEventWireup="true" CodeFile="新闻页.aspx.cs" Inherits="新闻页" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        新闻标题： <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <br />
        新闻内容
        <textarea id="TextArea1" cols="20" rows="2" runat="server"></textarea>
         <br />
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
