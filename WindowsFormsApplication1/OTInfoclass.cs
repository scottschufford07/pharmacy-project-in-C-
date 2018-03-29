using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class OTInfoclass
    {
        private string name;
        private string companyName;
        private string companyNumber;

        public string CompanyNumber
        {
            get { return companyNumber; }
            set { companyNumber = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public OTInfoclass()
        {
            name = "";
            companyName = "";
            companyNumber = "";
        }
       


    }
}
