using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFitUi
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        //Register butonuna basıldığında SignUp(Yeni üye kaydı) formuna geçilir ve bu form kapanır.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            SignUpScreen frm = new SignUpScreen();
            frm.Show();
            this.Hide();
        }


        //Login butonuna basıldığında SignIn(Kullanıcı Giriş) formuna geçilir ve bu form kapanır.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignInScreen signInScreen = new SignInScreen();
            signInScreen.Show();
            this.Hide();
        }
        
    }
}
