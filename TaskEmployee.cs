using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WorkerApp
{
    public partial class TaskEmployee : Form
    {
        public TaskEmployee()
        {
            InitializeComponent();
            LoadDepartmentUsersAsync();
            ConfigureDataGridView();
            LoadUserWorkerData();
        }

        private async void LoadDepartmentUsersAsync()
        {
            try
            {
                string managerDepartment = AppState.CurrentUser?.posts;
                long currentUserId = AppState.CurrentUser?.id ?? 0;

                if (string.IsNullOrEmpty(managerDepartment))
                {
                    MessageBox.Show("Не удалось определить отдел менеджера");
                    return;
                }

                var departmentUsers = await AppState.Supabase.GetDepartmentUsers(managerDepartment, currentUserId);

                if (departmentUsers == null || departmentUsers.Count == 0)
                {
                    MessageBox.Show($"В отделе '{managerDepartment}' нет других сотрудников");
                    return;
                }

                comboboxEmployee.DataSource = null;
                comboboxEmployee.DisplayMember = "name";
                comboboxEmployee.ValueMember = "id";
                comboboxEmployee.DataSource = departmentUsers;

                comboboxEmployee.SelectedIndexChanged -= ComboBoxEmployees_SelectedIndexChanged;
                comboboxEmployee.SelectedIndexChanged += ComboBoxEmployees_SelectedIndexChanged;

                if (comboboxEmployee.Items.Count > 0)
                {
                    comboboxEmployee.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} - Ошибка при загрузке данных в combobox метода LoadDepartmentUsersAsync в TaskEmployee\n");
            }
        }

        private void ComboBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboboxEmployee.SelectedItem is UserData selectedUser)
            {
                FIOLabelM.Text = selectedUser.name ?? "Не указано";
                BirthdayLabelM.Text = selectedUser.birthday != DateTime.MinValue
                    ? selectedUser.birthday.ToString("dd.MM.yyyy")
                    : "Не указано";
                GroupLabelM.Text = selectedUser.posts ?? "Не указано";
                PostLabelM.Text = selectedUser.role ?? "Не указано";
                MailLabelM.Text = selectedUser.mail ?? "Не указано";
                LoadUserWorkerData();
            }
        } //Метод заполнения label используя id из combobox

        private void ExitButtonEmployee_Click(object sender, EventArgs e)
        {
            ManagerWindow manager = new ManagerWindow();
            manager.Show();
            this.Hide();
            File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} - Выход из окна сотрудников\n");
        } //Кнопка выхода

        private async void SendTaskManager_Click(object sender, EventArgs e)
        {
            int cuser_id = (int)comboboxEmployee.SelectedValue;
            string csalary = Task_description.Text;
            string cworknum = DeadLine.Text;
            if (cuser_id == null || csalary == "" || cworknum == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool result = await AppState.Supabase.CreateTaskEmployee(cuser_id, csalary, cworknum);
            if (result)
            {
                MessageBox.Show("Задача отправлена сотруднику для дальнейшего выполнения");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} - Добавлена задача сотруднику c ID {cuser_id}\n");
                LoadUserWorkerData();
                Task_description.Text = "";
                DeadLine.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка при отправке задачи");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} - Ошибка при выполнении метода отправки задачи\n");
            }
        } //Отправление задач сотрудникам

        private void ConfigureDataGridView() //Постройка конфигурации datagrid
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "salaryColumn",
                DataPropertyName = "salary",
                HeaderText = "Задача",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "worknumColumn",
                DataPropertyName = "worknum",
                HeaderText = "Дедлайн",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "statusColumn",
                DataPropertyName = "status",
                HeaderText = "Статус выполнения",
                ReadOnly = true
            });

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private async void LoadUserWorkerData() //Загрузка данных в datagrid
        {
            try
            {
                // Загрузка данных
                bool success = await AppState.Supabase.WorkerInform();

                if (!success || AppState.infowork == null)
                {
                    MessageBox.Show("Ошибка загрузки данных");
                    return;
                }

                if (comboboxEmployee.SelectedValue == null) return;
                // Фильтрация данных
                var userData = AppState.infowork
                    .Where(w => w.user_id == (int)comboboxEmployee.SelectedValue)
                    .ToList();

                var table = new DataTable();
                table.Columns.Add("salary", typeof(string));
                table.Columns.Add("worknum", typeof(string));
                table.Columns.Add("status", typeof(string));

                foreach (var worker in userData)
                {
                    table.Rows.Add(worker.salary, worker.worknum, worker.status);
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
    }
}
