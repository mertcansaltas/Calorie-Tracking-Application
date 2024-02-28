namespace BeFitUi
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            btnRegister = new Button();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SandyBrown;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegister.Location = new Point(98, 240);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 56);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SandyBrown;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.Location = new Point(275, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 56);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 67);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Small", 28F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(168, 18);
            label2.Name = "label2";
            label2.Size = new Size(152, 69);
            label2.TabIndex = 7;
            label2.Text = "BeFit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(97, 87);
            label3.Name = "label3";
            label3.Size = new Size(296, 41);
            label3.TabIndex = 8;
            label3.Text = "Eat Healty Be Happy";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(489, 543);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Name = "LoginScreen";
            Text = "Login";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegister;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}