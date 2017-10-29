using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMgr
{

    public class Member
    {
        public enum beltEnum
        {
            White = 0,
            Blue = 1,
            Purple = 2,
            Brown = 3,
            Black = 4
        }

        public enum genderEnum
        {
            M = 0,
            F = 1
        }

        private int _ID;
        private string _firstname;
        private string _lastname;
        private DateTime _enddate;
        private genderEnum _gender;
        private beltEnum _belt;
        private List<Payment> _payments;
        private Boolean _child;
        private Boolean _alert;
        private string _comment;


        public int ID
        {
            get { return this._ID; }
            set { _ID = value; }
        }
        public List<Payment> Payments
        {
            get { return this._payments; }
        }
        public string Firstname
        {
            get { return this._firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return this._lastname; }
            set { _lastname = value; }
        }
        public DateTime Enddate
        {
            get { return this._enddate; }
            set { _enddate = value; }
        }
        public genderEnum Gender
        {
            get { return this._gender; }
            set { _gender = value; }
        }
        public beltEnum Belt
        {
            get { return this._belt; }
            set { _belt = value; }
        }
        public Boolean Child
        {
            get { return this._child; }
            set { _child = value; }
        }
        public Boolean Alert
        {
            get { return this._alert; }
            set { _alert = value; }
        }
        public string Comment
        {
            get { return this._comment; }
            set { _comment = value; }
        }
        public Member()
        {
            _payments = new List<Payment>();
        }
        
    }
}
