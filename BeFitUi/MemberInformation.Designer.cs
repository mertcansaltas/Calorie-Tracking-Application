namespace BeFitUi
{
    partial class MemberInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInformation));
            lblBodyMassIndex = new Label();
            btnContinue = new Button();
            btnBMI = new Button();
            rbWoman = new RadioButton();
            rbMan = new RadioButton();
            cmbTrainingLevel = new ComboBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBMI = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtAge = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBodyMassIndex
            // 
            lblBodyMassIndex.BackColor = Color.Transparent;
            lblBodyMassIndex.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblBodyMassIndex.Location = new Point(311, 505);
            lblBodyMassIndex.Name = "lblBodyMassIndex";
            lblBodyMassIndex.Size = new Size(138, 25);
            lblBodyMassIndex.TabIndex = 47;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.Chocolate;
            btnContinue.FlatStyle = FlatStyle.Popup;
            btnContinue.Font = new Font("Palatino Linotype", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnContinue.ForeColor = SystemColors.ButtonHighlight;
            btnContinue.Location = new Point(116, 556);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(108, 44);
            btnContinue.TabIndex = 46;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click_1;
            // 
            // btnBMI
            // 
            btnBMI.BackColor = Color.Chocolate;
            btnBMI.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBMI.ForeColor = Color.MistyRose;
            btnBMI.Location = new Point(72, 429);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(211, 34);
            btnBMI.TabIndex = 45;
            btnBMI.Text = "Body Mass Index Calculation";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click_1;
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.BackColor = Color.Transparent;
            rbWoman.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbWoman.ForeColor = Color.IndianRed;
            rbWoman.Location = new Point(198, 295);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(76, 24);
            rbWoman.TabIndex = 44;
            rbWoman.TabStop = true;
            rbWoman.Text = "Female";
            rbWoman.UseVisualStyleBackColor = false;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.BackColor = Color.Transparent;
            rbMan.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rbMan.ForeColor = Color.IndianRed;
            rbMan.Location = new Point(86, 295);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(63, 24);
            rbMan.TabIndex = 43;
            rbMan.TabStop = true;
            rbMan.Text = "Male";
            rbMan.UseVisualStyleBackColor = false;
            // 
            // cmbTrainingLevel
            // 
            cmbTrainingLevel.BackColor = Color.LemonChiffon;
            cmbTrainingLevel.FormattingEnabled = true;
            cmbTrainingLevel.Location = new Point(72, 362);
            cmbTrainingLevel.Name = "cmbTrainingLevel";
            cmbTrainingLevel.Size = new Size(211, 28);
            cmbTrainingLevel.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(188, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Chocolate;
            label5.Location = new Point(68, 334);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 38;
            label5.Text = "Training Level:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Chocolate;
            label6.Location = new Point(72, 475);
            label6.Name = "label6";
            label6.Size = new Size(142, 23);
            label6.TabIndex = 37;
            label6.Text = "Body Mass Index:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Chocolate;
            label3.Location = new Point(70, 143);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 36;
            label3.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Chocolate;
            label2.Location = new Point(68, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 35;
            label2.Text = "Height:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(72, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 34;
            label1.Text = "Age:";
            // 
            // txtBMI
            // 
            txtBMI.BackColor = Color.LemonChiffon;
            txtBMI.Location = new Point(70, 503);
            txtBMI.Name = "txtBMI";
            txtBMI.Size = new Size(211, 27);
            txtBMI.TabIndex = 32;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.LemonChiffon;
            txtWeight.Location = new Point(74, 171);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(211, 27);
            txtWeight.TabIndex = 31;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.LemonChiffon;
            txtHeight.Location = new Point(72, 113);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(211, 27);
            txtHeight.TabIndex = 33;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.LemonChiffon;
            txtAge.Location = new Point(72, 55);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(211, 27);
            txtAge.TabIndex = 30;
            // 
            // MemberInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 644);
            Controls.Add(lblBodyMassIndex);
            Controls.Add(btnContinue);
            Controls.Add(btnBMI);
            Controls.Add(rbWoman);
            Controls.Add(rbMan);
            Controls.Add(cmbTrainingLevel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBMI);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Name = "MemberInformation";
            Text = "MemberInformation";
            Load += MemberInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBodyMassIndex;
        private Button btnContinue;
        private Button btnBMI;
        private RadioButton rbWoman;
        private RadioButton rbMan;
        private ComboBox cmbTrainingLevel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBMI;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtAge;
    }
}