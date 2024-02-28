namespace BeFitUi
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            btnMealAdd = new Button();
            lblTargetCalorie = new Label();
            btnList = new Button();
            dgvFoods = new DataGridView();
            dgvCategories = new DataGridView();
            label2 = new Label();
            dgvReport = new DataGridView();
            btnReport = new Button();
            dtpreportDate = new DateTimePicker();
            lbl = new Label();
            lblTotalCalorie = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // btnMealAdd
            // 
            btnMealAdd.BackColor = Color.DarkSalmon;
            btnMealAdd.FlatStyle = FlatStyle.Popup;
            btnMealAdd.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMealAdd.ForeColor = Color.SeaShell;
            btnMealAdd.Location = new Point(635, 285);
            btnMealAdd.Name = "btnMealAdd";
            btnMealAdd.Size = new Size(137, 59);
            btnMealAdd.TabIndex = 0;
            btnMealAdd.Text = "ADD MEAL";
            btnMealAdd.UseVisualStyleBackColor = false;
            btnMealAdd.Click += btnMealAdd_Click;
            // 
            // lblTargetCalorie
            // 
            lblTargetCalorie.BackColor = Color.Transparent;
            lblTargetCalorie.Font = new Font("Arial Rounded MT Bold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblTargetCalorie.ForeColor = Color.Maroon;
            lblTargetCalorie.Location = new Point(575, 103);
            lblTargetCalorie.Name = "lblTargetCalorie";
            lblTargetCalorie.Size = new Size(158, 65);
            lblTargetCalorie.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.BackColor = Color.DarkSalmon;
            btnList.BackgroundImageLayout = ImageLayout.Center;
            btnList.FlatStyle = FlatStyle.Popup;
            btnList.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnList.ForeColor = Color.SeaShell;
            btnList.Location = new Point(439, 285);
            btnList.Name = "btnList";
            btnList.Size = new Size(133, 59);
            btnList.TabIndex = 2;
            btnList.Text = "LIST";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // dgvFoods
            // 
            dgvFoods.BackgroundColor = Color.GhostWhite;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Enabled = false;
            dgvFoods.Location = new Point(499, 421);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.RowTemplate.Height = 29;
            dgvFoods.Size = new Size(304, 215);
            dgvFoods.TabIndex = 3;
            dgvFoods.CellFormatting += dgvFoods_CellFormatting;
            // 
            // dgvCategories
            // 
            dgvCategories.BackgroundColor = Color.GhostWhite;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Enabled = false;
            dgvCategories.Location = new Point(836, 421);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.Size = new Size(304, 215);
            dgvCategories.TabIndex = 4;
            dgvCategories.CellFormatting += dgvCategories_CellFormatting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(499, 77);
            label2.Name = "label2";
            label2.Size = new Size(234, 26);
            label2.TabIndex = 5;
            label2.Text = "TARGET CALORIE";
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = Color.GhostWhite;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(36, 421);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 29;
            dgvReport.Size = new Size(436, 215);
            dgvReport.TabIndex = 6;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.DarkSalmon;
            btnReport.BackgroundImageLayout = ImageLayout.Stretch;
            btnReport.FlatStyle = FlatStyle.Popup;
            btnReport.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.Location = new Point(36, 362);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(116, 40);
            btnReport.TabIndex = 7;
            btnReport.Text = "REPORT";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // dtpreportDate
            // 
            dtpreportDate.Location = new Point(172, 362);
            dtpreportDate.Name = "dtpreportDate";
            dtpreportDate.Size = new Size(250, 27);
            dtpreportDate.TabIndex = 8;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = Color.Black;
            lbl.Location = new Point(514, 183);
            lbl.Name = "lbl";
            lbl.Size = new Size(213, 23);
            lbl.TabIndex = 9;
            lbl.Text = "INTAKE CALORIES";
            // 
            // lblTotalCalorie
            // 
            lblTotalCalorie.BackColor = Color.Transparent;
            lblTotalCalorie.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCalorie.ForeColor = Color.Maroon;
            lblTotalCalorie.Location = new Point(575, 212);
            lblTotalCalorie.Name = "lblTotalCalorie";
            lblTotalCalorie.Size = new Size(121, 70);
            lblTotalCalorie.TabIndex = 10;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1303, 697);
            Controls.Add(lblTotalCalorie);
            Controls.Add(lbl);
            Controls.Add(dtpreportDate);
            Controls.Add(btnReport);
            Controls.Add(dgvReport);
            Controls.Add(label2);
            Controls.Add(dgvCategories);
            Controls.Add(dgvFoods);
            Controls.Add(btnList);
            Controls.Add(lblTargetCalorie);
            Controls.Add(btnMealAdd);
            Name = "MainScreen";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMealAdd;
        private Label lblTargetCalorie;
        private Button btnList;
        private DataGridView dgvFoods;
        private DataGridView dgvCategories;
        private Label label2;
        private DataGridView dgvReport;
        private Button btnReport;
        private DateTimePicker dtpreportDate;
        private Label lbl;
        private Label lblTotalCalorie;
    }
}