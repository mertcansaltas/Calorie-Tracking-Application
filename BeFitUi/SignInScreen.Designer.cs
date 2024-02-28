namespace BeFitUi
{
    partial class SignInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInScreen));
            groupBox2 = new GroupBox();
            btnBack = new Button();
            btnShowPassword = new Button();
            btnSignIn = new Button();
            txtLoginPassword = new TextBox();
            label7 = new Label();
            txtLoginEmail = new TextBox();
            label8 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(btnShowPassword);
            groupBox2.Controls.Add(btnSignIn);
            groupBox2.Controls.Add(txtLoginPassword);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtLoginEmail);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.DarkOrange;
            groupBox2.Location = new Point(395, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 448);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "SIGN IN";
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Location = new Point(25, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 41);
            btnBack.TabIndex = 4;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.PowderBlue;
            btnShowPassword.BackgroundImage = (Image)resources.GetObject("btnShowPassword.BackgroundImage");
            btnShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowPassword.Location = new Point(231, 204);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(34, 30);
            btnShowPassword.TabIndex = 3;
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.SandyBrown;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSignIn.ForeColor = SystemColors.ControlText;
            btnSignIn.Location = new Point(106, 271);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(129, 48);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BackColor = Color.LemonChiffon;
            txtLoginPassword.Location = new Point(70, 204);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(195, 30);
            txtLoginPassword.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(70, 106);
            label7.Name = "label7";
            label7.Size = new Size(66, 24);
            label7.TabIndex = 0;
            label7.Text = "E-Mail";
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.BackColor = Color.LemonChiffon;
            txtLoginEmail.Location = new Point(70, 132);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(195, 30);
            txtLoginEmail.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Orange;
            label8.Location = new Point(70, 178);
            label8.Name = "label8";
            label8.Size = new Size(89, 24);
            label8.TabIndex = 0;
            label8.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 28F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(588, -2);
            label2.Name = "label2";
            label2.Size = new Size(152, 69);
            label2.TabIndex = 8;
            label2.Text = "BeFit";
            // 
            // SignInScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 618);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Name = "SignInScreen";
            Text = "Sign In";
            Load += SignInScreen_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnShowPassword;
        private Button btnSignIn;
        private TextBox txtLoginPassword;
        private Label label7;
        private TextBox txtLoginEmail;
        private Label label8;
        private Button btnBack;
        private Label label2;
    }
}