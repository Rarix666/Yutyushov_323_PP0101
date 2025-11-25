using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerApp
{
    public partial class TaskDepartment : Form
    {
        public TaskDepartment()
        {
            InitializeComponent();
            LoadDepartmentAsync();
            ConfigureDataGridView1();
            LoadUserWorkerData1();
            ConfigureDataGridView2();
            LoadUserWorkerData2();
        }
        private async void LoadDepartmentAsync()
        {
            SupabaseClient client = new SupabaseClient();
            try
            {
                bool success = await client.ComboboxDepartment();
                if (!success)
                {
                    MessageBox.Show("Ошибка загрузки отделов");
                    return;
                }

                var DepartmentsData = AppState.DepartmentData;

                if (DepartmentsData == null || DepartmentsData.Count == 0)
                {
                    MessageBox.Show("Нет данных для отображения");
                    return;
                }

                var displayLists = DepartmentsData.Select(u => new
                {
                    Display = u.department,
                    Value = u.id
                }).ToList();

                TaskDepartmentComb.DataSource = null;
                TaskDepartmentComb.DataSource = displayLists;
                TaskDepartmentComb.DisplayMember = "Display";
                TaskDepartmentComb.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки отделов: {ex.Message}");
            }
        } //Загрузка отделов в combobox
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DirectorWindow director = new DirectorWindow();
            director.Show();
            this.Hide();
        } //Кнопка выхода

        private async void CreateDepartmentButton_Click(object sender, EventArgs e)
        {
            string cdepartment = NameDepartmentTextBox.Text;
            if (cdepartment == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool result = await AppState.Supabase.CreateDepartment(cdepartment);
            if (result)
            {
                MessageBox.Show("Отдел успешно добавлен!");
                NameDepartmentTextBox.Text = "";
                LoadUserWorkerData1();
                LoadDepartmentAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении отдела");
            }
        } //Добавление нового отдела

        private async void DeleteDepartmentButton_Click(object sender, EventArgs e)
        {
            string ddepartment = NameDepartmentTextBox.Text;
            if (ddepartment == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool result = await AppState.Supabase.DeleteDepartment(ddepartment);
            if (result)
            {
                MessageBox.Show("Отдел успешно удалён!");
                NameDepartmentTextBox.Text = "";
                LoadUserWorkerData1();
                LoadDepartmentAsync();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении отдела");
            }
        } //Удаление отдела

        private void ConfigureDataGridView1() //Постройка конфигурации datagrid для отделов
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "departmentColumn",
                DataPropertyName = "departments",
                HeaderText = "Отдел",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 100
            });

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private async void LoadUserWorkerData1() //Загрузка данных в datagrid для отделов
        {
            try
            {
                // Загрузка данных
                bool success = await AppState.Supabase.ComboboxDepartment();

                if (!success || AppState.DepartmentData == null)
                {
                    MessageBox.Show("Ошибка загрузки данных");
                    return;
                }

                // Фильтрация данных
                var userDataAdmin = AppState.DepartmentData
                    .ToList();

                var table = new DataTable();
                table.Columns.Add("departments", typeof(string));

                foreach (var departments in userDataAdmin)
                {
                    table.Rows.Add(departments.department);
                }

                dataGridView1.DataSource = table;

                dataGridView1.Refresh();

                dataGridView1.ClearSelection();
                dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private async void CreateTaskDepartmentButton_Click(object sender, EventArgs e)
        {
            string cdepartment = TaskDepartmentComb.Text;
            string ctask = richTextBox1.Text;
            string cdeadline = DeadLineTextBox.Text;
            if (cdepartment == null || ctask == "" || cdeadline == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool result = await AppState.Supabase.CreateTaskDepartment(cdepartment, ctask, cdeadline);
            if (result)
            {
                MessageBox.Show("Задача отправлена отделу для дальнейшего выполнения");
                LoadUserWorkerData2();
                richTextBox1.Text = "";
                DeadLineTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка при отправке задачи");
            }
        } //Добавление задач отделам
        private void ConfigureDataGridView2() //Постройка конфигурации datagrid об отделах
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "departmentColumn",
                DataPropertyName = "department",
                HeaderText = "Отдел",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "taskColumn",
                DataPropertyName = "task",
                HeaderText = "Задача",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 40
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "deadlineColumn",
                DataPropertyName = "deadline",
                HeaderText = "Дата выполнения",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "statusColumn",
                DataPropertyName = "status",
                HeaderText = "Статус выполнения",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });

            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private async void LoadUserWorkerData2() //Загрузка данных в datagrid об отделах
        {
            try
            {
                // Загрузка данных
                bool success = await AppState.Supabase.ManagerInform();

                if (!success || AppState.infoManager == null)
                {
                    MessageBox.Show("Ошибка загрузки данных");
                    return;
                }

                // Фильтрация данных
                var userDataManager = AppState.infoManager
                    .ToList();

                var table = new DataTable();
                table.Columns.Add("department", typeof(string));
                table.Columns.Add("task", typeof(string));
                table.Columns.Add("deadline", typeof(string));
                table.Columns.Add("status", typeof(string));

                foreach (var departments in userDataManager)
                {
                    table.Rows.Add(departments.department, departments.task, departments.deadline, departments.status);
                }

                dataGridView2.DataSource = table;

                dataGridView2.Refresh();

                dataGridView2.ClearSelection();
                dataGridView2.FirstDisplayedScrollingRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
