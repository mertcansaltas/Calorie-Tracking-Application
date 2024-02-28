using BeFit.SERVICE.Interfaces;
using BeFit_DATA.Concrete;
using BeFit_DATA.Enum;
using BeFit_REPO.Context;
using Microsoft.EntityFrameworkCore;
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
    public partial class MainScreen : Form
    {
        /// <summary>
        /// BeFitAppContext db :BeFitAppContext türünden bir değişken olan db oluşturulur. Bu değişken, veritabanı işlemleri için bir bağlam (context) sağlar.
        /// userId adlı bir tamsayı değişkeni tanımlanır. Bu değişkenin amacı, kullanıcının kimliğini (ID) takip etmektir.
        /// Properties.Settings.Default.RememberedEmail ifadesi ile RememberedEmail adlı ayar dosyasındaki hatırlanan e-posta adresi alınır ve rememberedEmail adlı bir string değişkenine atanır. Bu, kullanıcının önceki oturumundan hatırlanan e-posta adresini temsil eder.
        /// </summary>
        BeFitAppContext db;
        private int userId;
        string rememberedEmail = Properties.Settings.Default.RememberedEmail;
        public MainScreen()
        {
            InitializeComponent();
            db = new BeFitAppContext();  //BeFitAppContext türündeki veritabanı bağlamını oluşturur ve db değişkenine atar. Bu bağlam, veritabanı ile etkileşimde bulunmak için kullanılır.
        }

        /// <summary>
        /// Form yüklendiğinde belirli işlemleri gerçekleştirilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form5_Load(object sender, EventArgs e)
        {

            //DataGridView kontrolleri görünürlüğü başlangıçta false olarak ayarlanır. Bu kontroller, kategoriler, yiyecekler ve raporlar için tabloları göstermek amacıyla kullanılabilir.
            dgvCategories.Visible = false;
            dgvFoods.Visible = false;
            dgvReport.Visible = false;
            User user = db.Users.FirstOrDefault(u => u.UserMail == rememberedEmail); // Veritabanından, hatırlanan e-posta adresine (rememberedEmail) sahip olan kullanıcıyı bulur ve bu kullanıcıyı temsil eden bir User nesnesini user değişkenine atar.
            double BMR = 0;  // vücut kitle indeksi (BMR) ve  hesaplamak için kullanılacak  değişken tanımlanır ve başlangıçta sıfır olarak ayarlanır.
            double TargetCalorie = 0; //Hedef kalori miktarını hesaplamak için kullanılacak değişken tanımlanır ve başlangıçta sıfır olarak ayarlanır.

            //Kullanıcının cinsiyetine (Gender) bağlı olarak BMR hesaplaması yapılır. Eğer kullanıcı kadınsa, kadınlar için özel bir formül kullanılır; erkekse erkekler için özel bir formül kullanılır.
            if (user.Gender == Gender.Female) 
            {
                BMR = 88.362 + (13.397 * user.Weight) + (4.799 * user.Height) - (5.677 * user.Age);
            }
            else if (user.Gender == Gender.Male)
            {
                BMR = 447.593 + (9.247 * user.Weight) + (3.098 * user.Height) - (4.330 * user.Age);
            }

            // Kullanıcının antrenman seviyesine (TrainingLevel) bağlı olarak hedef kalori miktarı hesaplaması yapılır. Kullanıcının antrenman seviyesine göre farklı bir katsayı ile BMR çarpılarak hedef kalori miktarı belirlenir.
            if (user.TrainingLevel == TrainingLevel.Sedentary)
            {
                TargetCalorie = BMR * 1.2;
            }
            else if (user.TrainingLevel == TrainingLevel.ModeratelyActive)
            {
                TargetCalorie = BMR * 1.55;
            }
            else if (user.TrainingLevel == TrainingLevel.HighlyActive)
            {
                TargetCalorie = BMR * 1.9;
            }
            int TargetCalories = Convert.ToInt32(TargetCalorie);
            lblTargetCalorie.Text = TargetCalories.ToString();

           

        }

        /// <summary>
        /// DataGridView kontrolündeki hücrelerin biçimlendirilmesi olayını (CellFormatting event) işleyen bir metodunu içerir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvFoods.Columns["FoodName"].Index && e.RowIndex >= 0) //Eğer olayın tetiklendiği hücre, "FoodName" adlı sütunda ve bir satırın içinde yer alıyorsa, aşağıdaki işlemleri gerçekleştir.
            {
                int foodID = Convert.ToInt32(e.Value); // Hücrenin değeri (e.Value) alınarak bir tamsayıya dönüştürülür ve foodID adlı bir değişkene atanır. Bu değer, genellikle bir food u temsil eden bir kimlik (ID) değerini içerir.
                                                       
                var food = db.Foods.FirstOrDefault(f => f.ID == foodID);  //foodID'ye eşleşen bir Food nesnesini bulur. Bu, FoodID değerini kullanarak veritabanından ilgili yiyeceğin adını almak içindir.

                // Eğer veritabanında bir food bulunursa, hücrenin değeri Food nesnesinin adıyla (food.Name) değiştirilir. Bu sayede, FoodID değeri yerine food adı görüntülenir.
                if (food != null)
                {
                    e.Value = food.Name; 
                }
            }
        }

        private void dgvCategories_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvCategories.Columns["CategoryName"].Index && e.RowIndex >= 0) // Eğer olayın tetiklendiği hücre, "CategoryName" adlı sütunda ve bir satırın içinde yer alıyorsa, aşağıdaki işlemleri gerçekleştir.
            {
                int categoryID = Convert.ToInt32(e.Value); // Hücrenin değeri (e.Value), bir tamsayıya dönüştürülerek categoryID adlı bir değişkene atanır. Bu değer, bir kategori öğesini temsil eden bir kimlik (ID) değerini içerir.
             
                var category = db.Categories.FirstOrDefault(f => f.ID == categoryID); //Veritabanından, categoryID'ye eşleşen bir Category nesnesini bulur. Bu, CategoryID değerini kullanarak veritabanından ilgili kategorinin adını almak içindir.

                ///Eğer veritabanında bir category bulunursa, hücrenin değeri Category nesnesinin adıyla (category.Name) değiştirilir. Bu sayede, categoryID değeri yerine category adı görüntülenir.
                if (category != null)
                {
                    e.Value = category.Name; 
                }
            }
        }

        /// <summary>
        /// List butonuna basıldığında işlemler gerçekleştirilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnList_Click(object sender, EventArgs e)
        {
            //DataGridView kontrollerini görünür hale getirir.
            dgvFoods.Visible = true;
            dgvCategories.Visible = true;
            

            //Kullanıcının tüm tüketim kayıtlarını içeren bir liste oluşturur. Bu kayıtlar, kullanıcının belirli yiyecekleri ve kategorileri kaç kez tükettiğini içerir.
            var userFoods = db.UserFoods.ToList();
            if (userFoods != null) // Kullanıcının tüketim kayıtları varsa, aşağıdaki işlemleri gerçekleştirir.Yoksa uyarı verir.
            {

                //Kullanıcının favori yiyeceklerini belirlemek için GroupBy ve OrderByDescending işlemlerini kullanarak bir sorgu oluşturur. Bu sorgu, her yiyeceğin toplam tüketim sayısını içeren bir liste döndürür.
                var userFavoriteFoods = userFoods.
                    GroupBy(uf => uf.FoodID).
                    OrderByDescending(group => group.Count()).
                    Select(group => new
                    {
                        FoodName = group.Key,
                        Count = group.Sum(x => x.Quantity)
                    })
                    .ToList();

                //Kullanıcının favori kategorilerini belirlemek için benzer bir sorgu oluşturur. Bu sorgu, her kategorinin toplam tüketim sayısını içeren bir liste döndürür.
                var userFavoriteCategories = db.UserFoods
                    .GroupBy(uf => uf.Food.CategoryID)
                    .OrderByDescending(group => group.Count())
                    .Select(group => new
                    {
                        CategoryName = group.Key,
                        Count = group.Count()
                    })
                    .ToList();

                // Eğer kullanıcının en çok yenilen yiyecekleri ve kategorileri varsa, bu verileri dgvFoods ve dgvCategories adlı DataGridView kontrolüne bağlar. Aksi takdirde, bir uyarı mesajı gösterir.
                if (userFavoriteFoods.Any() && userFavoriteCategories.Any())
                {
                    dgvFoods.DataSource = userFavoriteFoods;
                    dgvCategories.DataSource = userFavoriteCategories;  
                }
                else
                    MessageBox.Show("No consumption record found.");
            }
            else
                MessageBox.Show("Please choose a food first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Meal Add butonuna basıldığında MealScreen formu açılır ve bu form kapanır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMealAdd_Click(object sender, EventArgs e)
        {
            MealScreen frm = new MealScreen();
            frm.Show();
            this.Hide();
        }

        double totalCalories = 0; // Toplam kalori miktarını saklamak için bir totalCalories değişkeni oluşturulur ve sıfıra ayarlanır.
        private void btnReport_Click(object sender, EventArgs e)
        {

            dgvReport.Visible = true; //dgvReport adlı DataGridView kontrolünü görünür hale getirir.

            User user = db.Users.FirstOrDefault(u => u.UserMail == rememberedEmail); //Hatırlanan e-posta adresine sahip kullanıcıyı veritabanından alır.

            // Eğer kullanıcı bulunamazsa, bir hata mesajı gösterir ve metodun geri kalanını işlemez.
            if (user == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            DateTime selectedDate = dtpreportDate.Value.Date; //dtpreportDate adlı DateTimePicker kontrolünden seçilen tarihi alır.

            //Kullanıcının belirli bir tarihte yediği yiyecekleri içeren bir rapor oluşturur. Bu rapor, Date, MealType, Food, Quantity, ve Calorie özelliklerini içeren bir liste döndürür.
            var report = db.UserFoods.Where(uf => uf.UserID == user.ID && uf.Date.Date == selectedDate).Select(uf => new
            {
                Date = uf.Date,
                Meal = uf.MealType,
                Food = uf.Food.Name,
                Quantity = uf.Quantity,
                Calorie = uf.Food.Calorie * uf.Quantity
            }).ToList();

            //DataGridView kontrolünün veri kaynağını temizler ve ardından yeni raporu bağlar. Bu sayede DataGridView, report isimli veri kaynağındaki bilgileri gösterecek şekilde güncellenir.
            dgvReport.DataSource = null;
            dgvReport.DataSource = report; 
            if (!report.Any()) //Eğer raporda hiç kayıt yoksa, kullanıcıya bir uyarı mesajı gösterilir ve metodun geri kalan kısmı işlenmez.
            {
                MessageBox.Show("No record found for the selected date.");
                return;
            }

          

            //DataGridView kontrolündeki sütun başlıklarını düzenler. Sırasıyla "Date", "Meal", "Food", "Quantity", ve "Calorie" olarak adlandırılır.
            dgvReport.Columns[0].HeaderText = "Date";
            dgvReport.Columns[1].HeaderText = "Meal";
            dgvReport.Columns[2].HeaderText = "Food";
            dgvReport.Columns[3].HeaderText = "Quantity";
            dgvReport.Columns[4].HeaderText = "Calorie";

            
            foreach (DataGridViewRow row in dgvReport.Rows) // DataGridView kontrolündeki her satırı tek tek döngü içinde ele alır.
            {
                if (row.Cells["Calorie"].Value != null) //Her satırın "Calorie" sütununda değer var mı diye kontrol eder. Eğer değer varsa, içeriye girer.
                {
                    double rowCalories = 0; //rowCalories adında bir double türünde değişken oluşturur ve sıfıra ayarlar. Bu değişken, her satırdaki "Calorie" değerini tutacak.
                    //"Calorie" sütunundaki değeri bir string'ten double türüne dönüştürmeye çalışır. Eğer başarılıysa, dönüştürülen değeri rowCalories değişkenine atar ve içeriye girer.
                    if (double.TryParse(row.Cells["Calorie"].Value.ToString(), out rowCalories))
                    {
                        totalCalories += rowCalories; // Dönüştürülen "Calorie" değerini, toplam kalori miktarına ekler. Bu adım, her satırdaki kalori miktarlarını toplamak için kullanılır.
                    }
                }
            }
            lblTotalCalorie.Text = totalCalories.ToString(); // Toplam kalori miktarını bir etiket kontrolü olan lblTotalCalorie'ye yazdırır. totalCalories değişkeni, önceki adımda hesaplanan toplam kalori miktarını içerir.
        }
    }
}


