<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta name="viewport" content="width=device-width,height=device-height,inital-scale=1.0,maximum-scale=1.0,user-scalable=no;"/>
<meta name="apple-mobile-web-app-capable" content="yes"/>
<meta name="apple-mobile-web-app-status-bar-style" content="black"/>
<meta name="format-detection" content="telephone=no"/>

    <title>登陆</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        欢迎来到我的个人主页，请登录。<br />
        <br />
        用户名：<asp:TextBox ID="TextBox1" 
            runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" EnableTheming="True" ErrorMessage="请输入用户名！" 
            ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        密 码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="请输入密码！" ForeColor="Red" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
    
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="登陆" 
            style="text-align: center" />
    </p>
    </form>
</body>
</html>
