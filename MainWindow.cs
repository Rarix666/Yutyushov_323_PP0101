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
    public partial class MainWindow : Form
    {
        public MainWindow()
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
        private async Task UpdateSelectedRowStatus(string newStatus)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int selectedRowIndex = dataGridView1.CurrentRow.Index;

                    // Получаем данные из выбранной строки DataGridView
                    var salary = dataGridView1.Rows[selectedRowIndex].Cells["salaryColumn"].Value?.ToString();
                    var worknum = dataGridView1.Rows[selectedRowIndex].Cells["worknumColumn"].Value?.ToString();

                    var selectedWork = AppState.infowork.FirstOrDefault(w =>
                        w.salary == salary &&
                        w.worknum == worknum &&
                        w.user_id == AppState.CurrentUser.id);

                    if (selectedWork != null)
                    {
                        bool success = await AppState.Supabase.UpdateStatusTask(selectedWork.id, newStatus);

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
        private void ClickPictureProfile_Click(object sender, EventArgs e) //Кнопка перехода на форму профиля
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void OtzClick_Click(object sender, EventArgs e) //Кнопка перехода на форму "Отчёт"
        {
            Feedback feedback = new Feedback();
            feedback.Show();
            this.Hide();
        }

        private async void ChatClick_Click(object sender, EventArgs e) //Кнопка перехода на форму чата, с подгрузкой данных в combobox
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
        }

        private void ConfigureDataGridView() //Постройка конфигурации datagrid
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "salaryColumn",
                DataPropertyName = "salary",
                HeaderText = "Задача",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 80
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "worknumColumn",
                DataPropertyName = "worknum",
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
                bool success = await AppState.Supabase.WorkerInform();

                if (!success || AppState.infowork == null)
                {
                    MessageBox.Show("Ошибка загрузки данных");
                    return;
                }

                // Фильтрация данных
                var userData = AppState.infowork
                    .Where(w => w.user_id == AppState.CurrentUser.id)
                    .ToList();

                var table = new DataTable();
                table.Columns.Add("salary", typeof(string));
                table.Columns.Add("worknum", typeof(string));

                foreach (var worker in userData)
                {
                    table.Rows.Add(worker.salary, worker.worknum);
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

        private void ExitButtonMain_Click(object sender, EventArgs e) //Кнопка выхода
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e) //Переход в профиль по текстовой подсказке
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
