namespace WorkerApp
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            FIOLabel = new Label();
            BirthdayLabel = new Label();
            PostLabel = new Label();
            mailLabel = new Label();
            pictureBox1 = new PictureBox();
            ButtonExitProf = new Button();
            UpdateUsers = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            Updatebut = new Button();
            mailTextBox = new TextBox();
            birthdayTextBox = new TextBox();
            BackToMain = new Button();
            GroupLabel = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FIOLabel
            // 
            FIOLabel.AutoSize = true;
            FIOLabel.Location = new Point(110, 51);
            FIOLabel.Name = "FIOLabel";
            FIOLabel.Size = new Size(40, 15);
            FIOLabel.TabIndex = 0;
            FIOLabel.Text = "Пусто";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Location = new Point(110, 91);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(40, 15);
            BirthdayLabel.TabIndex = 1;
            BirthdayLabel.Text = "Пусто";
            // 
            // PostLabel
            // 
            PostLabel.AutoSize = true;
            PostLabel.Location = new Point(110, 166);
            PostLabel.Name = "PostLabel";
            PostLabel.Size = new Size(40, 15);
            PostLabel.TabIndex = 2;
            PostLabel.Text = "Пусто";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(110, 209);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(40, 15);
            mailLabel.TabIndex = 3;
            mailLabel.Text = "Пусто";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(361, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 202);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ButtonExitProf
            // 
            ButtonExitProf.Location = new Point(23, 274);
            ButtonExitProf.Name = "ButtonExitProf";
            ButtonExitProf.Size = new Size(138, 23);
            ButtonExitProf.TabIndex = 5;
            ButtonExitProf.Text = "Выйти из аккаунта";
            ButtonExitProf.UseVisualStyleBackColor = true;
            ButtonExitProf.Click += ButtonExitProf_Click;
            // 
            // UpdateUsers
            // 
            UpdateUsers.Location = new Point(450, 274);
            UpdateUsers.Name = "UpdateUsers";
            UpdateUsers.Size = new Size(139, 23);
            UpdateUsers.TabIndex = 6;
            UpdateUsers.Text = "Обновить данные";
            UpdateUsers.UseVisualStyleBackColor = true;
            UpdateUsers.Click += UpdateUsers_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Updatebut);
            panel1.Controls.Add(mailTextBox);
            panel1.Controls.Add(birthdayTextBox);
            panel1.Location = new Point(274, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 202);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 99);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Почта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 54);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 4;
            label1.Text = "Дата рождения";
            // 
            // Updatebut
            // 
            Updatebut.Location = new Point(146, 134);
            Updatebut.Name = "Updatebut";
            Updatebut.Size = new Size(75, 23);
            Updatebut.TabIndex = 3;
            Updatebut.Text = "Обновить";
            Updatebut.UseVisualStyleBackColor = true;
            Updatebut.Click += Updatebut_Click;
            // 
            // mailTextBox
            // 
            mailTextBox.Location = new Point(103, 96);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(192, 23);
            mailTextBox.TabIndex = 2;
            // 
            // birthdayTextBox
            // 
            birthdayTextBox.Location = new Point(103, 51);
            birthdayTextBox.Name = "birthdayTextBox";
            birthdayTextBox.Size = new Size(192, 23);
            birthdayTextBox.TabIndex = 0;
            // 
            // BackToMain
            // 
            BackToMain.Location = new Point(514, 3);
            BackToMain.Name = "BackToMain";
            BackToMain.Size = new Size(75, 23);
            BackToMain.TabIndex = 8;
            BackToMain.Text = "Назад";
            BackToMain.UseVisualStyleBackColor = true;
            BackToMain.Click += BackToMain_Click;
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Location = new Point(110, 127);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(40, 15);
            GroupLabel.TabIndex = 9;
            GroupLabel.Text = "Пусто";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 51);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "ФИО:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 91);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 11;
            label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 127);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 12;
            label5.Text = "Отдел:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 166);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 13;
            label6.Text = "Должность:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 209);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "Почта:";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(606, 309);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(GroupLabel);
            Controls.Add(BackToMain);
            Controls.Add(panel1);
            Controls.Add(UpdateUsers);
            Controls.Add(ButtonExitProf);
            Controls.Add(pictureBox1);
            Controls.Add(mailLabel);
            Controls.Add(PostLabel);
            Controls.Add(BirthdayLabel);
            Controls.Add(FIOLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Профиль";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FIOLabel;
        private Label BirthdayLabel;
        private Label PostLabel;
        private Label mailLabel;
        private PictureBox pictureBox1;
        private Button ButtonExitProf;
        private Button UpdateUsers;
        private Panel panel1;
        private Button Updatebut;
        private TextBox mailTextBox;
        private TextBox birthdayTextBox;
        private Label label3;
        private Label label1;
        private Button BackToMain;
        private Label GroupLabel;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}