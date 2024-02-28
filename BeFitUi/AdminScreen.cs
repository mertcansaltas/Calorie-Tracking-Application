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
    public partial class AdminScreen : Form
    {
        /// <summary>        
        /// IUserSERVICE türünden bir _userservice alan (field) tanımlandı.
        /// IFoodSERVICE türünden bir _foodservice alan (field) tanımlandı.
        /// ICategorySERVICE türünden bir _categoryservice alan (field) tanımlandı.
        /// db adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        IUserSERVICE _userservice;
        IFoodSERVICE _foodservice;
        ICategorySERVICE _categoryservice;
        BeFitAppContext db;
        /// <summary>
        ///  public AdminScreen(): Sınıfın yapıcı metodudur. Bu metodun içinde yapılacak işlemler, sınıfın bir örneği oluşturulduğunda otomatik olarak gerçekleşir.
        ///  db = new BeFitAppContext(); db alanını, BeFitAppContext sınıfından yeni bir örnek oluşturarak başlatır. Bu, bir veritabanı bağlantısını temsil eden bir nesnenin oluşturulması anlamına gelir.
        ///  _foodService = new FoodSERVICE(db); _foodService alanını, FoodSERVICE sınıfından yeni bir örnek oluşturarak başlatır. Bu sınıfın yapıcı metoduna db parametresini geçirerek, veritabanı bağlantısını bu hizmet sınıfına iletmektedir.        
        /// </summary>
        public AdminScreen()
        {
            InitializeComponent();
            db = new BeFitAppContext();
            _userservice = new UserSERVICE(db);
            _foodservice = new FoodSERVICE(db);
            _categoryservice = new CategorySERVICE(db);
        }

        /// <summary>
        /// Database de ki kategorilerin isimleri comboboxa eklendi.
        /// Form açıldığında combobox da seçili bir değer görülmeyecek.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            cmbGetByCategories.DataSource = db.Categories.Select(x => x.Name).ToList();
            lstList.View = View.Details;
            cmbGetByCategories.SelectedIndex = -1;
            lstList.Columns.Clear();
            lstList.FullRowSelect = true;
        }

        /// <summary>
        /// Bir kaç ayrı yerden besinler çağrıldığı için GetAllFoods adında parametreye sahip olan bir metot yapıldı.Kolonlara isim verilerek kolonlar oluşturuldu.Aynı zamanda food bilgileri listviewa eklendi.
        /// </summary>
        /// <param name="foodList"></param>
        public void GetAllFoods(List<Food> foodList)
        {
            lstList.Clear();
            lstList.Columns.Add("ID", 50); // Genişlik 50
            lstList.Columns.Add("Name", 250);
            lstList.Columns.Add("Portion Type", 150);
            lstList.Columns.Add("Calorie", 100);
            lstList.Columns.Add("Fat", 100);
            lstList.Columns.Add("Protein", 100);
            lstList.Columns.Add("Carbohydrate", 100);
            lstList.Columns.Add("CategoryID", 100);
            lstList.Columns.Add("Picture", 100);
            foreach (var food in foodList)
            {
                ListViewItem lstfood = new ListViewItem();
                lstfood.Tag = food;
                lstfood.Text = food.ID.ToString();
                lstfood.SubItems.Add(food.Name);
                lstfood.SubItems.Add(food.PortionType.ToString());
                lstfood.SubItems.Add(food.Calorie.ToString());
                lstfood.SubItems.Add(food.Fat.ToString());
                lstfood.SubItems.Add(food.Protein.ToString());
                lstfood.SubItems.Add(food.Carbohydrate.ToString());
                lstfood.SubItems.Add(food.CategoryID.ToString());
                lstList.Items.Add(lstfood);
            }
        }

        bool isFoodClick;
        /// <summary>
        /// GetAllFoods butonuna basıldığında Service de ki GetAll metodu ile tüm yiyecekler getirilir.       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetallFoods_Click(object sender, EventArgs e)
        {
            isFoodClick = true;
            isCategoryClick = false;
            List<Food> resultfood = _foodservice.GetAll();
            GetAllFoods(resultfood);  //GetAllFoods metodu çağrılarak tüm yiyecekler listviewe eklendi.
        }

        /// <summary>
        /// Service den gelen GetWhere metodu ile çağrılan food nesnelerin adları textboxa yazdığımız metni içeriyorsa o nesne getirilir ve searchlist değişkenine atanır.GetAllFoods methodunun içerisine parametre olarak yazılır ve bu nesnenin bilgisi listviewa eklenir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            List<Food> searchlist = _foodservice.GetWhere(x => x.Name.Contains(txtSearch.Text));
            GetAllFoods(searchlist);
        }

        bool isCategoryClick;
        private void btnGetAllCategories_Click(object sender, EventArgs e)
        {
            GetAllCategories();
        }

        /// <summary>
        /// Kolonlara isim verilerek kolonlar oluşturuldu.Aynı zamanda category bilgileri listviewa eklendi.
        /// </summary>
        public void GetAllCategories()
        {
            isFoodClick = false;
            isCategoryClick = true;
            lstList.Clear();
            lstList.Columns.Add("ID", 50); // Genişlik 50
            lstList.Columns.Add("Name", 150); // Genişlik 150
            var resultcategories = _categoryservice.GetAll();
            foreach (var category in resultcategories)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = category.ID.ToString();
                lst.SubItems.Add(category.Name);
                lst.Tag = category;
                lstList.Items.Add(lst);
            }
        }

        /// <summary>
        /// Kolonlara isim verilerek kolonlar oluşturuldu.Service den gelen GetAll methodunu kullanarak user kullanıcılarını çağırdık.Aynı zamanda user bilgileri listviewa eklendi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetAllUsers_Click(object sender, EventArgs e)
        {
            lstList.Clear();
            lstList.Columns.Add("ID", 50);
            lstList.Columns.Add("Name", 100);
            lstList.Columns.Add("LastName", 100);
            lstList.Columns.Add("Password", 100);
            lstList.Columns.Add("UserMail", 220);
            lstList.Columns.Add("Phone", 100);
            lstList.Columns.Add("Weight", 80);
            lstList.Columns.Add("Height", 80);
            lstList.Columns.Add("Age", 50);
            lstList.Columns.Add("Gender", 100);
            lstList.Columns.Add("Status", 100);
            lstList.Columns.Add("TrainingLevel", 100);
            lstList.Columns.Add("CreatedDate", 100);
            lstList.Columns.Add("DeletedDate", 150);
            lstList.Columns.Add("BodyMassIndex", 150);

            var resultusers = _userservice.GetAll();
            foreach (var user in resultusers)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = user.ID.ToString();
                lst.SubItems.Add(user.Name);
                lst.SubItems.Add(user.LastName);
                lst.SubItems.Add(user.Password);
                lst.SubItems.Add(user.UserMail);
                lst.SubItems.Add(user.Phone);
                lst.SubItems.Add(user.Weight.ToString());
                lst.SubItems.Add(user.Height.ToString());
                lst.SubItems.Add(user.Age.ToString());
                lst.SubItems.Add(user.Gender.ToString());
                lst.SubItems.Add(user.Status.ToString());
                lst.SubItems.Add(user.TrainingLevel.ToString());
                lst.SubItems.Add(user.CreatedDate.ToString());
                lst.SubItems.Add(user.DeletedDate.ToString());
                lst.SubItems.Add(user.BodyMassIndex.ToString());
                lstList.Tag = user;
                lstList.Items.Add(lst);
            }
        }

        /// <summary>
        /// Comboboxtan seçilen kategori değeri selectedCategoryName değişkenine atanır.Bu kategori adına sahip olan yiyeceklerin id ve isim bilgisi ekrana getirilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGetByCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstList.Items.Clear();
            lstList.Columns.Clear();
            string selectedCategoryName = cmbGetByCategories.SelectedItem?.ToString();
            lstList.Columns.Add("ID", 50);
            lstList.Columns.Add("Name", 250);
            var list = db.Foods
            .Where(x => x.Category.Name == selectedCategoryName)
                 .Select(x => new
                 {
                     ID = x.ID,
                     Name = x.Name
                 })
                 .ToList();
            foreach (var item in list)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = item.ID.ToString();
                lst.SubItems.Add(item.Name.ToString());
                lstList.Items.Add(lst);
            }
        }

        Food selectedFood;
        Category selectedCategory;
        /// <summary>
        /// Listeden ürün veya kategori seçtiğimde listedeki ürün ve kategori bilgileri ilgili textboxlara doldu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstList_DoubleClick(object sender, EventArgs e)
        {
            if (isFoodClick == true)
            {
                foreach (var item in gbCreateCategory.Controls)
                {
                    if (item is Button)
                    {
                        Button btn = item as Button;
                        btn.Enabled = false;
                    }
                }
                foreach (var item in gbCreateFood.Controls)
                {
                    if (item is Button)
                    {
                        Button btn = item as Button;
                        btn.Enabled = true;
                    }
                }
                btnAddFood.Enabled = false;
                selectedFood = (Food)lstList.SelectedItems[0].Tag;
                txtFoodName.Text = selectedFood.Name;
                txtPortionType.Text = selectedFood.PortionType.ToString();
                txtCalorie.Text = selectedFood.Calorie.ToString();
                txtFat.Text = selectedFood.Fat.ToString();
                txtProtein.Text = selectedFood.Protein.ToString();
                txtCarbohydrate.Text = selectedFood.Carbohydrate.ToString();
                txtCategoryID.Text = selectedFood.CategoryID.ToString();
                selectedFood = (Food)lstList.SelectedItems[0].Tag;
                if (selectedFood != null)
                {
                    txtFoodName.Text = selectedFood.Name;
                    // ... (Diğer Food özelliklerinin atamaları)

                    // Eğer seçilen Food nesnesinin bir resmi varsa, PictureBox'ta göster
                    if (!string.IsNullOrEmpty(selectedFood.Picture))
                    {
                        pbPictureFood.Image = Image.FromFile(selectedFood.Picture);
                        pbPictureFood.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pbPictureFood.Image = null;
                    }
                }
            }
            else if (isCategoryClick == true)
            {
                foreach (var item in gbCreateFood.Controls)
                {
                    if (item is Button)
                    {
                        Button btn = item as Button;
                        btn.Enabled = false;
                    }
                }
                foreach (var item in gbCreateCategory.Controls)
                {
                    if (item is Button)
                    {
                        Button btn = item as Button;
                        btn.Enabled = true;
                    }
                }
                btnAddCategory.Enabled = false;
                selectedCategory = (Category)lstList.SelectedItems[0].Tag;
                txtCategoryName.Text = selectedCategory.Name;
            }
        }

        /// <summary>
        /// gbCreateFood,içerisindeki textboxların hepsi doluysa ekleme işlemini başarıyla yapar.Eğer değilse uyarı mesajı verilecek.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            bool AllFilesFilled = true;
            foreach (Control item in gbCreateFood.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        AllFilesFilled = false;
                        break;
                    }
                }
            }
            if (!AllFilesFilled)
            {
                MessageBox.Show("Please fill out all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Food newFood = new Food();
                newFood.Name = txtFoodName.Text;
                newFood.PortionType = (PortionType)Enum.Parse(typeof(PortionType), txtPortionType.Text, true);
                newFood.Calorie = Convert.ToDouble(txtCalorie.Text);
                newFood.Fat = Convert.ToDouble(txtFat.Text);
                newFood.Protein = Convert.ToDouble(txtProtein.Text);
                newFood.Carbohydrate = Convert.ToDouble(txtCarbohydrate.Text);
                newFood.CategoryID = Convert.ToInt32(txtCategoryID.Text);
                db.Foods.Add(newFood);
                Methods.Clear(this.Controls);
                db.SaveChanges();
                List<Food> revision = _foodservice.GetAll();
                GetAllFoods(revision);
                MessageBox.Show("New Food Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        ///Update butonuna basıldığıda TextBoxlara gelen değerlerin bilgilerini değiştirdiğim değerler ile güncelleme işlemi yapar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItems.Count == 0)
                MessageBox.Show("Please select an item first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                selectedFood.Name = txtFoodName.Text;
                selectedFood.PortionType = (PortionType)Enum.Parse(typeof(PortionType), txtPortionType.Text, true);
                selectedFood.Calorie = Convert.ToDouble(txtCalorie.Text);
                selectedFood.Fat = Convert.ToDouble(txtFat.Text);
                selectedFood.Protein = Convert.ToDouble(txtProtein.Text);
                selectedFood.Carbohydrate = Convert.ToDouble(txtCarbohydrate.Text);
                selectedFood.CategoryID = Convert.ToInt32(txtCategoryID.Text);
                // Eğer bir resim seçildiyse, seçilen resmin yolunu Food nesnesinin Picture özelliğine atayın
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    selectedFood.Picture = selectedImagePath;
                }
                _foodservice.Update(selectedFood);
                Methods.Clear(this.Controls);
                List<Food> revision = _foodservice.GetAll();
                GetAllFoods(revision);
                MessageBox.Show("Food Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnAddFood.Enabled = true;
        }

        /// <summary>
        /// DeleteFood butonu ile Listeden bir satır seçmişsem seçtiğim satırı siler ve tekrar GetAllFoods methodu ile tüm ürünleri listeler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItems.Count == 0)
                MessageBox.Show("Please select an item first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                _foodservice.Delete(selectedFood);
                List<Food> revision = _foodservice.GetAll();
                Methods.Clear(this.Controls);
                GetAllFoods(revision);
                MessageBox.Show("Food Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// gbCreateCategory,içerisindeki textbox doluysa yeni bir kategori ismi oluşturulur ekleme işlemini başarıyla yapar.GetAllCategories methodu ile tekrar kategori listelenir.Eğer değilse uyarı mesajı verilecek.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            bool AllFilesFilled = true;
            foreach (Control item in gbCreateCategory.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        AllFilesFilled = false;
                        break;
                    }
                }
            }
            if (!AllFilesFilled)
            {
                MessageBox.Show("Please fill out all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Category newCategory = new Category();
                newCategory.Name = txtCategoryName.Text;
                _categoryservice.Add(newCategory);
                Methods.Clear(this.Controls);
                GetAllCategories();
                MessageBox.Show("New Category Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// UpdateCategory butonuna bastığımda listeden bir satır seçmişsem txtCategory de yazdığım categoryi seçtiğim satırın categoryname ine atar ve günceller.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItems.Count > 0)
            {
                selectedCategory.Name = txtCategoryName.Text;
                _categoryservice.Update(selectedCategory);
                Methods.Clear(this.Controls);
                GetAllCategories();
                MessageBox.Show("Category Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select an item first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnAddCategory.Enabled = true;
        }

        /// <summary>
        /// DeleteCtegory butonu ile Listeden bir satır seçmişsem seçtiğim satırı siler ve tekrar GetAllCategory methodu ile tüm kategorileri listeler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItems.Count > 0)
            {
                _categoryservice.Delete(selectedCategory);
                Methods.Clear(this.Controls);
                GetAllCategories();
                MessageBox.Show("Category Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select an item first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // Yeni bir alan tanımla. Bu, seçilen resmin yolunu tutacak.
        private string selectedImagePath = string.Empty;

        private void btnAdd_picture_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedItems.Count > 0)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Resim Seç";
                    ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pbPictureFood.SizeMode = PictureBoxSizeMode.StretchImage;
                        // Resmi PictureBox'a yükleyin
                        pbPictureFood.Image = new Bitmap(ofd.FileName);

                        // Seçilen resmin yolunu kaydet
                        selectedImagePath = ofd.FileName;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please pick a food");
            }
        }
    }
}