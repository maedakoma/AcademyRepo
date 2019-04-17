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
            Perso = 2,
            Coach = 3
        }

        public enum typeEnum
        {
            Cash = 0,
            Check = 1,
            Transfert = 2,
            Prelev = 3
        }

        public enum PrestationTypeEnum
        {
            Abo = 0,
            Private = 1
        }

        private int _ID;
        private Decimal _amount;
        private typeEnum _type;
        private PrestationTypeEnum _prestationType;
        private string _name;
        private Decimal _debt;
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
        public PrestationTypeEnum prestationType
        {
            get { return this._prestationType; }
            set { _prestationType = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { _name = value; }
        }
        public Decimal Amount
        {
            get { return this._amount; }
            set { _amount = value; }
        }
        public Decimal Debt
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
