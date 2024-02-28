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
    public partial class VerificationForm : Form
    {
        /// <summary>
        /// Readonly tekrar instance alınmasın diye kullanıldı.
        /// String türünde correctCode, tanımlandı.
        /// db adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.       
        /// IUserSERVICE türünden bir alan (field) tanımlandı.
        /// </summary>
        private readonly int userId;
        private readonly string correctCode;
        private readonly BeFitAppContext db;
        private readonly IUserSERVICE _userService;

        //public VerificationForm(): Sınıfın yapıcı metodudur. Bu metodun içinde yapılacak işlemler, sınıfın bir örneği oluşturulduğunda otomatik olarak gerçekleşir.
        //Parametreden gelen değerler bu sınıfın içinde kullanılması için bu formdaki değerlere atandı.
        public VerificationForm(int userId, string correctCode, BeFitAppContext db, IUserSERVICE userService)
        {
            InitializeComponent();
            this.userId = userId;
            this.correctCode = correctCode;
            this.db = db;
            this._userService = userService;
        }

        //Activate butonuna basıldığında aktivasyon kodu doğru girildiyse MemberInformation formu açılır ve bu form kapanır.
        //Eğer kod yanlış girilirse kulllanıcı silinir ve uyarı mesajı verir.Tekrar SignUpScreene yönlendirilir.
        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text == correctCode)
            {
                MemberInformation form2 = new MemberInformation(userId, db);
                form2.Show();
                this.Close();
            }
            else
            {
                var userMail = Properties.Settings.Default.RememberedEmail;
                var user = db.Users.FirstOrDefault(x => x.UserMail == userMail);
                _userService.Delete(user);
                MessageBox.Show("Invalid activation code, please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SignUpScreen signUpScreen = new SignUpScreen();
                signUpScreen.Show();
                this.Close();
            }
        }
    }
}
