namespace WorkerApp
{
    partial class ChatForm
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
            comboBoxPeopleChat = new ComboBox();
            listBox1 = new ListBox();
            chatTextBox = new TextBox();
            EnterChatButton = new Button();
            SuspendLayout();
            // 
            // comboBoxPeopleChat
            // 
            comboBoxPeopleChat.FormattingEnabled = true;
            comboBoxPeopleChat.Location = new Point(44, 27);
            comboBoxPeopleChat.Name = "comboBoxPeopleChat";
            comboBoxPeopleChat.Size = new Size(121, 23);
            comboBoxPeopleChat.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(44, 72);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(364, 244);
            listBox1.TabIndex = 1;
            // 
            // chatTextBox
            // 
            chatTextBox.Location = new Point(44, 360);
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(287, 23);
            chatTextBox.TabIndex = 2;
            // 
            // EnterChatButton
            // 
            EnterChatButton.Location = new Point(333, 360);
            EnterChatButton.Name = "EnterChatButton";
            EnterChatButton.Size = new Size(75, 23);
            EnterChatButton.TabIndex = 3;
            EnterChatButton.Text = "Отправить";
            EnterChatButton.UseVisualStyleBackColor = true;
            EnterChatButton.Click += EnterChatButton_Click;
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 450);
            Controls.Add(EnterChatButton);
            Controls.Add(chatTextBox);
            Controls.Add(listBox1);
            Controls.Add(comboBoxPeopleChat);
            Name = "ChatForm";
            Text = "Чат";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private TextBox chatTextBox;
        private Button EnterChatButton;
        public ComboBox comboBoxPeopleChat;
    }
}