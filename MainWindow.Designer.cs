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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            ClickPictureProfile = new PictureBox();
            OtzClick = new Label();
            ChatClick = new Label();
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).BeginInit();
            SuspendLayout();
            // 
            // ClickPictureProfile
            // 
            ClickPictureProfile.Image = (Image)resources.GetObject("ClickPictureProfile.Image");
            ClickPictureProfile.Location = new Point(12, 12);
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
            OtzClick.Location = new Point(163, 25);
            OtzClick.Name = "OtzClick";
            OtzClick.Size = new Size(218, 32);
            OtzClick.TabIndex = 1;
            OtzClick.Text = "Отправить отзыв";
            OtzClick.Click += OtzClick_Click;
            // 
            // ChatClick
            // 
            ChatClick.AutoSize = true;
            ChatClick.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChatClick.Location = new Point(233, 99);
            ChatClick.Name = "ChatClick";
            ChatClick.Size = new Size(55, 32);
            ChatClick.TabIndex = 2;
            ChatClick.Text = "Чат";
            ChatClick.Click += ChatClick_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 209);
            Controls.Add(ChatClick);
            Controls.Add(OtzClick);
            Controls.Add(ClickPictureProfile);
            Name = "MainWindow";
            Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)ClickPictureProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClickPictureProfile;
        private Label OtzClick;
        private Label ChatClick;
    }
}