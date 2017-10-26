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
        private genderEnum _gender;
        private beltEnum _belt;
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
        public Member()
        {
            _payments = new List<Payment>();
        }
        
    }
}
