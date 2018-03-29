using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class ExpenseClass
    {
        private string _nameexpense;

        public string Nameexpense
        {
            get { return _nameexpense; }
            set { _nameexpense = value; }
        }
        private string _rupees;

        public string Rupees
        {
            get { return _rupees; }
            set { _rupees = value; }
        }
        private string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
      public ExpenseClass()
      {
          _nameexpense = "";
          _rupees = "";
          _date = "";
      }

    }
}
