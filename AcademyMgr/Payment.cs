using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyMgr
{
   
    public class Payment
    {
        private readonly int _ID;
        private int _amount;
        private string _type;
        private int _dette;

        public int ID
        {
            get { return this._ID; }
        }
        public string Type
        {
            get { return this._type; }
            set { _type = value; }
        }
        public int Amount
        {
            get { return this._amount; }
            set { _amount = value; }
        }
        public int Dette
        {
            get { return this._dette; }
            set { _dette = value; }
        }
    }
}
