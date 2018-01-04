using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyMgr
{
   
    public class Payment
    {
        public enum bankEnum
        {
            None = 0,
            Academy = 1,
            Perso = 2
        }

        public enum typeEnum
        {
            Cash = 0,
            Check = 1,
            Transfert = 2
        }

        private int _ID;
        private int _amount;
        private typeEnum _type;
        private string _name;
        private int _debt;
        private bankEnum _bank;
        private DateTime _receptionDate;
        private DateTime _depotDate;
        
        public int ID
        {
            get { return this._ID; }
            set { _ID = value; }
        }
        public typeEnum Type
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
        public bankEnum Bank
        {
            get { return this._bank; }
            set { _bank = value; }
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
