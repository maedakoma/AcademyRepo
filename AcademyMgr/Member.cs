using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMgr
{

    public class Member
    {
        private int _ID;
        private string _firstname;
        private string _lastname;
        private string _gender;
        private string _belt;
        private List<Payment> _payments;

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
        public string Gender
        {
            get { return this._gender; }
            set { _gender = value; }
        }
        public string Belt
        {
            get { return this._belt; }
            set { _belt = value; }
        }
        public Member()
        {
            _payments = new List<Payment>();
        }
        
    }
}
