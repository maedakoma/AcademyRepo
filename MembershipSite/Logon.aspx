<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logon.aspx.cs" Inherits="MembershipSite.LogInPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 240px;
            height: 68px;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <br />
            <br />
            <br />
            <img class="auto-style1" src="logoCercleTissier.png" /><br />
            <br />
            <br />
        <asp:Login ID="LoginControl" runat="server" 
            onauthenticate="LoginControl_Authenticate" PasswordLabelText="Pass" RememberMeText="Remember me" TextLayout="TextOnTop" TitleText="" UserNameLabelText="Name">
        </asp:Login>
        </div>
    </form>
</body>
</html>
