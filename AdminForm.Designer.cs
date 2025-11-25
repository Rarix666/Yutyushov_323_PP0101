namespace WorkerApp
{
    partial class AdminForm
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
            CPasswordBox = new TextBox();
            CreateUsers = new Button();
            DeleteUsers = new Button();
            label1 = new Label();
            CComboLogin = new ComboBox();
            CFIOBox = new TextBox();
            CComboRole = new ComboBox();
            ExitAdminButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            COtdelBox = new ComboBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CPasswordBox
            // 
            CPasswordBox.Location = new Point(67, 187);
            CPasswordBox.Name = "CPasswordBox";
            CPasswordBox.Size = new Size(181, 23);
            CPasswordBox.TabIndex = 1;
            // 
            // CreateUsers
            // 
            CreateUsers.Location = new Point(79, 271);
            CreateUsers.Name = "CreateUsers";
            CreateUsers.Size = new Size(75, 23);
            CreateUsers.TabIndex = 2;
            CreateUsers.Text = "Сохранить";
            CreateUsers.UseVisualStyleBackColor = true;
            CreateUsers.Click += CreateUsers_Click;
            // 
            // DeleteUsers
            // 
            DeleteUsers.Location = new Point(160, 271);
            DeleteUsers.Name = "DeleteUsers";
            DeleteUsers.Size = new Size(75, 23);
            DeleteUsers.TabIndex = 3;
            DeleteUsers.Text = "Удалить";
            DeleteUsers.UseVisualStyleBackColor = true;
            DeleteUsers.Click += DeleteUsers_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(445, 35);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 4;
            label1.Text = "Пользователи";
            // 
            // CComboLogin
            // 
            CComboLogin.FormattingEnabled = true;
            CComboLogin.Location = new Point(67, 67);
            CComboLogin.Name = "CComboLogin";
            CComboLogin.Size = new Size(181, 23);
            CComboLogin.TabIndex = 5;
            // 
            // CFIOBox
            // 
            CFIOBox.Location = new Point(67, 105);
            CFIOBox.Name = "CFIOBox";
            CFIOBox.Size = new Size(181, 23);
            CFIOBox.TabIndex = 6;
            // 
            // CComboRole
            // 
            CComboRole.FormattingEnabled = true;
            CComboRole.Items.AddRange(new object[] { "worker", "manager" });
            CComboRole.Location = new Point(87, 145);
            CComboRole.Name = "CComboRole";
            CComboRole.Size = new Size(161, 23);
            CComboRole.TabIndex = 7;
            // 
            // ExitAdminButton
            // 
            ExitAdminButton.Location = new Point(688, 12);
            ExitAdminButton.Name = "ExitAdminButton";
            ExitAdminButton.Size = new Size(75, 23);
            ExitAdminButton.TabIndex = 8;
            ExitAdminButton.Text = "Выйти";
            ExitAdminButton.UseVisualStyleBackColor = true;
            ExitAdminButton.Click += ExitAdminButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 70);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 9;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 108);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "ФИО";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Должность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 190);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 12;
            label5.Text = "Пароль";
            // 
            // COtdelBox
            // 
            COtdelBox.FormattingEnabled = true;
            COtdelBox.Location = new Point(67, 231);
            COtdelBox.Name = "COtdelBox";
            COtdelBox.Size = new Size(181, 23);
            COtdelBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 234);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 14;
            label6.Text = "Отдел";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(473, 203);
            dataGridView1.TabIndex = 15;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(775, 319);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(COtdelBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ExitAdminButton);
            Controls.Add(CComboRole);
            Controls.Add(CFIOBox);
            Controls.Add(CComboLogin);
            Controls.Add(label1);
            Controls.Add(DeleteUsers);
            Controls.Add(CreateUsers);
            Controls.Add(CPasswordBox);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CPasswordBox;
        private Button CreateUsers;
        private Button DeleteUsers;
        private Label label1;
        private ComboBox CComboLogin;
        private TextBox CFIOBox;
        private ComboBox CComboRole;
        private Button ExitAdminButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox COtdelBox;
        private Label label6;
        private DataGridView dataGridView1;
    }
}