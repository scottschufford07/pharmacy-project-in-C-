using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SalesManInfoClass
    {
        private string name;
        private string qualification;
        private string city;
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public SalesManInfoClass()
        {
            name = "";
            qualification = "";
            city = "";
            number = "";
        }
    }
}
