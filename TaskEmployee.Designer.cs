namespace WorkerApp
{
    partial class TaskEmployee
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
            label1 = new Label();
            comboboxEmployee = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            DeadLine = new TextBox();
            Task_description = new RichTextBox();
            SendTaskManager = new Button();
            GroupLabelM = new Label();
            MailLabelM = new Label();
            PostLabelM = new Label();
            BirthdayLabelM = new Label();
            FIOLabelM = new Label();
            ExitButtonEmployee = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 0;
            label1.Text = "Выбор сотрудника";
            // 
            // comboboxEmployee
            // 
            comboboxEmployee.FormattingEnabled = true;
            comboboxEmployee.Location = new Point(169, 36);
            comboboxEmployee.Name = "comboboxEmployee";
            comboboxEmployee.Size = new Size(201, 23);
            comboboxEmployee.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 256);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 19;
            label7.Text = "Почта:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 213);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 18;
            label6.Text = "Должность:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 174);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 17;
            label5.Text = "Отдел:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 138);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 16;
            label4.Text = "Дата рождения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 98);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 15;
            label2.Text = "ФИО:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(555, 70);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 20;
            label3.Text = "Выдать задачу";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 106);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 22;
            label8.Text = "Описание";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 221);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 23;
            label9.Text = "Дата выполнения";
            // 
            // DeadLine
            // 
            DeadLine.Location = new Point(520, 218);
            DeadLine.Name = "DeadLine";
            DeadLine.Size = new Size(198, 23);
            DeadLine.TabIndex = 24;
            // 
            // Task_description
            // 
            Task_description.Location = new Point(520, 106);
            Task_description.Name = "Task_description";
            Task_description.Size = new Size(198, 96);
            Task_description.TabIndex = 25;
            Task_description.Text = "";
            // 
            // SendTaskManager
            // 
            SendTaskManager.Location = new Point(583, 257);
            SendTaskManager.Name = "SendTaskManager";
            SendTaskManager.Size = new Size(75, 23);
            SendTaskManager.TabIndex = 26;
            SendTaskManager.Text = "Отправить";
            SendTaskManager.UseVisualStyleBackColor = true;
            SendTaskManager.Click += SendTaskManager_Click;
            // 
            // GroupLabelM
            // 
            GroupLabelM.AutoSize = true;
            GroupLabelM.Location = new Point(169, 174);
            GroupLabelM.Name = "GroupLabelM";
            GroupLabelM.Size = new Size(40, 15);
            GroupLabelM.TabIndex = 31;
            GroupLabelM.Text = "Пусто";
            // 
            // MailLabelM
            // 
            MailLabelM.AutoSize = true;
            MailLabelM.Location = new Point(169, 256);
            MailLabelM.Name = "MailLabelM";
            MailLabelM.Size = new Size(40, 15);
            MailLabelM.TabIndex = 30;
            MailLabelM.Text = "Пусто";
            // 
            // PostLabelM
            // 
            PostLabelM.AutoSize = true;
            PostLabelM.Location = new Point(169, 213);
            PostLabelM.Name = "PostLabelM";
            PostLabelM.Size = new Size(40, 15);
            PostLabelM.TabIndex = 29;
            PostLabelM.Text = "Пусто";
            // 
            // BirthdayLabelM
            // 
            BirthdayLabelM.AutoSize = true;
            BirthdayLabelM.Location = new Point(169, 138);
            BirthdayLabelM.Name = "BirthdayLabelM";
            BirthdayLabelM.Size = new Size(40, 15);
            BirthdayLabelM.TabIndex = 28;
            BirthdayLabelM.Text = "Пусто";
            // 
            // FIOLabelM
            // 
            FIOLabelM.AutoSize = true;
            FIOLabelM.Location = new Point(169, 98);
            FIOLabelM.Name = "FIOLabelM";
            FIOLabelM.Size = new Size(40, 15);
            FIOLabelM.TabIndex = 27;
            FIOLabelM.Text = "Пусто";
            // 
            // ExitButtonEmployee
            // 
            ExitButtonEmployee.Location = new Point(657, 12);
            ExitButtonEmployee.Name = "ExitButtonEmployee";
            ExitButtonEmployee.Size = new Size(75, 23);
            ExitButtonEmployee.TabIndex = 32;
            ExitButtonEmployee.Text = "Выход";
            ExitButtonEmployee.UseVisualStyleBackColor = true;
            ExitButtonEmployee.Click += ExitButtonEmployee_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 150);
            dataGridView1.TabIndex = 33;
            // 
            // TaskEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 444);
            Controls.Add(dataGridView1);
            Controls.Add(ExitButtonEmployee);
            Controls.Add(GroupLabelM);
            Controls.Add(MailLabelM);
            Controls.Add(PostLabelM);
            Controls.Add(BirthdayLabelM);
            Controls.Add(FIOLabelM);
            Controls.Add(SendTaskManager);
            Controls.Add(Task_description);
            Controls.Add(DeadLine);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboboxEmployee);
            Controls.Add(label1);
            Name = "TaskEmployee";
            Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboboxEmployee;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label9;
        private TextBox DeadLine;
        private RichTextBox Task_description;
        private Button SendTaskManager;
        private Label GroupLabelM;
        private Label MailLabelM;
        private Label PostLabelM;
        private Label BirthdayLabelM;
        private Label FIOLabelM;
        private Button ExitButtonEmployee;
        private DataGridView dataGridView1;
    }
}