namespace BeFitUi
{
    partial class MealScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealScreen));
            lstFood = new ListView();
            btnAdd = new Button();
            dgvBreakfast = new DataGridView();
            dgvLunch = new DataGridView();
            dgvDinner = new DataGridView();
            rbBreakfast = new RadioButton();
            rbLunch = new RadioButton();
            rbDinner = new RadioButton();
            nmrFood = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFoodSearch = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblSabahKalori = new Label();
            lblOglenKalori = new Label();
            lblAksamKAlori = new Label();
            label10 = new Label();
            lblToplam = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            btnMainPage = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            pbfoodPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBreakfast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLunch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbfoodPicture).BeginInit();
            SuspendLayout();
            // 
            // lstFood
            // 
            lstFood.BackColor = Color.SandyBrown;
            lstFood.ForeColor = Color.Transparent;
            lstFood.Location = new Point(759, 288);
            lstFood.Name = "lstFood";
            lstFood.Size = new Size(398, 307);
            lstFood.TabIndex = 3;
            lstFood.UseCompatibleStateImageBehavior = false;
            lstFood.SelectedIndexChanged += lstFood_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SandyBrown;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Cooper Black", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.AliceBlue;
            btnAdd.Location = new Point(1219, 542);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 53);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBreakfast
            // 
            dgvBreakfast.BackgroundColor = Color.GhostWhite;
            dgvBreakfast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakfast.Location = new Point(12, 64);
            dgvBreakfast.Name = "dgvBreakfast";
            dgvBreakfast.RowHeadersWidth = 51;
            dgvBreakfast.RowTemplate.Height = 29;
            dgvBreakfast.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBreakfast.Size = new Size(580, 135);
            dgvBreakfast.TabIndex = 5;
            // 
            // dgvLunch
            // 
            dgvLunch.BackgroundColor = Color.GhostWhite;
            dgvLunch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLunch.GridColor = SystemColors.ButtonShadow;
            dgvLunch.Location = new Point(12, 247);
            dgvLunch.Name = "dgvLunch";
            dgvLunch.RowHeadersWidth = 51;
            dgvLunch.RowTemplate.Height = 29;
            dgvLunch.Size = new Size(580, 135);
            dgvLunch.TabIndex = 6;
            // 
            // dgvDinner
            // 
            dgvDinner.BackgroundColor = Color.GhostWhite;
            dgvDinner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDinner.Location = new Point(12, 443);
            dgvDinner.Name = "dgvDinner";
            dgvDinner.RowHeadersWidth = 51;
            dgvDinner.RowTemplate.Height = 29;
            dgvDinner.Size = new Size(580, 135);
            dgvDinner.TabIndex = 7;
            // 
            // rbBreakfast
            // 
            rbBreakfast.AutoSize = true;
            rbBreakfast.BackColor = Color.Transparent;
            rbBreakfast.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbBreakfast.ForeColor = Color.FromArgb(0, 64, 0);
            rbBreakfast.Location = new Point(1189, 288);
            rbBreakfast.Name = "rbBreakfast";
            rbBreakfast.Size = new Size(115, 24);
            rbBreakfast.TabIndex = 8;
            rbBreakfast.TabStop = true;
            rbBreakfast.Text = "Breakfast";
            rbBreakfast.UseVisualStyleBackColor = false;
            // 
            // rbLunch
            // 
            rbLunch.AutoSize = true;
            rbLunch.BackColor = Color.Transparent;
            rbLunch.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbLunch.ForeColor = Color.FromArgb(0, 64, 0);
            rbLunch.Location = new Point(1189, 339);
            rbLunch.Name = "rbLunch";
            rbLunch.Size = new Size(85, 24);
            rbLunch.TabIndex = 9;
            rbLunch.TabStop = true;
            rbLunch.Text = "Lunch";
            rbLunch.UseVisualStyleBackColor = false;
            // 
            // rbDinner
            // 
            rbDinner.AutoSize = true;
            rbDinner.BackColor = Color.Transparent;
            rbDinner.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rbDinner.ForeColor = Color.FromArgb(0, 64, 0);
            rbDinner.Location = new Point(1189, 395);
            rbDinner.Name = "rbDinner";
            rbDinner.Size = new Size(90, 24);
            rbDinner.TabIndex = 10;
            rbDinner.TabStop = true;
            rbDinner.Text = "Dinner";
            rbDinner.UseVisualStyleBackColor = false;
            // 
            // nmrFood
            // 
            nmrFood.Location = new Point(1189, 492);
            nmrFood.Name = "nmrFood";
            nmrFood.Size = new Size(198, 27);
            nmrFood.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(235, 29);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 12;
            label1.Text = "BREAKFAST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(256, 216);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 12;
            label2.Text = "LUNCH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(246, 412);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 12;
            label3.Text = "DINNER";
            // 
            // txtFoodSearch
            // 
            txtFoodSearch.Location = new Point(1189, 443);
            txtFoodSearch.Name = "txtFoodSearch";
            txtFoodSearch.PlaceholderText = "Food";
            txtFoodSearch.Size = new Size(196, 27);
            txtFoodSearch.TabIndex = 13;
            txtFoodSearch.TextChanged += txtFoodSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(779, 68);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 12;
            label4.Text = "BREAKFAST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(779, 125);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 12;
            label5.Text = "LUNCH";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(779, 181);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 12;
            label6.Text = "DINNER";
            // 
            // lblSabahKalori
            // 
            lblSabahKalori.AutoSize = true;
            lblSabahKalori.Font = new Font("Cooper Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSabahKalori.Location = new Point(957, 74);
            lblSabahKalori.Name = "lblSabahKalori";
            lblSabahKalori.Size = new Size(0, 15);
            lblSabahKalori.TabIndex = 14;
            // 
            // lblOglenKalori
            // 
            lblOglenKalori.AutoSize = true;
            lblOglenKalori.Location = new Point(957, 125);
            lblOglenKalori.Name = "lblOglenKalori";
            lblOglenKalori.Size = new Size(0, 20);
            lblOglenKalori.TabIndex = 14;
            // 
            // lblAksamKAlori
            // 
            lblAksamKAlori.AutoSize = true;
            lblAksamKAlori.Location = new Point(957, 181);
            lblAksamKAlori.Name = "lblAksamKAlori";
            lblAksamKAlori.Size = new Size(0, 20);
            lblAksamKAlori.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(786, 234);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 12;
            label10.Text = "TOTAL:";
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Font = new Font("Cooper Black", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblToplam.Location = new Point(957, 239);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(0, 15);
            lblToplam.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(1015, 233);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 14;
            label7.Text = "Calorie";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1015, 69);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 14;
            label8.Text = "Calorie";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1015, 125);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 14;
            label9.Text = "Calorie";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1015, 179);
            label11.Name = "label11";
            label11.Size = new Size(71, 20);
            label11.TabIndex = 14;
            label11.Text = "Calorie";
            // 
            // btnMainPage
            // 
            btnMainPage.BackColor = Color.SandyBrown;
            btnMainPage.FlatStyle = FlatStyle.Popup;
            btnMainPage.Font = new Font("Cooper Black", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainPage.ForeColor = SystemColors.ControlLightLight;
            btnMainPage.Location = new Point(618, 527);
            btnMainPage.Name = "btnMainPage";
            btnMainPage.Size = new Size(125, 51);
            btnMainPage.TabIndex = 15;
            btnMainPage.Text = "Main Page";
            btnMainPage.UseVisualStyleBackColor = false;
            btnMainPage.Click += btnMainPage_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SandyBrown;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.GhostWhite;
            btnDelete.Location = new Point(618, 288);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 51);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SandyBrown;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Cooper Black", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(618, 369);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 48);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pbfoodPicture
            // 
            pbfoodPicture.Location = new Point(1189, 64);
            pbfoodPicture.Name = "pbfoodPicture";
            pbfoodPicture.Size = new Size(196, 167);
            pbfoodPicture.TabIndex = 18;
            pbfoodPicture.TabStop = false;
            // 
            // MealScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1457, 651);
            Controls.Add(pbfoodPicture);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnMainPage);
            Controls.Add(lblAksamKAlori);
            Controls.Add(lblOglenKalori);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblToplam);
            Controls.Add(lblSabahKalori);
            Controls.Add(txtFoodSearch);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(nmrFood);
            Controls.Add(rbDinner);
            Controls.Add(rbLunch);
            Controls.Add(rbBreakfast);
            Controls.Add(dgvDinner);
            Controls.Add(dgvLunch);
            Controls.Add(dgvBreakfast);
            Controls.Add(btnAdd);
            Controls.Add(lstFood);
            Name = "MealScreen";
            Text = "Food";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBreakfast).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLunch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbfoodPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lstFood;
        private Button btnAdd;
        private DataGridView dgvBreakfast;
        private DataGridView dgvLunch;
        private DataGridView dgvDinner;
        private RadioButton rbBreakfast;
        private RadioButton rbLunch;
        private RadioButton rbDinner;
        private NumericUpDown nmrFood;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFoodSearch;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblSabahKalori;
        private Label lblOglenKalori;
        private Label lblAksamKAlori;
        private Label label10;
        private Label lblToplam;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Button btnMainPage;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pbfoodPicture;
    }
}