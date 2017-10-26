using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMgr
{

    public class CoachPay
    {

        private int _ID;
        private string _month;
        private string _coach;
        private int _lessons;
        private int _pay;
        private int _amount;
        private DateTime _date;
        private string _comment;

        public int ID
        {
            get { return this._ID; }
            set { _ID = value; }
        }
        public string Month
        {
            get { return this._month; }
            set { _month = value; }
        }
        public string Coach
        {
            get { return this._coach; }
            set { _coach = value; }
        }
        public int Lessons
        {
            get { return this._lessons; }
            set { _lessons = value; }
        }
        public int Pay
        {
            get { return this._pay; }
            set { _pay = value; }
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
        public string Comment
        {
            get { return this._comment; }
            set { _comment = value; }
        }
        public CoachPay()
        {
        }
        
    }
}
