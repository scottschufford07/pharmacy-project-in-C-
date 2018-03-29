using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class UserInformation
    {
        // Data Member and properties
        private string _username;

        public string Usrename
        {
            get { return _username; }
            set { _username = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public UserInformation()
        {
            _username = "";
            _password = "";
        }
    }
}
