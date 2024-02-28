using BeFit.SERVICE.Concrete;
using BeFit.SERVICE.Interfaces;
using BeFit_DATA.Concrete;
using BeFit_DATA.Enum;
using BeFit_REPO.Context;
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
using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace BeFitUi
{
    public partial class MealScreen : Form
    {
        /// <summary>
        /// IFoodSERVICE türünden bir alan (field) _userfoodservice tanımlandı.
        /// db adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        IFoodSERVICE _foodservice;
        IUserFoodSERVICE _userfoodservice;
        BeFitAppContext db;

        //public MealScreen(): Sınıfın yapıcı metodudur. Bu metodun içinde yapılacak işlemler, sınıfın bir örneği oluşturulduğunda otomatik olarak gerçekleşir.
        //db = new BeFitAppContext(); db alanını, BeFitAppContext sınıfından yeni bir örnek oluşturarak başlatır. Bu, bir veritabanı bağlantısını temsil eden bir nesnenin oluşturulması anlamına gelir.
        // _userfoodService = new UserFoodSERVICE(db); _userfoodService alanını, UserFoodERVICE sınıfından yeni bir örnek oluşturarak başlatır. Bu sınıfın yapıcı metoduna db parametresini geçirerek, veritabanı bağlantısını bu hizmet sınıfına iletmektedir.
        public MealScreen()
        {
            db = new BeFitAppContext();
            InitializeComponent();
            _foodservice = new FoodSERVICE(db);
            _userfoodservice = new UserFoodSERVICE(db);
        }
        DataGridViewCell selectedCell = null; // Seçilen hücreyi saklamak için bir değişken
        bool numericValueChanged = false; // Numeric Up Down'daki değer değişti mi?

        /// <summary>
        /// Form4 ekranı açıldığı anda tetiklenecek olaylar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_Load(object sender, EventArgs e)
        {
            lstFood.SelectedIndexChanged += lstFood_SelectedIndexChanged;
            nmrFood.ValueChanged += nmrFood_ValueChanged; //nmrFood adlı NumericUpDown kontrolünün değeri değiştiğinde tetiklenecek bir olay dinleyicisi (nmrFood_ValueChanged) atanır.

            //dgvBreakfast, dgvLunch ve dgvDinner adlı DataGridView kontrolleri için sütunları başlatan bir metot (InitializeDataGridViewColumns) çağrılır.
            InitializeDataGridViewColumns(dgvBreakfast);
            InitializeDataGridViewColumns(dgvLunch);
            InitializeDataGridViewColumns(dgvDinner);

            lstFood.Clear();
            lstFood.View = View.Details;  //lstFood kontrolünün detay görünümünü ayarlar.

            //lstFood kontrolü için Kolon isimleri verilerek kolonlar eklenir.
            lstFood.Columns.Add("Name", 150);
            lstFood.Columns.Add("Calorie", 150);
            lstFood.Columns.Add("Protein", 150);
            lstFood.Columns.Add("Carbohydrate", 150);
            lstFood.Columns.Add("Fat", 150);

            var resultfood = _foodservice.GetAll();  //_foodservice üzerinden tüm yiyecekleri getirir.
            foreach (var food in resultfood) //Her bir yiyeceği lstFood kontrolüne ekler.
            {
                ListViewItem lst = new ListViewItem();
                lst.Tag = food;
                lst.Text = food.Name;
                lst.SubItems.Add(food.Calorie.ToString());
                lst.SubItems.Add(food.Protein.ToString());
                lst.SubItems.Add(food.Carbohydrate.ToString());
                lst.SubItems.Add(food.Fat.ToString());
                lstFood.Items.Add(lst);
            }

            //dgvBreakfast, dgvLunch ve dgvDinner adlı DataGridView kontrolünü içeren bir dizi oluşturulur.
            DataGridView[] dataGridViews = new DataGridView[] { dgvBreakfast, dgvLunch, dgvDinner };

            foreach (DataGridView dgv in dataGridViews)  //Her bir DataGridView kontrolü için aşağıdaki olay dinleyicisi atanır:
            {
                //dgv.CellClick: Bir hücreye tıklandığında tetiklenecek olay dinleyicisidir.
                dgv.CellClick += (sender, cellEvent) =>
                {
                    if (cellEvent.RowIndex == -1 || cellEvent.ColumnIndex == -1) //Hücre tıklanılan hücre mi kontrol eder. Eğer tıklanan hücre boşsa uyarı verir ve işlemi sonlandırır.
                    {
                        MessageBox.Show("Please do not click on an empty area!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // İşlemi burada sonlandır
                    }
                    selectedCell = dgv.Rows[cellEvent.RowIndex].Cells[cellEvent.ColumnIndex]; //Tıklanan hücre bilgisini saklar.
                    if (selectedCell.OwningColumn.Name == "Quantity") // Tıklanan hücrenin sütun adını kontrol eder, eğer "Quantity" sütunu ise:
                    {
                        if (numericValueChanged) //Eğer numerik değeri değiştiyse (numericUpDown değeri), bu değeri seçilen hücreye atar ve toplam kaloriyi günceller.
                        {
                            // Adet değerini güncelle
                            selectedCell.Value = nmrFood.Value;
                            // Seçilen hücrenin adet değerini al
                            int quantity = (int)nmrFood.Value;
                            UpdateTotalCalories(selectedCell, quantity); // UpdateTotalCalories adlı metodu çağırır ve bu metoda, güncellenen hücrenin bilgisini (selectedCell) ve yeni miktar değerini (quantity) parametre olarak ileterek toplam kaloriyi güncellemesini sağlar.
                            numericValueChanged = false; //  Bu değişken, numericUpDown kontrolünün değerinin değiştiği için false olur.
                        }
                        else
                        {
                            nmrFood.Value = Convert.ToDecimal(selectedCell.Value); // Eğer numerik değeri değişmediyse, seçilen hücrenin değerini numerik değere atar.
                        }
                    }
                };
            }
            //"Update" butonuna tıklandığında tetiklenecek olay dinleyicisidir.
            btnUpdate.Click += btnUpdate_Click;
        }

        /// <summary>
        ///  Bu metot, toplam kaloriyi güncellemek için kullanılır. Parametre olarak bir miktar hücresini (quantityCell) ve yeni miktarı (newQuantity) alır.
        /// </summary>
        /// <param name="quantityCell"></param>
        /// <param name="newQuantity"></param>
        private void UpdateTotalCalories(DataGridViewCell quantityCell, int newQuantity)
        {
            var totalCaloriesCell = quantityCell.OwningRow.Cells["totalCalories"]; //totalCaloriesCell adlı bir hücre, quantityCell'in ait olduğu satırın "totalCalories" sütununu temsil eder.
            if (totalCaloriesCell != null && quantityCell.Value != null) // totalCaloriesCell ve quantityCell değerleri null değilse, güncelleme işlemini yap.
            {
           
                var selectedFoodItem = lstFood.SelectedItems[0];  //lstFood kontrolünden seçilen bir öğeyi temsil eden selectedFoodItem değişkeni oluşturulur.
                if (selectedFoodItem.Tag is Food selectedFood)  //selectedFoodItem'ın Tag i bir Food nesnesi ise, bu nesneyi temsil eden selectedFood değişkenini oluştur.
                {
                    int unitCalorie = (int)selectedFood.Calorie;  // selectedFood nesnesinden birim kalori değerini al
                    int newTotalCalories = unitCalorie * newQuantity; //Yeni toplam kaloriyi hesapla.
                    totalCaloriesCell.Value = newTotalCalories;  // totalCaloriesCell'in değerini yeni toplam kalori değeri ile güncelle.
                }
            }
        }
        /// <summary>
        /// Columns.Add metodu ile sütunlar eklenir, ve her bir sütunun adı (name) ve görünen başlığı (header text) belirlenir. 
        /// </summary>
        /// <param name="dataGridView"></param>
        private void InitializeDataGridViewColumns(DataGridView dataGridView)
        {
            dataGridView.Columns.Add("productName", "Food Name");
            dataGridView.Columns.Add("quantity", "Quantity");
            dataGridView.Columns.Add("totalCalories", "Total Calories");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Önceki seçimleri temizle
            dgvBreakfast.ClearSelection();
            dgvLunch.ClearSelection();
            dgvDinner.ClearSelection();

            // Eğer bir yiyecek seçilmişse devam et
            if (lstFood.SelectedItems.Count > 0)
            {
                // Seçilen öğeyi alır ve selectedItem değişkenine atar.
                ListViewItem selectedItem = lstFood.SelectedItems[0];
                Food selectedfood = selectedItem.Tag as Food;
                string foodName = selectedItem.SubItems[0].Text;  // Ürün adı ListView'de ilk sütunda varsayılıyor
                int foodCalorie = int.Parse(selectedItem.SubItems[1].Text); // Kalori miktarı ListView'de ikinci sütunda varsayılıyor
                int quantity = (int)nmrFood.Value; // NumericUpDown'tan alınan miktar
                int totalCalorie = foodCalorie * quantity; // Toplam kalori hesaplanıyor

                // Hangi RadioButton seçiliyse, ilgili DataGridView'e ürünü ve toplam kaloriyi ekle
                DataGridView seciliDataGridView = null;
                if (rbBreakfast.Checked)
                    seciliDataGridView = dgvBreakfast;
                else if (rbLunch.Checked)
                    seciliDataGridView = dgvLunch;
                else if (rbDinner.Checked)
                    seciliDataGridView = dgvDinner;
                else
                {
                    MessageBox.Show("Please Select a Meal");
                }
                if (seciliDataGridView != null)
                {
                    int index = seciliDataGridView.Rows.Add(); // DataGridView'e yeni bir satır ekleniyor
                    seciliDataGridView.Rows[index].Cells[0].Value = foodName; // Ürün adı
                    seciliDataGridView.Rows[index].Cells[1].Value = quantity; // Miktar
                    seciliDataGridView.Rows[index].Cells[2].Value = totalCalorie; // Toplam Kalori
                    string rememberedEmail = Properties.Settings.Default.RememberedEmail; // Kullanıcının hatırlanan e-posta adresini al
                    User user = db.Users.FirstOrDefault(u => u.UserMail == rememberedEmail);  // Veritabanından hatırlanan e-posta adresine sahip kullanıcıyı bul
                    UserFood newUserFood = new UserFood // Yeni bir UserFood nesnesi oluştur
                    {
                        UserID = user.ID,
                        FoodID = selectedfood.ID,
                        MealType = GetSelectedMealType(), // MealType'ı RadioButton'lardan alınan değer olarak ayarla
                        Quantity = quantity,
                        TotalCalorie = totalCalorie,
                        Name = foodName

                    };
                    Properties.Settings.Default.RememberedUserID = newUserFood.UserID; // Hatırlanan kullanıcı ID'sini kaydet
                    Properties.Settings.Default.Save();
                    db.UserFoods.Add(newUserFood); // UserFood nesnesini veritabanına ekle
                    db.SaveChanges();
                }
            }
            // Temizleme işlemleri
            txtFoodSearch.Clear();
            nmrFood.Value = 0;
            CalculateTotalCalorie();
        }

        /// <summary>
        /// Toplam kalorileri hesaplamak için kullanılan bir metodudur.
        /// </summary>
        private void CalculateTotalCalorie()
        {
            // Kahvaltı, öğle yemeği ve akşam yemeği için toplam kalorileri hesapla
            double totalDinnerCalories = CalculateTotalNutrientAmount(dgvDinner, "totalCalories");
            double totalLunchCalories = CalculateTotalNutrientAmount(dgvLunch, "totalCalories");
            double totalBreakfastCalories = CalculateTotalNutrientAmount(dgvBreakfast, "totalCalories");

            // Hesaplanan toplam kalorileri ilgili Label kontrolüne yaz
            lblSabahKalori.Text = totalBreakfastCalories.ToString();
            lblOglenKalori.Text = totalLunchCalories.ToString();
            lblAksamKAlori.Text = totalDinnerCalories.ToString();

            // Tüm öğünlerin toplam kalorisini hesapla ve bu miktarı başka bir Label kontrolüne yaz
            double totalOverallCalorie = totalBreakfastCalories + totalLunchCalories + totalDinnerCalories;
            lblToplam.Text = totalOverallCalorie.ToString();
        }

        /// <summary>
        /// Metodunun amacı, kullanıcının seçtiği öğün türüne (kahvaltı, öğle yemeği, akşam yemeği) bağlı olarak bir MealType enum değeri döndürmektir. 
        /// </summary>
        /// <returns></returns>
        private MealType GetSelectedMealType()
        {
            if (rbBreakfast.Checked)
                return MealType.Breakfast;   // Eğer kahvaltı seçiliyse, "Breakfast" MealType'ını döndür.
            else if (rbLunch.Checked)
                return MealType.Lunch;  // Öğle öğünü için
            else if (rbDinner.Checked)
                return MealType.Dinner;  // Akşam öğünü için
            else
            {
                return MealType.Lunch;
            }
        }


        private void txtFoodSearch_TextChanged(object sender, EventArgs e)
        {
            lstFood.Items.Clear();
            lstFood.Clear();
            lstFood.View = View.Details; // ListView kontrolünün görünümünü ayarla
            // ListView kontrolüne sütunları ekle
            lstFood.Columns.Add("Name", 150);
            lstFood.Columns.Add("Calorie", 150);
            lstFood.Columns.Add("Protein", 150);
            lstFood.Columns.Add("Carbohydrate", 150);
            lstFood.Columns.Add("Fat", 150);

            var searchlist = _foodservice.GetWhere(x => x.Name.Contains(txtFoodSearch.Text));  //GetWhere metodu, belirli bir koşulu sağlayan öğeleri getiren bir metot.GetWhere metodu ile girilen metni içeren yiyecekleri getir.

            // Her bir eşleşen yiyeceği ListView kontrolüne ekleyerek göster
            foreach (var item in searchlist)
            {
                ListViewItem lstsearch = new ListViewItem();
                lstsearch.Text = item.Name; // Yiyecek nesnesini Tag özelliği aracılığıyla sakla
                lstsearch.Tag = item;
                lstsearch.SubItems.Add(item.Calorie.ToString());
                lstsearch.SubItems.Add(item.Protein.ToString());
                lstsearch.SubItems.Add(item.Carbohydrate.ToString());
                lstsearch.SubItems.Add(item.Fat.ToString());
                lstFood.Items.Add(lstsearch);
            }
        }


        private int CalculateTotalNutrientAmount(DataGridView dgv, string foodColumnName)
        {
            int totalAmount = 0; //Toplam miktarı saklamak için bir değişken oluşturulur ve sıfıra ayarlanır.
            int foodIndex = GetColumnIndex(dgv, foodColumnName); // Verilen foodColumnName adlı sütunun DataGridView kontrolündeki indeksini GetColumnIndex metodu ile alır.
            if (foodIndex != -1)  // Eğer sütun indeksi -1 değilse (sütun bulunmuşsa), işlemlere devam eder.
            {
                for (int i = 0; i < dgv.Rows.Count; i++) // Her bir satır üzerinde döngü başlatılır.
                {
                    int amount = 0; //Her bir hücredeki değeri saklamak için bir amount değişkeni oluşturulur.

                    // Eğer hücrede değer varsa, bu değeri sayıya dönüştürmeye çalışır.
                    if (dgv.Rows[i].Cells[foodIndex].Value != null)
                    {
                        int.TryParse(dgv.Rows[i].Cells[foodIndex].Value.ToString(), out amount); //Hücredeki değeri sayıya dönüştürerek amount değişkenine atar.
                    }
                    totalAmount += amount; // Toplam miktarı günceller.

                }
            }
            return totalAmount; //Güncellenmiş toplam miktarı döndürür.
        }

        /// <summary>
        /// Bu  metodunun amacı, bir DataGridView kontrolündeki sütunların isimleriyle eşleşen bir sütunun indeksini bulmaktır. 
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        private int GetColumnIndex(DataGridView dgv, string columnName)
        {
            foreach (DataGridViewColumn column in dgv.Columns) //DataGridView kontrolündeki her bir sütun üzerinde bir döngü başlatır.
            {
                // Eğer sütun adı, aranan sütun adına eşitse (büyük/küçük harf duyarlılığı olmadan),o sütunun indeksini döndürür. StringComparison.OrdinalIgnoreCase, bir metin karşılaştırma işleminde büyük/küçük harf duyarlılığını göz ardı etmek için kullanılan bir String Karşılaştırma seçeneğidir.               
                if (column.Name.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return column.Index; //Eğer sütun adı eşleşiyorsa, o sütunun indeksini döndürür.
                }
            }
            return -1; //Eğer hiçbir eşleşme bulunamazsa, -1 değerini döndürür. Bu durum, aranan sütun adının bulunamadığını gösterir.
        }

        /// <summary>
        /// Main Page butonuna basıldığında MainScreen ekranı açılır ve bu form kapatılır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainScreen frm = new MainScreen();
            frm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCell != null && numericValueChanged) //Seçili hücre varsa ve numericValueChanged true ise devam et.
            {
                selectedCell.Value = nmrFood.Value; // Seçilen hücrenin değerini, numericUpDown kontrolündeki değerle güncelle.
                int newAmount = Convert.ToInt32(nmrFood.Value); //Yeni miktarı, numericUpDown kontrolündeki değerden al.     
                UpdateTotalCalories(selectedCell, newAmount); // Toplam kalori miktarını adete göre güncellemek için UpdateTotalCalories metodunu çağır.
                numericValueChanged = false; // Değişiklik işlendi, tekrar false yapın
                CalculateTotalCalorie(); // Toplam kalorileri güncellemek için CalculateTotalCalorie metodunu çağır.                               
                string foodName = selectedCell.OwningRow.Cells["productName"].Value?.ToString(); //Seçilen hücrenin içinden FoodName'i al.

                // FoodName'e göre UserFood nesnesini bul
                var selectedUserFood = db.UserFoods.FirstOrDefault(x => x.Name == foodName);

                if (selectedUserFood != null) //Eğer UserFood nesnesi bulunursa, aşağıdaki işlemleri gerçekleştir:
                {
                    selectedUserFood.Quantity = newAmount; //UserFood nesnesinin Quantity özelliğini güncelle.
                    _userfoodservice.Update(selectedUserFood); //UserFood nesnesini veritabanında güncellemek için _userfoodservice üzerinden Update metodunu çağır. Bu, seçilen yiyeceğin miktarının güncellenmesini sağlar.
                }

            }
        }

        /// <summary>
        /// Delete butonuna basıldığında, kullanıcının seçili bir hücreyi ve bu hücreye ait olan satırı silmesini sağlayan bir işlemi gerçekleştirir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridView> dataGridViews = new List<DataGridView> { dgvBreakfast, dgvLunch, dgvDinner }; //İşlem yapılacak olan DataGridView kontrol listesini oluşturulur.
            bool anyDataGridViewSelected = false; // Herhangi bir DataGridView'in seçilip seçilmediğini kontrol etmek için bir anyDataGridViewSelected değişkeni tanımlandı ve başlangıçta false olarak ayarlandı.

            foreach (DataGridView dgv in dataGridViews) //DataGridView kontrol listesinde dönülerek her bir DataGridView için aşağıdaki işlemler gerçekleştiriliyor.
            {
                if (selectedCell != null && selectedCell.DataGridView == dgv) //Eğer kullanıcı bir hücre seçmişse ve bu hücre, işlem yapılmak istenen DataGridView'e aitse, aşağıdaki işlemler gerçekleştirilir.
                {
                    anyDataGridViewSelected = true; //Herhangi bir DataGridView'in seçildiğini belirten anyDataGridViewSelected değişkeni true olarak ayarlanır.
                    var selectedRow = selectedCell.OwningRow;  //Seçilen hücreye ait olan satır alınır.

                    if (selectedRow != null)
                    {
                        string foodName = selectedCell.OwningRow.Cells["productName"].Value?.ToString(); //Seçilen satırdaki "productName" sütunundaki değeri alarak `foodName` değişkenine atanır.
                        var selectedUserFood = db.UserFoods.FirstOrDefault(x => x.Name == foodName); //foodName değerine göre veritabanında ilgili UserFood nesnesi aranır ve selectedUserFood değişkenine atanır.
                        if (selectedUserFood != null)  //Eğer ilgili UserFood nesnesi bulunursa, aşağıdaki işlemler gerçekleştirilir.
                        {
                            _userfoodservice.Delete(selectedUserFood); //userFoodService sınıfındaki `Delete` metodu kullanılarak ilgili UserFood nesnesi silinir.
                        }
                        dgv.Rows.Remove(selectedRow); //DataGridView üzerinden seçilen satır silinir.


                    }
                }
            }
            if (!anyDataGridViewSelected)  //Eğer hiçbir DataGridView seçilmediyse, kullanıcıya bir uyarı mesajı gösterilir.
            {
                MessageBox.Show("Please select the row to be deleted.");
            }

            selectedCell = null; //  Seçili hücreyi null yaparak herhangi bir seçili hücrenin olmadığını belirtir.
            // Tüm DataGridView kontrolerindeki seçimleri temizler, bu sayede hiçbir satırın seçili olmadığından emin olunur.

        }

        /// <summary>
        /// NumericUpDown kontrolünün değeri değiştiğinde tetiklenecek olan bir olay (event) yöneticisidir. Bu metodun amacı, NumericUpDown kontrolündeki değer değiştiğinde gerçekleşecek işlemleri içermektir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nmrFood_ValueChanged(object sender, EventArgs e)
        {
            numericValueChanged = true; //NumericUpDown kontrolündeki değer değiştikçe numericValueChanged değişkenini true olarak ayarlar.
        }
        Food selectedFood;
        private void lstFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFood.SelectedItems.Count > 0) // Seçili öğe varsa
            {
                selectedFood = (Food)lstFood.SelectedItems[0].Tag; // Seçili öğenin Tag'inden Food nesnesini alır.
                if (selectedFood != null && !string.IsNullOrEmpty(selectedFood.Picture))
                {
                    if (File.Exists(selectedFood.Picture)) // Eğer dosya mevcutsa
                    {
                        try
                        {
                            pbfoodPicture.Image = Image.FromFile(selectedFood.Picture); // Resmi PictureBox'a yükle
                            pbfoodPicture.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi uygun şekilde boyutlandır
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Resim dosyası bulunamadı.");
                        pbfoodPicture.Image = null; // Eğer resim dosyası yoksa, PictureBox'ı temizle
                    }
                }
                else
                {
                    pbfoodPicture.Image = null; // Eğer Food nesnesinde resim yoksa, PictureBox'ı temizle
                }
            }
        }
    }

}