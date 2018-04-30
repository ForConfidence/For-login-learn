<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert.aspx.cs" Inherits="insert" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        用户名：<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator">用户名不能为空</asp:RequiredFieldValidator>
        <br />
        密码：&nbsp; 
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtPwd" ErrorMessage="RequiredFieldValidator">密码不能为空</asp:RequiredFieldValidator>
        <br />
        确认密码：<asp:TextBox ID="txtPwd2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="txtPwd" ControlToValidate="txtPwd2" 
            ErrorMessage="CompareValidator">两次密码不一致</asp:CompareValidator>
        <br />
        邮箱：&nbsp; 
        <asp:TextBox ID="address" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="address" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">格式不正确</asp:RegularExpressionValidator>
        <br />
        电话：&nbsp; 
        <asp:TextBox ID="phone" runat="server"></asp:TextBox>
    
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="phone" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}">格式不正确</asp:RegularExpressionValidator>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="注册" onclick="Button1_Click" 
            style="height: 21px" />
    
    </div>
    </form>
</body>
</html>
