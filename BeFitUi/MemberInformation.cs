using BeFit.SERVICE.Concrete;
using BeFit.SERVICE.Interfaces;
using BeFit_DATA.Concrete;
using BeFit_DATA.Enum;
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
    public partial class MemberInformation : Form
    {
        /// <summary>
        /// IUserSERVICE türünden bir alan (field) tanımlandı.
        /// db adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        private int userId;
        private BeFitAppContext db;
        private IUserSERVICE _userService;

        /// <summary>       
        /// Parametreden gelen değerler bu sınıfın içinde kullanılması için bu formdaki değerlere atandı.
        ///  _userService = new UserSERVICE(db); _userService alanını, UserSERVICE sınıfından yeni bir örnek oluşturarak başlatır. Bu sınıfın yapıcı metoduna db parametresini geçirerek, veritabanı bağlantısını bu hizmet sınıfına iletmektedir.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="db"></param>

        public MemberInformation(int userId, BeFitAppContext db)
        {
            InitializeComponent();
            this.userId = userId;
            this.db = db;
            _userService = new UserSERVICE(db);
        }

        //TrainingLevel adlı enum türündeki tüm değerleri alır. Enum.GetValues metodu, belirtilen enum türündeki tüm değerleri bir dizi olarak döndürür.ComboBox'ın içine bu veriler atanır.
        private void MemberInformation_Load(object sender, EventArgs e)
        {
            cmbTrainingLevel.DataSource = Enum.GetValues(typeof(TrainingLevel));
        }

        //Girilen yaş ve boy değerlerine göre vücut kitle indeksi hesaplanır.
        private void btnBMI_Click_1(object sender, EventArgs e)
        {
            string weightText = txtWeight.Text;
            string heightText = txtHeight.Text;

            //kullanıcının girdiği kilo (weight) ve boy (height) değerlerinin doğru bir şekilde dönüştürülebilir (parselenebilir) float değerlere dönüşüp dönüşemediğini kontrol ediyor.
            //weightText ve heightText adlı metin değişkenlerine float türündeki weight ve height değişkenine dönüştürmeye çalışır. Bu işlem başarılı ise, weight ve height değişkeni dönüşen değeri alır. Bu sayede, kullanıcının kilo ve boy girişi doğru bir float değerine dönüşüyorsa, bu değeri kullanabiliriz.
            if (float.TryParse(weightText, out float weight) && float.TryParse(heightText, out float height) && weight > 0 && height > 0)
            {
                height = height / 100;
                float bmi = weight / (height * height);
                txtBMI.Text = bmi.ToString("0.00");
                if (bmi < 18.5)
                {
                    lblBodyMassIndex.Text = "Weak";
                    lblBodyMassIndex.ForeColor = Color.AliceBlue;
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    lblBodyMassIndex.Text = "Normal Weight";
                    lblBodyMassIndex.ForeColor = Color.Green;
                }
                else if (bmi >= 25.0 && bmi <= 29.9)
                {
                    lblBodyMassIndex.Text = "Overweight";
                    lblBodyMassIndex.ForeColor = Color.Brown;
                }
                else if (bmi >= 30.0 && bmi <= 34.9)
                {
                    lblBodyMassIndex.Text = "1st Degree Obese";
                    lblBodyMassIndex.ForeColor = Color.Aqua;
                }
                else if (bmi >= 35.0 && bmi <= 39.9)
                {
                    lblBodyMassIndex.Text = "2st Degree Obese";
                    lblBodyMassIndex.ForeColor = Color.DarkRed;
                }
                else
                    lblBodyMassIndex.Text = "Morbidly Obese";
                    lblBodyMassIndex.ForeColor = Color.Red;
            }
            else
            {
                txtBMI.Text = "Please enter valid numbers.";
            }
        }


        /// <summary>
        /// Continue butonuna basıldığında _userService üzerinden,GetById metot çağrısı ile kullanıcının kimliğine (userId) göre veritabanından kullanıcı bilgilerini alır. Eğer kullanıcı bulunursa, bu bilgiler userToUpdate adlı bir User nesnesine atanır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            User userToUpdate = _userService.GetById(this.userId);
            if (userToUpdate != null)
            {
                //Kullanıcının girdiği age,weight,height, BMI (Vücut Kitle Indeksi) ve traininglevel bilgilerini kontrol eder. Bu bilgiler geçerli sayılara dönüştürülebiliyorsa ve traininglevel başarıyla enum'a çevrilebiliyorsa,userToUpdate adlı user nesnesinin bilgilerine atanır.
                //UserToUpdate adlı user nesnesi kayıt olunca Status, Added olur.

                if (int.TryParse(txtAge.Text, out int age) && double.TryParse(txtHeight.Text, out double height) && double.TryParse(txtWeight.Text, out double weight) && double.TryParse(txtBMI.Text, out double bodymessIndex) && Enum.TryParse(cmbTrainingLevel.Text, out TrainingLevel trainingLevel))
                {
                    userToUpdate.Age = age;
                    userToUpdate.Height = height;
                    userToUpdate.Weight = weight;
                    userToUpdate.Status = Status.Added;
                    userToUpdate.TrainingLevel = trainingLevel;
                    userToUpdate.Gender = (Gender)(rbMan.Checked ? Gender.Male : Gender.Female);
                    userToUpdate.BodyMassIndex = bodymessIndex;
                    _userService.Update(userToUpdate);
                    db.SaveChanges();
                    //Kullanıcın girdiği bilgiler hatasız bir şekilde user nesnesine eklenirse MainScreen ekranı açılır ve bu form kapanır.
                    MainScreen frm5 = new MainScreen();
                    frm5.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter a valid age value.");
                }
            }
            else
            {
                MessageBox.Show("User not found!");
            }
            
        }
    }
}
