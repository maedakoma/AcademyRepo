using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMgr
{
   
    public class Payment
    {
        private int _ID;
        private int _amount;
        private string _type;
        private string _name;
        private int _debt;
        private Boolean _depotBank;
        private DateTime _receptionDate;
        private DateTime _depotDate;

        public int ID
        {
            get { return this._ID; }
            set { _ID = value; }
        }
        public string Type
        {
            get { return this._type; }
            set { _type = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { _name = value; }
        }
        public int Amount
        {
            get { return this._amount; }
            set { _amount = value; }
        }
        public int Debt
        {
            get { return this._debt; }
            set { _debt = value; }
        }
        public Boolean depotBank
        {
            get { return this._depotBank; }
            set { _depotBank = value; }
        }
        public DateTime ReceptionDate
        {
            get { return this._receptionDate; }
            set { _receptionDate = value; }
        }
        public DateTime DepotDate
        {
            get { return this._depotDate; }
            set { _depotDate = value; }
        }
    }
}
