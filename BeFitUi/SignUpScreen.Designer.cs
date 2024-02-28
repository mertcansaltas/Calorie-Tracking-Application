namespace BeFitUi
{
    partial class SignUpScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpScreen));
            groupBox1 = new GroupBox();
            btnBack = new Button();
            btnRegister = new Button();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            mtxtPhone = new MaskedTextBox();
            label3 = new Label();
            txtSurname = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(mtxtPhone);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkOrange;
            groupBox1.Location = new Point(541, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 643);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "SIGN UP";
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Location = new Point(35, 565);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 50);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SandyBrown;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Palatino Linotype", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(156, 494);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(144, 42);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.LemonChiffon;
            txtConfirmPassword.Location = new Point(129, 430);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(195, 30);
            txtConfirmPassword.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(129, 404);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 3;
            label6.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LemonChiffon;
            txtPassword.Location = new Point(129, 360);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 30);
            txtPassword.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(129, 334);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 3;
            label5.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LemonChiffon;
            txtEmail.Location = new Point(129, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 30);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(129, 257);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "E-Mail:";
            // 
            // mtxtPhone
            // 
            mtxtPhone.BackColor = Color.LemonChiffon;
            mtxtPhone.Location = new Point(129, 209);
            mtxtPhone.Mask = "000 000 00 00";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(195, 30);
            mtxtPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(129, 174);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 0;
            label3.Text = "Phone:";
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.LemonChiffon;
            txtSurname.Location = new Point(129, 131);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(195, 30);
            txtSurname.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(129, 105);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 0;
            label2.Text = "Surname:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.LemonChiffon;
            txtName.Location = new Point(129, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 30);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(129, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 23);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Sitka Small", 28F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(778, -5);
            label7.Name = "label7";
            label7.Size = new Size(152, 69);
            label7.TabIndex = 9;
            label7.Text = "BeFit";
            // 
            // SignUpScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(954, 722);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "SignUpScreen";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnRegister;
        private TextBox txtConfirmPassword;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private MaskedTextBox mtxtPhone;
        private Label label3;
        private TextBox txtSurname;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private Button btnBack;
        private Label label7;
    }
}