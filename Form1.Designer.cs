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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            EnterAutorizButton = new Button();
            Autoriz = new Label();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(259, 128);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(251, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(259, 189);
            PasswordTextBox.Name = "PasswordTextBox";
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
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Autoriz);
            Controls.Add(EnterAutorizButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "Autorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button EnterAutorizButton;
        private Label Autoriz;
    }
}
