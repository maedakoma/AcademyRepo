using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private Boolean _active;
        private Boolean _internal;
        private Boolean _membershipOK = true;
        private string _comment;
        private string _job;
        private string _mail;
        private string _phone;
        private string _address;
        private string _facebook;



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
        public Boolean Active
        {
            get { return this._active; }
            set { _active = value; }
        }
        public Boolean Internal
        {
            get { return this._internal; }
            set { _internal = value; }
        }
        public Boolean MembershipOK
        {
            get { return this._membershipOK; }
            set { _membershipOK = value; }
        }
        public string Comment
        {
            get { return this._comment; }
            set { _comment = value; }
        }
        public string Job
        {
            get { return this._job; }
            set { _job = value; }
        }
        public string Mail
        {
            get { return this._mail; }
            set { _mail = value; }
        }
        public string Phone
        {
            get { return this._phone; }
            set { _phone = value; }
        }
        public string Address
        {
            get { return this._address; }
            set { _address = value; }
        }
        public string Facebook
        {
            get { return this._facebook; }
            set { _facebook = value; }
        }
        public Member()
        {
            _payments = new List<Payment>();
        }
        
    }
}
