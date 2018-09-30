using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyMgr
{
   
    public class Plan
    {
        public enum typeEnum
        {
            Abonnement = 0,
            Private = 1
        }

        private int _ID;
        private string _label;
        private typeEnum _type;
        private int _amount;
        private int _debtPercentage;

        
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
        public string Label
        {
            get { return this._label; }
            set { _label = value; }
        }
        public int Amount
        {
            get { return this._amount; }
            set { _amount = value; }
        }
        public int DebtPercentage
        {
            get { return this._debtPercentage; }
            set { _debtPercentage = value; }
        }
    }
}
