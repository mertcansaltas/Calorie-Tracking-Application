using BeFit.SERVICE.Concrete;
using BeFit.SERVICE.Interfaces;
using BeFit_DATA.Concrete;
using BeFit_DATA.Enum;
using BeFit_REPO.Context;
using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BeFitUi
{
    public partial class SignUpScreen : Form
    {
        /// <summary>
        /// IUserSERVICE türünden bir alan (field) tanımlandı.
        /// db adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// String türünde verificationCode, tanımlandı.
        /// </summary>
        private BeFitAppContext db;
        private readonly IUserSERVICE _userService;
        private string verificationCode;

        //public SignUpScreen(): Sınıfın yapıcı metodudur. Bu metodun içinde yapılacak işlemler, sınıfın bir örneği oluşturulduğunda otomatik olarak gerçekleşir.
        //db = new BeFitAppContext(); db alanını, BeFitAppContext sınıfından yeni bir örnek oluşturarak başlatır. Bu, bir veritabanı bağlantısını temsil eden bir nesnenin oluşturulması anlamına gelir.
        // _userService = new UserSERVICE(db); _userService alanını, UserSERVICE sınıfından yeni bir örnek oluşturarak başlatır. Bu sınıfın yapıcı metoduna db parametresini geçirerek, veritabanı bağlantısını bu hizmet sınıfına iletmektedir.
        public SignUpScreen()
        {
            InitializeComponent();
            db = new BeFitAppContext();
            _userService = new UserSERVICE(db);
        }

        /// <summary>
        /// Register butonuna basıldığında kullanıcı bilgileri kaydedilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Password ve ConfirmPassword doğrulama eşleşmiyorsa hata mesajı verir.
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Please verify the password!");
                return;
            }

            // Kullanıcının girdiği e-posta adresi
            string email = txtEmail.Text; 
            //Girilen mailin veritabanında olup olmadığı kontrol edildi.
            bool isEmailAlreadyEntered = db.Users.Any(user => user.UserMail == email);

            if (isEmailAlreadyEntered)
            {
                MessageBox.Show("This email address is already in use. Please enter a different email address.");
            }
            else
            {
                //Kullancının email adresi ayarlarda saklandı.Tekrar aynı maille giriş yapıldığında kullanıcının tanınması sağlandı.
                Properties.Settings.Default.RememberedEmail = email;
                Properties.Settings.Default.Save();
                try
                {
                    //Girilen bilgilere göre yeni kullanıcı nesnesi oluşturuldu.
                    User newUser = new User
                    {
                        Name = txtName.Text,
                        LastName = txtSurname.Text,
                        Phone = mtxtPhone.Text,
                        UserMail = txtEmail.Text,
                        Password = txtPassword.Text
                    };

                    //Bu kullanıcı database e kaydedildi.Service de döndürdüğümüz Id,userId ye atandı.
                    int userId = _userService.Add(newUser);

                    //Kullanıcı bilgilerini girince,6 haneli doğrulama kodunu oluştur ve kullancının girdiği emaile gönder.
                    if (userId != null)
                    {
                        var random = new Random();
                        verificationCode = random.Next(100000, 999999).ToString();
                        MailMessage myMessage = new MailMessage();
                        SmtpClient istemci = new SmtpClient();
                        istemci.Credentials = new System.Net.NetworkCredential("befitstayhealty@outlook.com", "Bilgeadam123");
                        istemci.Port = 587;
                        istemci.Host = "smtp-mail.outlook.com";
                        istemci.EnableSsl = true;
                        myMessage.To.Add(txtEmail.Text);
                        myMessage.From = new MailAddress("befitstayhealty@outlook.com");
                        myMessage.Subject = "BeFit Activation Code";
                        myMessage.Body = "BeFit Your Activation Code " + verificationCode;
                        istemci.Send(myMessage);

                        //Aktivasyon kodunu aldığım form açılır.Bu forma userıd,Aktivasyonkodu,db,_userservice parametreleriyle gidiyorum.
                        VerificationForm verificationForm = new VerificationForm(userId, verificationCode, db, _userService);
                        verificationForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("User could not be created");
                    }
                }
                catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message);
                }
            }
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
    }
}