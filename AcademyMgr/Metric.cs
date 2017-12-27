using System;


namespace AcademyMgr
{
   
    public class Metric
    {
        private int _ID;
        private string _name;
        private int _value;
        private DateTime _date;
        
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
        public int Value
        {
            get { return this._value; }
            set { _value = value; }
        }
        public DateTime Date
        {
            get { return this._date; }
            set { _date = value; }
        }
    }
}
