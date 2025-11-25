namespace WorkerApp
{
    partial class ManagerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerWindow));
            ClickPictureProfile = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ChatClickManager = new Label();
            WorkersManager = new Label();
            ExitButtonMain = new Button();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ClickPictureProfile
            // 
            ClickPictureProfile.Image = (Image)resources.GetObject("ClickPictureProfile.Image");
            ClickPictureProfile.Location = new Point(29, 23);
            ClickPictureProfile.Name = "ClickPictureProfile";
            ClickPictureProfile.Size = new Size(100, 88);
            ClickPictureProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            ClickPictureProfile.TabIndex = 1;
            ClickPictureProfile.TabStop = false;
            ClickPictureProfile.Click += ClickPictureProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(302, 134);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 6;
            label1.Text = "Задачи отдела";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(131, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 189);
            dataGridView1.TabIndex = 5;
            // 
            // ChatClickManager
            // 
            ChatClickManager.AutoSize = true;
            ChatClickManager.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChatClickManager.Location = new Point(382, 23);
            ChatClickManager.Name = "ChatClickManager";
            ChatClickManager.Size = new Size(55, 32);
            ChatClickManager.TabIndex = 7;
            ChatClickManager.Text = "Чат";
            ChatClickManager.Click += ChatClickManager_Click;
            // 
            // WorkersManager
            // 
            WorkersManager.AutoSize = true;
            WorkersManager.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WorkersManager.Location = new Point(171, 23);
            WorkersManager.Name = "WorkersManager";
            WorkersManager.Size = new Size(155, 32);
            WorkersManager.TabIndex = 8;
            WorkersManager.Text = "Сотрудники";
            WorkersManager.Click += WorkersManager_Click;
            // 
            // ExitButtonMain
            // 
            ExitButtonMain.Location = new Point(508, 23);
            ExitButtonMain.Name = "ExitButtonMain";
            ExitButtonMain.Size = new Size(75, 23);
            ExitButtonMain.TabIndex = 9;
            ExitButtonMain.Text = "Выход";
            ExitButtonMain.UseVisualStyleBackColor = true;
            ExitButtonMain.Click += ExitButtonMain_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 10;
            label3.Text = "Личный кабинет";
            label3.Click += label3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ManagerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 363);
            Controls.Add(label3);
            Controls.Add(ExitButtonMain);
            Controls.Add(WorkersManager);
            Controls.Add(ChatClickManager);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(ClickPictureProfile);
            Name = "ManagerWindow";
            Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClickPictureProfile;
        private Label label1;
        private DataGridView dataGridView1;
        private Label ChatClickManager;
        private Label WorkersManager;
        private Button ExitButtonMain;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
    }
}