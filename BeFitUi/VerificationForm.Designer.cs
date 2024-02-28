namespace BeFitUi
{
    partial class VerificationForm
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
            btnActivate = new Button();
            txtVerificationCode = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.Linen;
            btnActivate.FlatStyle = FlatStyle.Popup;
            btnActivate.Location = new Point(180, 277);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(95, 38);
            btnActivate.TabIndex = 0;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // txtVerificationCode
            // 
            txtVerificationCode.Location = new Point(153, 235);
            txtVerificationCode.Name = "txtVerificationCode";
            txtVerificationCode.Size = new Size(140, 26);
            txtVerificationCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 185);
            label1.Name = "label1";
            label1.Size = new Size(275, 18);
            label1.TabIndex = 2;
            label1.Text = "Please enter your verification code.";
            // 
            // VerificationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(439, 377);
            Controls.Add(label1);
            Controls.Add(txtVerificationCode);
            Controls.Add(btnActivate);
            Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Name = "VerificationForm";
            Text = "VerificationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActivate;
        private TextBox txtVerificationCode;
        private Label label1;
    }
}