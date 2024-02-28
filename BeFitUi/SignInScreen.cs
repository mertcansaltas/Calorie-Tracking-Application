using BeFit.SERVICE.Concrete;
using BeFit.SERVICE.Interfaces;
using BeFit_REPO.Context;
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
    public partial class SignInScreen : Form
    {
        /// <summary>
        /// IUserSERVICE türünden bir alan (field) tanımlandı.
        /// db adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        private IUserSERVICE _userService; 
        private BeFitAppContext db;

        //public SignInScreen(): Sınıfın yapıcı metodudur. Bu metodun içinde yapılacak işlemler, sınıfın bir örneği oluşturulduğunda otomatik olarak gerçekleşir.
        //db = new BeFitAppContext(); db alanını, BeFitAppContext sınıfından yeni bir örnek oluşturarak başlatır. Bu, bir veritabanı bağlantısını temsil eden bir nesnenin oluşturulması anlamına gelir.
        // _userService = new UserSERVICE(db); _userService alanını, UserSERVICE sınıfından yeni bir örnek oluşturarak başlatır. Bu sınıfın yapıcı metoduna db parametresini geçirerek, veritabanı bağlantısını bu hizmet sınıfına iletmektedir.
        public SignInScreen()
        {
            InitializeComponent();
            db = new BeFitAppContext();
            _userService = new UserSERVICE(db);
        }

        /// <summary>
        /// Back butonuna basıldığında kullanıcıyı login ekranına yönlendirir.Bu form kapanır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Close();
        }

        //Giriş ekranı yüklendiğinde şifre alanının karakteri yıldız ile maskelenir.
        private void SignInScreen_Load(object sender, EventArgs e)
        {
            txtLoginPassword.PasswordChar = '*';
        }

        /// <summary>
        /// SignIn butonuna basıldığında kullanıcı bilgilerini kontrol eder ve uygun ekrana yönlendirilir.
        /// Admin ise AdminScreen ekranına normal kullanıcı ise MainScreen ekranına yönlendirilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtLoginEmail.Text == "admin" && txtLoginPassword.Text == "123") 
            {
                AdminScreen frm3 = new AdminScreen();
                frm3.Show();
                this.Hide();
            }
            else
            {
                //Kullanıcının girdiği email ve şifre email ve password değişkenlerine atandı.
                string email = txtLoginEmail.Text;
                string password = txtLoginPassword.Text;

                //Girilen maile ve şifreye göre kullanıcıyı veritabanından alır.
                var user = _userService.GetUserByEmailAndPassword(email, password);

                if (user != null)
                {
                    // E-posta adresini Settings.Settings ayarlarında saklar.
                    Properties.Settings.Default.RememberedEmail = email;
                    Properties.Settings.Default.Save();
                    MainScreen frm5 = new MainScreen();
                    frm5.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login credentials are incorrect");
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtLoginPassword.PasswordChar == '\0')
            {
                // Eðer şifre görünürse, tekrar gizle
                txtLoginPassword.PasswordChar = '*';
            }
            else
            {
                // Eðer şifre gizliyse, görünür yap
                txtLoginPassword.PasswordChar = '\0';
            }
        }
    }
}
