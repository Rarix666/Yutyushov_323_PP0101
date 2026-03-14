namespace WorkerApp
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            EnterAutorizButton = new Button();
            Autoriz = new Label();
            TipLogin = new Label();
            TipPassword = new Label();
            EyeOpen = new PictureBox();
            EyeClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EyeClose).BeginInit();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(259, 128);
            LoginTextBox.MaxLength = 40;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(251, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(259, 189);
            PasswordTextBox.MaxLength = 40;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(251, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // EnterAutorizButton
            // 
            EnterAutorizButton.Location = new Point(345, 239);
            EnterAutorizButton.Name = "EnterAutorizButton";
            EnterAutorizButton.Size = new Size(75, 23);
            EnterAutorizButton.TabIndex = 2;
            EnterAutorizButton.Text = "Войти";
            EnterAutorizButton.UseVisualStyleBackColor = true;
            EnterAutorizButton.Click += EnterAutorizButton_Click;
            // 
            // Autoriz
            // 
            Autoriz.AutoSize = true;
            Autoriz.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Autoriz.Location = new Point(310, 81);
            Autoriz.Name = "Autoriz";
            Autoriz.Size = new Size(149, 30);
            Autoriz.TabIndex = 3;
            Autoriz.Text = "Авторизация";
            // 
            // TipLogin
            // 
            TipLogin.AutoSize = true;
            TipLogin.Location = new Point(215, 131);
            TipLogin.Name = "TipLogin";
            TipLogin.Size = new Size(41, 15);
            TipLogin.TabIndex = 4;
            TipLogin.Text = "Логин";
            // 
            // TipPassword
            // 
            TipPassword.AutoSize = true;
            TipPassword.Location = new Point(207, 192);
            TipPassword.Name = "TipPassword";
            TipPassword.Size = new Size(49, 15);
            TipPassword.TabIndex = 5;
            TipPassword.Text = "Пароль";
            // 
            // EyeOpen
            // 
            EyeOpen.BackColor = Color.MediumSlateBlue;
            EyeOpen.BackgroundImage = (Image)resources.GetObject("EyeOpen.BackgroundImage");
            EyeOpen.BackgroundImageLayout = ImageLayout.Stretch;
            EyeOpen.Location = new Point(519, 183);
            EyeOpen.Name = "EyeOpen";
            EyeOpen.Size = new Size(28, 29);
            EyeOpen.TabIndex = 6;
            EyeOpen.TabStop = false;
            EyeOpen.Visible = false;
            EyeOpen.Click += EyeOpen_Click;
            // 
            // EyeClose
            // 
            EyeClose.BackColor = Color.MediumSlateBlue;
            EyeClose.BackgroundImage = (Image)resources.GetObject("EyeClose.BackgroundImage");
            EyeClose.BackgroundImageLayout = ImageLayout.Stretch;
            EyeClose.Location = new Point(519, 183);
            EyeClose.Name = "EyeClose";
            EyeClose.Size = new Size(28, 29);
            EyeClose.TabIndex = 7;
            EyeClose.TabStop = false;
            EyeClose.Click += EyeClose_Click;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(743, 421);
            Controls.Add(EyeOpen);
            Controls.Add(TipPassword);
            Controls.Add(TipLogin);
            Controls.Add(Autoriz);
            Controls.Add(EnterAutorizButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(EyeClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Autorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosing += Autorization_FormClosing;
            ((System.ComponentModel.ISupportInitialize)EyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)EyeClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button EnterAutorizButton;
        private Label Autoriz;
        private Label TipLogin;
        private Label TipPassword;
        private PictureBox EyeOpen;
        private PictureBox EyeClose;
    }
}
