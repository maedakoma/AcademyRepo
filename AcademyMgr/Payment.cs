using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMgr
{
   
    public class Payment
    {
        private readonly int _ID;
        private int _amount;
        private string _type;
        private string _name;
        private int _debt;
        private DateTime _receptionDate;

        public int ID
        {
            get { return this._ID; }
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
        public DateTime ReceptionDate
        {
            get { return this._receptionDate; }
            set { _receptionDate = value; }
        }
    }
}
