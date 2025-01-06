using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //  loginButton.Click += new EventHandler(loginButton_Click);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  private void Login_Load(object sender, EventArgs e){  }
        private void label5_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }
        string pass;
        private void Loginclick()

        {
            string username = UsernameTB.Text;
            //string password = PasswordTB.Text;
            string pass = txtPass.Text;
            if (username == "" || pass == "")
            {
                MBox1.Show("Enter UserName and Password");

            }
            else if (username == "evansvic" && pass == "copper1")
            {
                Mainmenu Obj = new Mainmenu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MBox1.Show("Wrong Username or Password");
            }

        }
        //  private void button1_MouseClick(object sender, MouseEventArgs e) { }
        //   private void loginButton_Click()
        //  {

        //  }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Loginclick();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void showpwd_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        /*
private void ViewPassword_CheckedChanged(object sender, EventArgs e)
{
if (ViewPassword.Checked)
{
PasswordTB.PasswordChar = '\0';
}
else
{
PasswordTB.PasswordChar = '*';
}
}
*/
    }
}
