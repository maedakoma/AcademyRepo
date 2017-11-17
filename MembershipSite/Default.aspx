<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MembershipSite._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Home Page</h2>
        <asp:Label ID="Label1" runat="server" Text="Welcome to my site!"></asp:Label>
        <br />
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
        <asp:Panel ID="pnlMember" runat="server" Height="191px" Visible="False">
            Firstname:
            <asp:TextBox ID="tbFirstname" runat="server" Width="164px"></asp:TextBox>
            <br />
            Lastname:
            <asp:TextBox ID="tbLastname" runat="server" EnableTheming="True" Width="166px"></asp:TextBox>
            <br />
            Belt:
            <asp:DropDownList ID="ddBelt" runat="server">
            </asp:DropDownList>
            <br />
            Active:
            <asp:CheckBox ID="chkActive" runat="server" />
            <br />
            Alert:
            <asp:CheckBox ID="chkAlert" runat="server" />
            <br />
            Comment:
            <asp:TextBox ID="tbComment" runat="server" Width="705px"></asp:TextBox>
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
        <asp:GridView ID="mainGrid" runat="server" OnRowDataBound="mainGrid_RowDataBound" EnableModelValidation="True" OnRowDeleting="RowDeleting" OnRowEditing="RowEditing">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" Visible="False" />
            </Columns>
        </asp:GridView>
        <br />
    </form>
</body>
</html>
