<%@ Page Language="C#" AutoEventWireup="true" CodeFile="修改密码.aspx.cs" Inherits="修改密码" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        旧密码：<asp:TextBox ID="txtOldpwd" runat="server"></asp:TextBox>
        <br />
        新密码：<asp:TextBox ID="txtNewpwd" runat="server"></asp:TextBox>
        <br />
        确认密码：<asp:TextBox ID="txtNewpwd2" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="确认" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
