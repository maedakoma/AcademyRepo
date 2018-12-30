<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MembershipSite._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 447px;
            height: 145px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <h2 style="text-align: center">
            <img class="auto-style1" src="logoCercleTissierRouge.png" /></h2>
        <asp:Button ID="Button1" runat="server" OnClick="Signout_Click" Text="LogOut" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Resume.aspx">Resume</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Privates.aspx">Privates</asp:HyperLink>
        <br />
        <br />
        <asp:Button ID="btnAddMember" runat="server" OnClick="btnAddMember_Click" Text="Add new member" />
        <br />
    </div>
        <asp:Panel ID="pnlMember" runat="server" Height="421px" Visible="False" style="text-align: center">
            <br />
            Firstname:
            <asp:TextBox ID="tbFirstname" runat="server" Width="164px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lastname:
            <asp:TextBox ID="tbLastname" runat="server" EnableTheming="True" Width="166px"></asp:TextBox>
            <br />
            <br />
            Belt:
            <asp:DropDownList ID="ddBelt" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:TextBox ID="tbStripe" runat="server" Width="18px"></asp:TextBox>
&nbsp;
            <br />
            Child:
            <asp:CheckBox ID="chkChild" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Active:
            <asp:CheckBox ID="chkActive" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Competitor:
            <asp:CheckBox ID="chkCompetitor" runat="server" />
            <br />
            Coach:
            <asp:CheckBox ID="chkCoach" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Alert:
            <asp:CheckBox ID="chkAlert" runat="server" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fullyear:
            <asp:CheckBox ID="chkFullyear" runat="server" />
            <br />
            <br />
            Abonnement:
            <asp:DropDownList ID="ddAbo" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Privates:
            <asp:DropDownList ID="ddPrivates" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Comment:
            <asp:TextBox ID="tbComment" runat="server" Width="705px"></asp:TextBox>
            <br />
            Job:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbJob" runat="server" Width="705px"></asp:TextBox>
            <br />
            Mail:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbMail" runat="server" Width="705px"></asp:TextBox>
            <br />
            Adress:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbAdress" runat="server" Width="705px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <br />
        <div align="center">
        <asp:GridView ID="mainGrid" runat="server" OnRowDataBound="mainGrid_RowDataBound" OnRowDeleting="RowDeleting" OnRowEditing="RowEditing" Width="1462px">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" Visible="False" />
            </Columns>
        </asp:GridView>
        </div>
    </form>
</body>
</html>
