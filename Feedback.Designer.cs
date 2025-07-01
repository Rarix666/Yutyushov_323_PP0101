namespace WorkerApp
{
    partial class Feedback
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
            FeedbackLabel = new Label();
            FeedbackFIO = new TextBox();
            richTextFeedback = new RichTextBox();
            EnterFeedback = new Button();
            ExitFeedbeckButton = new Button();
            TipFIO = new Label();
            SuspendLayout();
            // 
            // FeedbackLabel
            // 
            FeedbackLabel.AutoSize = true;
            FeedbackLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FeedbackLabel.Location = new Point(120, 19);
            FeedbackLabel.Name = "FeedbackLabel";
            FeedbackLabel.Size = new Size(175, 30);
            FeedbackLabel.TabIndex = 0;
            FeedbackLabel.Text = "Оставить отзыв";
            // 
            // FeedbackFIO
            // 
            FeedbackFIO.Location = new Point(86, 76);
            FeedbackFIO.Name = "FeedbackFIO";
            FeedbackFIO.Size = new Size(248, 23);
            FeedbackFIO.TabIndex = 1;
            // 
            // richTextFeedback
            // 
            richTextFeedback.Location = new Point(29, 121);
            richTextFeedback.Name = "richTextFeedback";
            richTextFeedback.Size = new Size(370, 259);
            richTextFeedback.TabIndex = 2;
            richTextFeedback.Text = "";
            // 
            // EnterFeedback
            // 
            EnterFeedback.Location = new Point(171, 399);
            EnterFeedback.Name = "EnterFeedback";
            EnterFeedback.Size = new Size(75, 23);
            EnterFeedback.TabIndex = 3;
            EnterFeedback.Text = "Отправить";
            EnterFeedback.UseVisualStyleBackColor = true;
            EnterFeedback.Click += EnterFeedback_Click;
            // 
            // ExitFeedbeckButton
            // 
            ExitFeedbeckButton.Location = new Point(340, 12);
            ExitFeedbeckButton.Name = "ExitFeedbeckButton";
            ExitFeedbeckButton.Size = new Size(75, 23);
            ExitFeedbeckButton.TabIndex = 4;
            ExitFeedbeckButton.Text = "Выйти";
            ExitFeedbeckButton.UseVisualStyleBackColor = true;
            ExitFeedbeckButton.Click += ExitFeedbeckButton_Click;
            // 
            // TipFIO
            // 
            TipFIO.AutoSize = true;
            TipFIO.Location = new Point(46, 79);
            TipFIO.Name = "TipFIO";
            TipFIO.Size = new Size(34, 15);
            TipFIO.TabIndex = 5;
            TipFIO.Text = "ФИО";
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(TipFIO);
            Controls.Add(ExitFeedbeckButton);
            Controls.Add(EnterFeedback);
            Controls.Add(richTextFeedback);
            Controls.Add(FeedbackFIO);
            Controls.Add(FeedbackLabel);
            Name = "Feedback";
            Text = "Отправить отзыв";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FeedbackLabel;
        private TextBox FeedbackFIO;
        private RichTextBox richTextFeedback;
        private Button EnterFeedback;
        private Button ExitFeedbeckButton;
        private Label TipFIO;
    }
}