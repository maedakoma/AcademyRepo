<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resume.aspx.cs" Inherits="MembershipSite._Resume" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 507px">
    <form id="form1" runat="server">
    <div style="height: 174px">
        <h2>Home Page</h2>
        <asp:Label ID="Label1" runat="server" Text="Welcome to my site!"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Signout_Click" Text="LogOut" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Members</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Privates.aspx">Privates</asp:HyperLink>
        <br />
    </div>
        <br />
        <asp:Label ID="lblMembers" runat="server" Text="Nombre d'élèves actifs:"></asp:Label>
        <asp:TextBox ID="txtMembersCount" runat="server"></asp:TextBox>
        <asp:Label ID="lblTotal" runat="server" Text="Montant des licences:"></asp:Label>
        <asp:TextBox ID="txtLicencesAmount" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblTotalDebt" runat="server" Text="Dette des licences:"></asp:Label>
        <asp:TextBox ID="txtLicencesDebt" runat="server"></asp:TextBox>
        <asp:Label ID="lblBenef" runat="server" Text="Benefice net des licences:"></asp:Label>
        <asp:TextBox ID="txtLicencesBenef" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblPrivates" runat="server" Text="Montant des cours particuliers:"></asp:Label>
        <asp:TextBox ID="txtPrivates" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Montant des stages:"></asp:Label>
        <asp:TextBox ID="txtSeminar" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Dette des stages"></asp:Label>
        <asp:TextBox ID="txtSeminarDebt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Benefice net des stages:"></asp:Label>
        <asp:TextBox ID="txtSeminarBenef" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Salaire des profs déja payés:"></asp:Label>
        <asp:TextBox ID="txtTeacherPays" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Dette totale:"></asp:Label>
        <asp:TextBox ID="txtTotalDebt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label12" runat="server" Text="Dette déja payée:"></asp:Label>
        <asp:TextBox ID="txtPaidDebt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="Dette restante:"></asp:Label>
        <asp:TextBox ID="txtDebt" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Bénéfice total:"></asp:Label>
        <asp:TextBox ID="txtTotalBenef" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Text="Mensuel au black:"></asp:Label>
        <asp:TextBox ID="txtBlackMonth" runat="server"></asp:TextBox>
        <asp:Label ID="Label16" runat="server" Text="Mensuel déclaré:"></asp:Label>
        <asp:TextBox ID="txtOfficialMonth" runat="server"></asp:TextBox>
        <br />
        <br />
    </form>
</body>
</html>
