using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademyMgr;
using System.Data;
using System.Web.Security;

namespace MembershipSite
{
    public partial class _Resume : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            manager.Open();

            txtMembersCount.Text = manager.getActiveMembersCount().ToString();
            int nLicencesAmount = manager.getLicencesAmount();
            txtLicencesAmount.Text = nLicencesAmount.ToString();
            int nLicencesDebt = manager.getLicencesDebt();
            txtLicencesDebt.Text = nLicencesDebt.ToString();
            txtLicencesBenef.Text = (nLicencesAmount - nLicencesDebt).ToString();
            int nPrivatesAmount = manager.getPrivatesAmount();
            txtPrivates.Text = nPrivatesAmount.ToString();
            int nSeminarsAmount = manager.getSeminarsAmount();
            txtSeminar.Text = nSeminarsAmount.ToString();
            int nSeminarsDebt = manager.getSeminarsDebt();
            txtSeminarDebt.Text = nSeminarsDebt.ToString();
            txtSeminarBenef.Text = (nSeminarsAmount - nSeminarsDebt).ToString();
            int nCoachsPaysAmount = manager.getCoachsPaysAmount();
            txtTeacherPays.Text = nCoachsPaysAmount.ToString();
            txtTotalDebt.Text = (nSeminarsDebt + nLicencesDebt).ToString();
            txtPaidDebt.Text = manager.getPaidDebt().ToString();
            txtDebt.Text = (nSeminarsDebt + nLicencesDebt - manager.getPaidDebt()).ToString();
            int nTotalBenef = nLicencesAmount - nLicencesDebt + nPrivatesAmount + nSeminarsAmount - nSeminarsDebt - nCoachsPaysAmount;
            txtTotalBenef.Text = nTotalBenef.ToString();
            //calcul d'un mensuel hypothétique:
            DateTime beginDate = new DateTime(2017, 5, 1);
            int nMonth = Math.Abs((beginDate.Month - DateTime.Now.Month) + 12 * (beginDate.Year - DateTime.Now.Year));
            txtBlackMonth.Text = (nTotalBenef / nMonth).ToString();
            txtOfficialMonth.Text = ((nTotalBenef * 75) / (nMonth * 100)).ToString();
            txtPrevBlackMonth.Text = (nTotalBenef / 12).ToString();
            txtPrevOfficialMonth.Text = ((nTotalBenef * 75) / (12 * 100)).ToString();
        }
        protected void Signout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Logon.aspx");
        }
    }
}
