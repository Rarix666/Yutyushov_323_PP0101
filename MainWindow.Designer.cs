namespace WorkerApp
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            ClickPictureProfile = new PictureBox();
            OtzClick = new Label();
            ChatClick = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ExitButtonMain = new Button();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ClickPictureProfile
            // 
            ClickPictureProfile.Image = (Image)resources.GetObject("ClickPictureProfile.Image");
            ClickPictureProfile.Location = new Point(26, 12);
            ClickPictureProfile.Name = "ClickPictureProfile";
            ClickPictureProfile.Size = new Size(100, 88);
            ClickPictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            ClickPictureProfile.TabIndex = 0;
            ClickPictureProfile.TabStop = false;
            ClickPictureProfile.Click += ClickPictureProfile_Click;
            // 
            // OtzClick
            // 
            OtzClick.AutoSize = true;
            OtzClick.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OtzClick.Location = new Point(168, 12);
            OtzClick.Name = "OtzClick";
            OtzClick.Size = new Size(138, 32);
            OtzClick.TabIndex = 1;
            OtzClick.Text = "Заявление";
            OtzClick.Click += OtzClick_Click;
            // 
            // ChatClick
            // 
            ChatClick.AutoSize = true;
            ChatClick.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChatClick.Location = new Point(321, 12);
            ChatClick.Name = "ChatClick";
            ChatClick.Size = new Size(55, 32);
            ChatClick.TabIndex = 2;
            ChatClick.Text = "Чат";
            ChatClick.Click += ChatClick_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 189);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(222, 158);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 4;
            label1.Text = "Задачи";
            // 
            // ExitButtonMain
            // 
            ExitButtonMain.Location = new Point(396, 12);
            ExitButtonMain.Name = "ExitButtonMain";
            ExitButtonMain.Size = new Size(75, 23);
            ExitButtonMain.TabIndex = 5;
            ExitButtonMain.Text = "Выход";
            ExitButtonMain.UseVisualStyleBackColor = true;
            ExitButtonMain.Click += ExitButtonMain_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 6;
            label2.Text = "Личный кабинет";
            label2.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(483, 387);
            Controls.Add(label2);
            Controls.Add(ExitButtonMain);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(ChatClick);
            Controls.Add(OtzClick);
            Controls.Add(ClickPictureProfile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClickPictureProfile;
        private Label OtzClick;
        private Label ChatClick;
        private DataGridView dataGridView1;
        private Label label1;
        private Button ExitButtonMain;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
    }
}