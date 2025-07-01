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
            FIOLabel = new Label();
            BirthdayLabel = new Label();
            PostLabel = new Label();
            mailLabel = new Label();
            pictureBox1 = new PictureBox();
            ButtonExitProf = new Button();
            UpdateUsers = new Button();
            panel1 = new Panel();
            Updatebut = new Button();
            mailTextBox = new TextBox();
            PostsTextBox = new TextBox();
            birthdayTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FIOLabel
            // 
            FIOLabel.AutoSize = true;
            FIOLabel.Location = new Point(23, 51);
            FIOLabel.Name = "FIOLabel";
            FIOLabel.Size = new Size(34, 15);
            FIOLabel.TabIndex = 0;
            FIOLabel.Text = "ФИО";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Location = new Point(23, 102);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(84, 15);
            BirthdayLabel.TabIndex = 1;
            BirthdayLabel.Text = "Год рождения";
            // 
            // PostLabel
            // 
            PostLabel.AutoSize = true;
            PostLabel.Location = new Point(23, 160);
            PostLabel.Name = "PostLabel";
            PostLabel.Size = new Size(69, 15);
            PostLabel.TabIndex = 2;
            PostLabel.Text = "Должность";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new Point(23, 209);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(41, 15);
            mailLabel.TabIndex = 3;
            mailLabel.Text = "Почта";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(291, 32);
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
            UpdateUsers.Location = new Point(350, 274);
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Updatebut);
            panel1.Controls.Add(mailTextBox);
            panel1.Controls.Add(PostsTextBox);
            panel1.Controls.Add(birthdayTextBox);
            panel1.Location = new Point(204, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 202);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // Updatebut
            // 
            Updatebut.Location = new Point(165, 161);
            Updatebut.Name = "Updatebut";
            Updatebut.Size = new Size(75, 23);
            Updatebut.TabIndex = 3;
            Updatebut.Text = "Обновить";
            Updatebut.UseVisualStyleBackColor = true;
            Updatebut.Click += Updatebut_Click;
            // 
            // mailTextBox
            // 
            mailTextBox.Location = new Point(103, 112);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(192, 23);
            mailTextBox.TabIndex = 2;
            // 
            // PostsTextBox
            // 
            PostsTextBox.Location = new Point(103, 59);
            PostsTextBox.Name = "PostsTextBox";
            PostsTextBox.Size = new Size(192, 23);
            PostsTextBox.TabIndex = 1;
            // 
            // birthdayTextBox
            // 
            birthdayTextBox.Location = new Point(103, 11);
            birthdayTextBox.Name = "birthdayTextBox";
            birthdayTextBox.Size = new Size(192, 23);
            birthdayTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "День рождения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 62);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 115);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Почта";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 309);
            Controls.Add(panel1);
            Controls.Add(UpdateUsers);
            Controls.Add(ButtonExitProf);
            Controls.Add(pictureBox1);
            Controls.Add(mailLabel);
            Controls.Add(PostLabel);
            Controls.Add(BirthdayLabel);
            Controls.Add(FIOLabel);
            Name = "Profile";
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
        private TextBox PostsTextBox;
        private TextBox birthdayTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}