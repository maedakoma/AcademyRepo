<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Privates.aspx.cs" Inherits="MembershipSite._Privates" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 507px">
    <form id="form1" runat="server">
    <div style="height: 196px">
        <h2>Home Page</h2>
        <asp:Label ID="Label1" runat="server" Text="Welcome to my site!"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Signout_Click" Text="LogOut" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Members</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Resume.aspx">Resume</asp:HyperLink>
        <br />
        <br />
        <asp:Button ID="btnAddPrivate" runat="server" OnClick="btnAddPrivate_Click" Text="Add New Private" />
    </div>
        <asp:Panel ID="pnlPrivate" runat="server" Height="376px" Visible="False">
            &nbsp;Name:&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddMembers" runat="server" Height="41px" style="margin-left: 0px" Width="122px">
            </asp:DropDownList>
            <br />
            Booked:
            <asp:TextBox ID="txtBooked" runat="server"></asp:TextBox>
            <br />
            Done:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDone" runat="server"></asp:TextBox>
            <br />
            <br />
            Description:
            <asp:TextBox ID="txtDescription" runat="server" Height="108px" Width="912px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        </asp:Panel>
        <asp:GridView ID="GridPrivates" runat="server" EnableModelValidation="True" OnRowDataBound="gridPrivates_RowDataBound" OnRowDeleting="RowDeleting" OnRowEditing="RowEditing">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
