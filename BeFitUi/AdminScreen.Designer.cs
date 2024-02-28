namespace BeFitUi
{
    partial class AdminScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstList = new ListView();
            gbCreateFood = new GroupBox();
            btnAdd_picture = new Button();
            label10 = new Label();
            label9 = new Label();
            btnDeleteFood = new Button();
            txtFoodName = new TextBox();
            btnUpdateFood = new Button();
            label8 = new Label();
            btnAddFood = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPicture = new TextBox();
            txtCategoryID = new TextBox();
            txtCarbohydrate = new TextBox();
            txtProtein = new TextBox();
            txtFat = new TextBox();
            txtCalorie = new TextBox();
            txtPortionType = new TextBox();
            pbPictureFood = new PictureBox();
            btnGetallFoods = new Button();
            btnGetAllCategories = new Button();
            btnGetAllUsers = new Button();
            cmbGetByCategories = new ComboBox();
            label1 = new Label();
            txtSearch = new TextBox();
            gbCreateCategory = new GroupBox();
            btnDeleteCategory = new Button();
            label2 = new Label();
            btnUpdateCategory = new Button();
            txtCategoryName = new TextBox();
            btnAddCategory = new Button();
            gbCreateFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPictureFood).BeginInit();
            gbCreateCategory.SuspendLayout();
            SuspendLayout();
            // 
            // lstList
            // 
            lstList.Dock = DockStyle.Bottom;
            lstList.Location = new Point(0, 469);
            lstList.Name = "lstList";
            lstList.Size = new Size(1307, 224);
            lstList.TabIndex = 0;
            lstList.UseCompatibleStateImageBehavior = false;
            lstList.DoubleClick += lstList_DoubleClick;
            // 
            // gbCreateFood
            // 
            gbCreateFood.BackColor = Color.Transparent;
            gbCreateFood.Controls.Add(btnAdd_picture);
            gbCreateFood.Controls.Add(label10);
            gbCreateFood.Controls.Add(label9);
            gbCreateFood.Controls.Add(btnDeleteFood);
            gbCreateFood.Controls.Add(txtFoodName);
            gbCreateFood.Controls.Add(btnUpdateFood);
            gbCreateFood.Controls.Add(label8);
            gbCreateFood.Controls.Add(btnAddFood);
            gbCreateFood.Controls.Add(label7);
            gbCreateFood.Controls.Add(label6);
            gbCreateFood.Controls.Add(label5);
            gbCreateFood.Controls.Add(label4);
            gbCreateFood.Controls.Add(label3);
            gbCreateFood.Controls.Add(txtPicture);
            gbCreateFood.Controls.Add(txtCategoryID);
            gbCreateFood.Controls.Add(txtCarbohydrate);
            gbCreateFood.Controls.Add(txtProtein);
            gbCreateFood.Controls.Add(txtFat);
            gbCreateFood.Controls.Add(txtCalorie);
            gbCreateFood.Controls.Add(txtPortionType);
            gbCreateFood.Controls.Add(pbPictureFood);
            gbCreateFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbCreateFood.ForeColor = Color.Black;
            gbCreateFood.Location = new Point(280, 11);
            gbCreateFood.Name = "gbCreateFood";
            gbCreateFood.Size = new Size(632, 439);
            gbCreateFood.TabIndex = 1;
            gbCreateFood.TabStop = false;
            gbCreateFood.Text = "Create Food";
            // 
            // btnAdd_picture
            // 
            btnAdd_picture.Location = new Point(250, 397);
            btnAdd_picture.Name = "btnAdd_picture";
            btnAdd_picture.Size = new Size(36, 30);
            btnAdd_picture.TabIndex = 9;
            btnAdd_picture.Text = "...";
            btnAdd_picture.UseVisualStyleBackColor = true;
            btnAdd_picture.Click += btnAdd_picture_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(22, 55);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 7;
            label10.Text = "Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(20, 397);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 2;
            label9.Text = "Picture:";
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = Color.Transparent;
            btnDeleteFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteFood.ForeColor = Color.Black;
            btnDeleteFood.Location = new Point(386, 374);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(112, 50);
            btnDeleteFood.TabIndex = 8;
            btnDeleteFood.Text = "Delete Food";
            btnDeleteFood.UseVisualStyleBackColor = false;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(128, 55);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.PlaceholderText = "Name";
            txtFoodName.Size = new Size(125, 30);
            txtFoodName.TabIndex = 6;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.BackColor = Color.Transparent;
            btnUpdateFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateFood.ForeColor = Color.Black;
            btnUpdateFood.Location = new Point(386, 306);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(112, 50);
            btnUpdateFood.TabIndex = 7;
            btnUpdateFood.Text = "Update Food";
            btnUpdateFood.UseVisualStyleBackColor = false;
            btnUpdateFood.Click += btnUpdateFood_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 350);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 2;
            label8.Text = "Category ID:";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Transparent;
            btnAddFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.ForeColor = Color.Black;
            btnAddFood.Location = new Point(386, 227);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(112, 50);
            btnAddFood.TabIndex = 6;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(20, 296);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 2;
            label7.Text = "Carbohydrate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 250);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 2;
            label6.Text = "Protein:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(20, 201);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 2;
            label5.Text = "Fat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 156);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 2;
            label4.Text = "Calorie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 108);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Portion Type:";
            // 
            // txtPicture
            // 
            txtPicture.Location = new Point(128, 397);
            txtPicture.Name = "txtPicture";
            txtPicture.PlaceholderText = "Picture";
            txtPicture.Size = new Size(125, 30);
            txtPicture.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(128, 350);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.PlaceholderText = "Category ID";
            txtCategoryID.Size = new Size(125, 30);
            txtCategoryID.TabIndex = 1;
            // 
            // txtCarbohydrate
            // 
            txtCarbohydrate.Location = new Point(128, 296);
            txtCarbohydrate.Name = "txtCarbohydrate";
            txtCarbohydrate.PlaceholderText = "Carbohydrate";
            txtCarbohydrate.Size = new Size(125, 30);
            txtCarbohydrate.TabIndex = 1;
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(128, 250);
            txtProtein.Name = "txtProtein";
            txtProtein.PlaceholderText = "Protein";
            txtProtein.Size = new Size(125, 30);
            txtProtein.TabIndex = 1;
            // 
            // txtFat
            // 
            txtFat.Location = new Point(128, 201);
            txtFat.Name = "txtFat";
            txtFat.PlaceholderText = "Fat";
            txtFat.Size = new Size(125, 30);
            txtFat.TabIndex = 1;
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(128, 156);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.PlaceholderText = "Calorie";
            txtCalorie.Size = new Size(125, 30);
            txtCalorie.TabIndex = 1;
            // 
            // txtPortionType
            // 
            txtPortionType.Location = new Point(128, 108);
            txtPortionType.Name = "txtPortionType";
            txtPortionType.PlaceholderText = "Portion Type";
            txtPortionType.Size = new Size(125, 30);
            txtPortionType.TabIndex = 1;
            // 
            // pbPictureFood
            // 
            pbPictureFood.Location = new Point(305, 7);
            pbPictureFood.Name = "pbPictureFood";
            pbPictureFood.Size = new Size(237, 204);
            pbPictureFood.TabIndex = 0;
            pbPictureFood.TabStop = false;
            // 
            // btnGetallFoods
            // 
            btnGetallFoods.BackColor = Color.Transparent;
            btnGetallFoods.BackgroundImageLayout = ImageLayout.Zoom;
            btnGetallFoods.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetallFoods.ForeColor = Color.Black;
            btnGetallFoods.Location = new Point(12, 11);
            btnGetallFoods.Name = "btnGetallFoods";
            btnGetallFoods.Size = new Size(204, 44);
            btnGetallFoods.TabIndex = 2;
            btnGetallFoods.Tag = "1";
            btnGetallFoods.Text = "Get All Foods";
            btnGetallFoods.UseVisualStyleBackColor = false;
            btnGetallFoods.Click += btnGetallFoods_Click;
            // 
            // btnGetAllCategories
            // 
            btnGetAllCategories.BackColor = Color.Transparent;
            btnGetAllCategories.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetAllCategories.ForeColor = SystemColors.ActiveCaptionText;
            btnGetAllCategories.Location = new Point(12, 101);
            btnGetAllCategories.Name = "btnGetAllCategories";
            btnGetAllCategories.Size = new Size(204, 44);
            btnGetAllCategories.TabIndex = 2;
            btnGetAllCategories.Text = "Get All Categories";
            btnGetAllCategories.UseVisualStyleBackColor = false;
            btnGetAllCategories.Click += btnGetAllCategories_Click;
            // 
            // btnGetAllUsers
            // 
            btnGetAllUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGetAllUsers.Location = new Point(12, 194);
            btnGetAllUsers.Name = "btnGetAllUsers";
            btnGetAllUsers.Size = new Size(204, 44);
            btnGetAllUsers.TabIndex = 2;
            btnGetAllUsers.Text = "Get All Users";
            btnGetAllUsers.UseVisualStyleBackColor = true;
            btnGetAllUsers.Click += btnGetAllUsers_Click;
            // 
            // cmbGetByCategories
            // 
            cmbGetByCategories.FormattingEnabled = true;
            cmbGetByCategories.Location = new Point(12, 303);
            cmbGetByCategories.Name = "cmbGetByCategories";
            cmbGetByCategories.Size = new Size(204, 28);
            cmbGetByCategories.TabIndex = 3;
            cmbGetByCategories.SelectedIndexChanged += cmbGetByCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 268);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 4;
            label1.Text = "Get By Categories";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 361);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(204, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // gbCreateCategory
            // 
            gbCreateCategory.BackColor = Color.Transparent;
            gbCreateCategory.Controls.Add(btnDeleteCategory);
            gbCreateCategory.Controls.Add(label2);
            gbCreateCategory.Controls.Add(btnUpdateCategory);
            gbCreateCategory.Controls.Add(txtCategoryName);
            gbCreateCategory.Controls.Add(btnAddCategory);
            gbCreateCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gbCreateCategory.Location = new Point(937, 11);
            gbCreateCategory.Name = "gbCreateCategory";
            gbCreateCategory.Size = new Size(317, 439);
            gbCreateCategory.TabIndex = 2;
            gbCreateCategory.TabStop = false;
            gbCreateCategory.Text = "Create Category";
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.BackColor = Color.Transparent;
            btnDeleteCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCategory.ForeColor = Color.Black;
            btnDeleteCategory.Location = new Point(118, 306);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(112, 50);
            btnDeleteCategory.TabIndex = 8;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.BackColor = Color.Transparent;
            btnUpdateCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCategory.ForeColor = Color.Black;
            btnUpdateCategory.Location = new Point(118, 227);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(112, 50);
            btnUpdateCategory.TabIndex = 7;
            btnUpdateCategory.Text = "Update Category";
            btnUpdateCategory.UseVisualStyleBackColor = false;
            btnUpdateCategory.Click += btnUpdateCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(103, 77);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "Name";
            txtCategoryName.Size = new Size(152, 30);
            txtCategoryName.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.Transparent;
            btnAddCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCategory.ForeColor = Color.Black;
            btnAddCategory.Location = new Point(118, 156);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(112, 50);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1307, 693);
            Controls.Add(gbCreateCategory);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(cmbGetByCategories);
            Controls.Add(btnGetAllCategories);
            Controls.Add(btnGetAllUsers);
            Controls.Add(btnGetallFoods);
            Controls.Add(gbCreateFood);
            Controls.Add(lstList);
            Name = "AdminScreen";
            Text = "Admin Form";
            Load += Form3_Load;
            gbCreateFood.ResumeLayout(false);
            gbCreateFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPictureFood).EndInit();
            gbCreateCategory.ResumeLayout(false);
            gbCreateCategory.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstList;
        private GroupBox gbCreateFood;
        private Button btnGetallFoods;
        private Button btnGetAllCategories;
        private Button btnGetAllUsers;
        private ComboBox cmbGetByCategories;
        private Label label1;
        private TextBox txtSearch;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtProtein;
        private TextBox txtFat;
        private TextBox txtCalorie;
        private TextBox txtPortionType;
        private TextBox txtCategoryName;
        private PictureBox pbPictureFood;
        private GroupBox gbCreateCategory;
        private Label label6;
        private Label label7;
        private TextBox txtCarbohydrate;
        private Label label9;
        private Label label8;
        private TextBox txtPicture;
        private TextBox txtCategoryID;
        private Label label10;
        private TextBox txtFoodName;
        private Button btnAddFood;
        private Button btnUpdateFood;
        private Button btnDeleteFood;
        private Button btnAddCategory;
        private Button btnUpdateCategory;
        private Button btnDeleteCategory;
        private Button btnAdd_picture;
    }
}