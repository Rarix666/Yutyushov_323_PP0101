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
    public partial class ManagerWindow : Form
    {
        public ManagerWindow()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadUserWorkerData();

            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Пункты меню
            ToolStripMenuItem doneItem = new ToolStripMenuItem("Выполнено");
            ToolStripMenuItem ProcessItem = new ToolStripMenuItem("В процессе");

            // Обработчики событий
            doneItem.Click += doneMenuItem_Click;
            ProcessItem.Click += ProcessMenuItem_Click;

            // Элементы в меню
            contextMenu.Items.AddRange(new ToolStripItem[]
            {
                doneItem, ProcessItem
            });

            // Привязка контекстного меню
            dataGridView1.ContextMenuStrip = contextMenu;
        }
        private async void doneMenuItem_Click(object sender, EventArgs e)
        {
            await UpdateSelectedRowStatus("Выполнено");
        } //Метод контекстного меню для изменения статуса задачи на "Выполнено"

        private async void ProcessMenuItem_Click(object sender, EventArgs e)
        {
            await UpdateSelectedRowStatus("В процессе");
        } //Метод контекстного меню для изменения статуса задачи на "В процессе"

        private void ClickPictureProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        } //Переход в профиль по картинке

        private void label3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        } //Переход в профиль по текстовой подсказке

        private void ExitButtonMain_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        } //Выход в окно авторизации

        private async void ChatClickManager_Click(object sender, EventArgs e)
        {
            SupabaseClient client = new SupabaseClient();
            List<UsersObject> usersData = null;

            bool success = await client.ComboboxUsers();
            if (success)
            {
                usersData = AppState.UsersData;
            }
            else
            {
                MessageBox.Show("Ошибка загрузки пользователей");
            }

            if (usersData != null)
            {
                ChatForm chatForm = new ChatForm(usersData);
                chatForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка: Данные не загружены");
            }
        } //Переход в окно чата

        private void WorkersManager_Click(object sender, EventArgs e)
        {
            TaskEmployee employee = new TaskEmployee();
            employee.Show();
            this.Hide();
        } //Переход в окно сотрудники

        private void ConfigureDataGridView() //Постройка конфигурации datagrid
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "taskColumn",
                DataPropertyName = "task",
                HeaderText = "Задача",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "deadlineColumn",
                DataPropertyName = "deadline",
                HeaderText = "Дедлайн",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private async void LoadUserWorkerData() //Загрузка данных в datagrid
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
                var userData = AppState.infoManager
                    .Where(w => w.department == AppState.CurrentUser.posts)
                    .ToList();

                var table = new DataTable();
                table.Columns.Add("task", typeof(string));
                table.Columns.Add("deadline", typeof(string));

                foreach (var manager in userData)
                {
                    table.Rows.Add(manager.task, manager.deadline);
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

        private async Task UpdateSelectedRowStatus(string newStatus)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int selectedRowIndex = dataGridView1.CurrentRow.Index;

                    // Получаем данные из выбранной строки DataGridView
                    var task = dataGridView1.Rows[selectedRowIndex].Cells["taskColumn"].Value?.ToString();
                    var deadline = dataGridView1.Rows[selectedRowIndex].Cells["deadlineColumn"].Value?.ToString();

                    // Находим соответствующую запись в AppState.infoManager по данным
                    var selectedWork = AppState.infoManager.FirstOrDefault(w =>
                        w.task == task &&
                        w.deadline == deadline);

                    if (selectedWork != null)
                    {
                        // Обновление статуса в Supabase
                        bool success = await AppState.Supabase.UpdateStatusTaskManager(selectedWork.id, newStatus);

                        if (success)
                        {
                            selectedWork.status = newStatus;
                            MessageBox.Show($"Статус задачи обновлен на: {newStatus}");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при обновлении статуса задачи");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти соответствующую задачу в данных");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку");
            }
        } //Метод обновления статуса
    }
}
