<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>协同办公管理平台——考勤子系统
    </title>
    <style type="text/css">
        td {
            font-size: 12px;
            color: #007AB5;
        }

        form {
            margin: 1px;
            padding: 1px;
        }

        input {
            border: 0px;
            height: 26px;
            color: #007AB5;
            border: thin none #FFFFFF;
        }

        body {
            background-repeat: no-repeat;
            background-color: #9CDCF9;
            background-position: 0px 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="681" border="0" align="center" cellpadding="0" cellspacing="0" style="margin-top: 120px">
                <tr>
                    <td width="353" height="259" align="center" valign="bottom" background="../image/login/login_1.gif"></td>
                    <td width="195" background="../image/login/login_2.gif">
                        <table width="190" height="106" border="0" align="center" cellpadding="2" cellspacing="0">
                            <tr>
                                <td height="50" colspan="2" align="left">&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td width="60" height="30" align="left">用户名：
                                </td>
                                <td>
                                    <asp:TextBox ID="userName" runat="server" style="background: url(../image/login/login_6.gif) repeat-x; border: solid 1px #27B3FE; height: 20px; background-color: #FFFFFF; width: 130px;"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名必填" ControlToValidate="userName" Text="用户名不能为空！" Display="Dynamic"></asp:RequiredFieldValidator>
                                   <%--  <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="用户名的字符长度必须在20以内" ControlToValidate="userName" ClientValidationFunction="checkUserName" ></asp:CustomValidator>--%>

                                </td>
                            </tr>
                            <tr>
                                <td height="30" align="left">密码：
                                </td>
                                <td>
                                    <asp:TextBox ID="userPwd" runat="server"  type="password" style="background: url(../image/login/login_6.gif) repeat-x; border: solid 1px #27B3FE; height: 20px; background-color: #FFFFFF; width: 130px;"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="用户名必填" ControlToValidate="userName" Text="密码不能为空！" Display="Dynamic"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center">
                                    <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
                                </td>
                            </tr>
                            <%--  <tr>
                            <td height="5" colspan="2"></td>
                        </tr>--%>
                        </table>
                    </td>
                    <td width="133" background="../image/login/login_3.gif">&nbsp;
                    </td>
                </tr>
                <tr>
                    <td height="161" colspan="3" background="../image/login/login_4.gif"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<script>
    $(function () {
        
    })

    function checkUserName(src, args) {
        var flag = args.Value.length >= 3 && args.Value.length <= 20
        args.IsValid = flag;
    }
</script>

