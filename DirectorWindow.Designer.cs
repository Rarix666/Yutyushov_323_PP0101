namespace WorkerApp
{
    partial class DirectorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorWindow));
            label3 = new Label();
            ExitButtonMain = new Button();
            ChatClickDirector = new Label();
            ClickPictureProfile = new PictureBox();
            CreateAdminButton = new Button();
            DeleteAdminButton = new Button();
            label1 = new Label();
            LoginBox = new ComboBox();
            NameAdminTextBox = new TextBox();
            PasswordAdminTextBox = new TextBox();
            EnterDepartments = new Label();
            LoginAdminLabel = new Label();
            FIOAdminLabel = new Label();
            PasswordAdminLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(10, 103);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 15;
            label3.Text = "Личный кабинет";
            label3.Click += label3_Click;
            // 
            // ExitButtonMain
            // 
            ExitButtonMain.Location = new Point(403, 21);
            ExitButtonMain.Name = "ExitButtonMain";
            ExitButtonMain.Size = new Size(75, 23);
            ExitButtonMain.TabIndex = 14;
            ExitButtonMain.Text = "Выход";
            ExitButtonMain.UseVisualStyleBackColor = true;
            ExitButtonMain.Click += ExitButtonMain_Click;
            // 
            // ChatClickDirector
            // 
            ChatClickDirector.AutoSize = true;
            ChatClickDirector.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChatClickDirector.Location = new Point(312, 12);
            ChatClickDirector.Name = "ChatClickDirector";
            ChatClickDirector.Size = new Size(55, 32);
            ChatClickDirector.TabIndex = 12;
            ChatClickDirector.Text = "Чат";
            ChatClickDirector.Click += ChatClickDirector_Click;
            // 
            // ClickPictureProfile
            // 
            ClickPictureProfile.Image = (Image)resources.GetObject("ClickPictureProfile.Image");
            ClickPictureProfile.Location = new Point(27, 12);
            ClickPictureProfile.Name = "ClickPictureProfile";
            ClickPictureProfile.Size = new Size(100, 88);
            ClickPictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            ClickPictureProfile.TabIndex = 11;
            ClickPictureProfile.TabStop = false;
            ClickPictureProfile.Click += ClickPictureProfile_Click;
            // 
            // CreateAdminButton
            // 
            CreateAdminButton.Location = new Point(197, 221);
            CreateAdminButton.Name = "CreateAdminButton";
            CreateAdminButton.Size = new Size(75, 23);
            CreateAdminButton.TabIndex = 16;
            CreateAdminButton.Text = "Добавить";
            CreateAdminButton.UseVisualStyleBackColor = true;
            CreateAdminButton.Click += CreateAdminButton_Click;
            // 
            // DeleteAdminButton
            // 
            DeleteAdminButton.Location = new Point(292, 221);
            DeleteAdminButton.Name = "DeleteAdminButton";
            DeleteAdminButton.Size = new Size(75, 23);
            DeleteAdminButton.TabIndex = 17;
            DeleteAdminButton.Text = "Удалить";
            DeleteAdminButton.UseVisualStyleBackColor = true;
            DeleteAdminButton.Click += DeleteAdminButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(219, 104);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 22;
            label1.Text = "Администратор";
            // 
            // LoginBox
            // 
            LoginBox.FormattingEnabled = true;
            LoginBox.Location = new Point(197, 127);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(170, 23);
            LoginBox.TabIndex = 23;
            // 
            // NameAdminTextBox
            // 
            NameAdminTextBox.Location = new Point(197, 156);
            NameAdminTextBox.Name = "NameAdminTextBox";
            NameAdminTextBox.Size = new Size(170, 23);
            NameAdminTextBox.TabIndex = 24;
            // 
            // PasswordAdminTextBox
            // 
            PasswordAdminTextBox.Location = new Point(197, 192);
            PasswordAdminTextBox.Name = "PasswordAdminTextBox";
            PasswordAdminTextBox.Size = new Size(170, 23);
            PasswordAdminTextBox.TabIndex = 25;
            // 
            // EnterDepartments
            // 
            EnterDepartments.AutoSize = true;
            EnterDepartments.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EnterDepartments.Location = new Point(167, 12);
            EnterDepartments.Name = "EnterDepartments";
            EnterDepartments.Size = new Size(105, 32);
            EnterDepartments.TabIndex = 28;
            EnterDepartments.Text = "Отделы";
            EnterDepartments.Click += EnterDepartments_Click;
            // 
            // LoginAdminLabel
            // 
            LoginAdminLabel.AutoSize = true;
            LoginAdminLabel.Location = new Point(150, 130);
            LoginAdminLabel.Name = "LoginAdminLabel";
            LoginAdminLabel.Size = new Size(44, 15);
            LoginAdminLabel.TabIndex = 29;
            LoginAdminLabel.Text = "Логин:";
            // 
            // FIOAdminLabel
            // 
            FIOAdminLabel.AutoSize = true;
            FIOAdminLabel.Location = new Point(157, 159);
            FIOAdminLabel.Name = "FIOAdminLabel";
            FIOAdminLabel.Size = new Size(37, 15);
            FIOAdminLabel.TabIndex = 30;
            FIOAdminLabel.Text = "ФИО:";
            // 
            // PasswordAdminLabel
            // 
            PasswordAdminLabel.AutoSize = true;
            PasswordAdminLabel.Location = new Point(142, 195);
            PasswordAdminLabel.Name = "PasswordAdminLabel";
            PasswordAdminLabel.Size = new Size(52, 15);
            PasswordAdminLabel.TabIndex = 31;
            PasswordAdminLabel.Text = "Пароль:";
            // 
            // DirectorWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(498, 274);
            Controls.Add(PasswordAdminLabel);
            Controls.Add(FIOAdminLabel);
            Controls.Add(LoginAdminLabel);
            Controls.Add(EnterDepartments);
            Controls.Add(PasswordAdminTextBox);
            Controls.Add(NameAdminTextBox);
            Controls.Add(LoginBox);
            Controls.Add(label1);
            Controls.Add(DeleteAdminButton);
            Controls.Add(CreateAdminButton);
            Controls.Add(label3);
            Controls.Add(ExitButtonMain);
            Controls.Add(ChatClickDirector);
            Controls.Add(ClickPictureProfile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DirectorWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное окно";
            Load += DirectorWindow_Load;
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button ExitButtonMain;
        private Label ChatClickDirector;
        private PictureBox ClickPictureProfile;
        private Button CreateAdminButton;
        private Button DeleteAdminButton;
        private Label label1;
        private ComboBox LoginBox;
        private TextBox NameAdminTextBox;
        private TextBox PasswordAdminTextBox;
        private Label EnterDepartments;
        private Label LoginAdminLabel;
        private Label FIOAdminLabel;
        private Label PasswordAdminLabel;
    }
}