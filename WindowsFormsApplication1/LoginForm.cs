using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        public UserInformation _UserInfo;
         public LoginForm()
        {
            InitializeComponent();
            _UserInfo = new UserInformation();
            //_UserInfo.CompleteName = "Administrator";
            _UserInfo.Usrename = "ADMIN";
            _UserInfo.Password = "ADMIN";

        }
         private new bool Validate()
         {
             if (string.IsNullOrEmpty(label1.Text.Trim())
                 || string.IsNullOrEmpty(passwordtextbox.Text.Trim()))
             {
                 MessageBox.Show("Username or password is missing..", "Error");
                 return false;
             }

             return true;
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Main m1 = new Main();
            m1.Show();

            if (Validate())
            {
                UserInformation user = new UserInformation();

                try
                {
                    user.Usrename = usertextbox.Text.Trim();
                    user.Password = passwordtextbox.Text.Trim();

                    bool allowUser = QueryClass.ValidateUser(user);

                    if (allowUser)
                    {
                        Main mForm = new Main();
                        mForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                }


            } // end of of validate if


        }

        private void usertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    

    }
}
