﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyMgr
{

    public class Refund
    {

        private int _ID;
        private string _label;
        private decimal _amount;
        private DateTime _date;
        private string _comment;

        public int ID
        {
            get { return this._ID; }
            set { _ID = value; }
        }
        public decimal Amount
        {
            get { return this._amount; }
            set { _amount = value; }
        }
        public string Label
        {
            get { return this._label; }
            set { _label = value; }
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
        public Refund()
        {
        }
        
    }
}
