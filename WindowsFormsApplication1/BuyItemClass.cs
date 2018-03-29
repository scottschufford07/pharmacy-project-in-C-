using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class BuyItemClass
    {
          private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _quantity;

        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private string _expiry;

        public string Expiry
        {
            get { return _expiry; }
            set { _expiry = value; }
        }
      public BuyItemClass()
      {
          _name = "";
          _quantity = "";
          _expiry = "";
      }
    }
}
