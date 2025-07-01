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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CPasswordBox
            // 
            CPasswordBox.Location = new Point(67, 214);
            CPasswordBox.Name = "CPasswordBox";
            CPasswordBox.Size = new Size(181, 23);
            CPasswordBox.TabIndex = 1;
            // 
            // CreateUsers
            // 
            CreateUsers.Location = new Point(80, 259);
            CreateUsers.Name = "CreateUsers";
            CreateUsers.Size = new Size(75, 23);
            CreateUsers.TabIndex = 2;
            CreateUsers.Text = "Создать";
            CreateUsers.UseVisualStyleBackColor = true;
            CreateUsers.Click += CreateUsers_Click;
            // 
            // DeleteUsers
            // 
            DeleteUsers.Location = new Point(161, 259);
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
            label1.Location = new Point(67, 44);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 4;
            label1.Text = "Пользователи";
            // 
            // CComboLogin
            // 
            CComboLogin.FormattingEnabled = true;
            CComboLogin.Location = new Point(67, 98);
            CComboLogin.Name = "CComboLogin";
            CComboLogin.Size = new Size(181, 23);
            CComboLogin.TabIndex = 5;
            // 
            // CFIOBox
            // 
            CFIOBox.Location = new Point(67, 138);
            CFIOBox.Name = "CFIOBox";
            CFIOBox.Size = new Size(181, 23);
            CFIOBox.TabIndex = 6;
            // 
            // CComboRole
            // 
            CComboRole.FormattingEnabled = true;
            CComboRole.Items.AddRange(new object[] { "worker", "admin" });
            CComboRole.Location = new Point(67, 176);
            CComboRole.Name = "CComboRole";
            CComboRole.Size = new Size(181, 23);
            CComboRole.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(431, 233);
            dataGridView1.TabIndex = 8;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 319);
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
    }
}