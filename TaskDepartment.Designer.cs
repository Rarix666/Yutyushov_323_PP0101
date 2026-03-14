namespace WorkerApp
{
    partial class TaskDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDepartment));
            label1 = new Label();
            NameDepartmentTextBox = new TextBox();
            CreateDepartmentButton = new Button();
            DeleteDepartmentButton = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            DeadLineTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            CreateTaskDepartmentButton = new Button();
            ExitButton = new Button();
            TaskDepartmentComb = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(80, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Регистрация отделов";
            // 
            // NameDepartmentTextBox
            // 
            NameDepartmentTextBox.Location = new Point(69, 46);
            NameDepartmentTextBox.Name = "NameDepartmentTextBox";
            NameDepartmentTextBox.Size = new Size(185, 23);
            NameDepartmentTextBox.TabIndex = 1;
            // 
            // CreateDepartmentButton
            // 
            CreateDepartmentButton.Location = new Point(80, 75);
            CreateDepartmentButton.Name = "CreateDepartmentButton";
            CreateDepartmentButton.Size = new Size(75, 23);
            CreateDepartmentButton.TabIndex = 2;
            CreateDepartmentButton.Text = "Добавить";
            CreateDepartmentButton.UseVisualStyleBackColor = true;
            CreateDepartmentButton.Click += CreateDepartmentButton_Click;
            // 
            // DeleteDepartmentButton
            // 
            DeleteDepartmentButton.Location = new Point(169, 75);
            DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            DeleteDepartmentButton.Size = new Size(75, 23);
            DeleteDepartmentButton.TabIndex = 3;
            DeleteDepartmentButton.Text = "Удалить";
            DeleteDepartmentButton.UseVisualStyleBackColor = true;
            DeleteDepartmentButton.Click += DeleteDepartmentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 49);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Название:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 207);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(98, 154);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Отделы";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(283, 221);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(463, 163);
            dataGridView2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(461, 198);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 8;
            label4.Text = "Задачи отделов";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(471, 23);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 9;
            label5.Text = "Выдача заданий";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(452, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(169, 49);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // DeadLineTextBox
            // 
            DeadLineTextBox.Location = new Point(510, 130);
            DeadLineTextBox.Name = "DeadLineTextBox";
            DeadLineTextBox.Size = new Size(111, 23);
            DeadLineTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 78);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 12;
            label6.Text = "Описание:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 133);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 13;
            label7.Text = "Дата выполнения:";
            // 
            // CreateTaskDepartmentButton
            // 
            CreateTaskDepartmentButton.Location = new Point(496, 159);
            CreateTaskDepartmentButton.Name = "CreateTaskDepartmentButton";
            CreateTaskDepartmentButton.Size = new Size(75, 23);
            CreateTaskDepartmentButton.TabIndex = 14;
            CreateTaskDepartmentButton.Text = "Отправить";
            CreateTaskDepartmentButton.UseVisualStyleBackColor = true;
            CreateTaskDepartmentButton.Click += CreateTaskDepartmentButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(671, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // TaskDepartmentComb
            // 
            TaskDepartmentComb.FormattingEnabled = true;
            TaskDepartmentComb.Location = new Point(452, 46);
            TaskDepartmentComb.Name = "TaskDepartmentComb";
            TaskDepartmentComb.Size = new Size(169, 23);
            TaskDepartmentComb.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(406, 49);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 17;
            label8.Text = "Отдел:";
            // 
            // TaskDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 396);
            Controls.Add(label8);
            Controls.Add(TaskDepartmentComb);
            Controls.Add(ExitButton);
            Controls.Add(CreateTaskDepartmentButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(DeadLineTextBox);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(DeleteDepartmentButton);
            Controls.Add(CreateDepartmentButton);
            Controls.Add(NameDepartmentTextBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TaskDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление отделами";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameDepartmentTextBox;
        private Button CreateDepartmentButton;
        private Button DeleteDepartmentButton;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private TextBox DeadLineTextBox;
        private Label label6;
        private Label label7;
        private Button CreateTaskDepartmentButton;
        private Button ExitButton;
        private ComboBox TaskDepartmentComb;
        private Label label8;
    }
}