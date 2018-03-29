using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ProductClass
    {
        private string name;
        private string company;
        private string catagory;
        private string packing;
        private string purchaseprice;
        private string saleprice;

        public string Saleprice
        {
            get { return saleprice; }
            set { saleprice = value; }
        }

        public string Purchaseprice
        {
            get { return purchaseprice; }
            set { purchaseprice = value; }
        }

        public string Packing
        {
            get { return packing; }
            set { packing = value; }
        }

        public string Catagory
        {
            get { return catagory; }
            set { catagory = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ProductClass()
        {
            name = "";
            company = "";
            catagory = "";
            packing = "";            
            purchaseprice = "";
            saleprice = "";
        }

    }
}
