using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class CompanyInformationClass
    {
        private string name;
        private string address;
        private int phoneNo;
        private int cell;


        public int PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        

        public int Cell
        {
            get { return cell; }
            set { cell = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public CompanyInformationClass()
        {
            name = "";
            address = "";
            phoneNo = 0;
            cell = 0;
        }
        


    }

}
