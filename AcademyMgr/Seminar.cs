using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyMgr
{

    public class Seminar
    {

        private int _ID;
        private string _theme;
        private DateTime _date;
        private int _webMembers;
        private int _localMembers;
        private int _amount;
        private int _debt;
        private string _comment;

        public int ID
        {
            get { return this._ID; }
            set { _ID = value; }
        }
        public string Theme
        {
            get { return this._theme; }
            set { _theme = value; }
        }
        public DateTime Date
        {
            get { return this._date; }
            set { _date = value; }
        }
        public int WebMembers
        {
            get { return this._webMembers; }
            set { _webMembers = value; }
        }
        public int LocalMembers
        {
            get { return this._localMembers; }
            set { _localMembers = value; }
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
        public string Comment
        {
            get { return this._comment; }
            set { _comment = value; }
        }
        public Seminar()
        {
        }
        
    }
}
