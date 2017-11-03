using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyMgr
{

    public class Private
    {

        private int _ID;
        private string _name;
        private int _amount;
        private DateTime _date;
        private int _bookedLessons;
        private int _doneLessons;

        public int ID
        {
            get { return this._ID; }
            set { _ID = value; }
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
        public DateTime Date
        {
            get { return this._date; }
            set { _date = value; }
        }
        public int BookedLessons
        {
            get { return this._bookedLessons; }
            set { _bookedLessons = value; }
        }
        public int DoneLessons
        {
            get { return this._doneLessons; }
            set { _doneLessons = value; }
        }
        public Private()
        {
        }
        
    }
}
