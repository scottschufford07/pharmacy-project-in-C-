using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class OTClass
    {
        private string name;
        private string quantity;

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public OTClass()
        {
            name = "";
            quantity="";
        }
    }
}
