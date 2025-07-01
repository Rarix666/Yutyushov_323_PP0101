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
        }

        private void ClickPictureProfile_Click(object sender, EventArgs e) //Кнопка перехода на форму профиля
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void OtzClick_Click(object sender, EventArgs e) //Кнопка перехода на форму "Отзыв"
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
                HeaderText = "Зарплата",
                ReadOnly = true 
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "worknumColumn",
                DataPropertyName = "worknum", 
                HeaderText = "Рабочие числа",
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
    }
}
