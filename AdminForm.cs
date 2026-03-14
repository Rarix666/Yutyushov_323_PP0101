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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadUserWorkerData();
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Пункты меню
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Удалить");

            // Обработчики событий
            deleteItem.Click += deleteMenuItem_Click;

            // Элементы в меню
            contextMenu.Items.AddRange(new ToolStripItem[]
            {
                deleteItem
            });

            // Привязка контекстного меню
            dataGridView1.ContextMenuStrip = contextMenu;
        }

        private async void deleteMenuItem_Click(object sender, EventArgs e)
        {
            await DeleteSelectedRowUser();
        } //Метод контекстного меню для удаления пользователя

        private async Task DeleteSelectedRowUser()
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int selectedRowIndex = dataGridView1.CurrentRow.Index;

                    var dlogin = dataGridView1.Rows[selectedRowIndex].Cells["loginColumn"].Value?.ToString();

                    var selectedUser = AppState.infoAdmin.FirstOrDefault(w =>
                        w.login == dlogin);

                    if (selectedUser != null)
                    {
                        bool success = await AppState.Supabase.DeleteUser(selectedUser.login);

                        if (success)
                        {
                            MessageBox.Show($"Пользователь успешно удалён");
                            File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Администратор {AppState.CurrentUser.name} удалил пользователя с логином: {dlogin}\n");
                            LoadUserWorkerData();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при удалении пользователя");
                            File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |WARN| - Ошибка при удалении пользователя\n");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти пользователя");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                    File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |WARN| - Ошибка блока администратора при удалении: {ex}\n");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку");
            }
        } //Метод удаления пользователя

        private async void CreateUsers_Click(object sender, EventArgs e) //Кнопка добавления пользователей
        {
            string clogin = CComboLogin.Text;
            string cname = CFIOBox.Text;
            string crole = CComboRole.Text;
            string cpassword = CPasswordBox.Text;
            string cposts = COtdelBox.Text;
            if (clogin == "" || cpassword == "" || cname == "" || crole == "" || cposts == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool result = await AppState.Supabase.CreateUser(clogin, cname, crole, cpassword, cposts);
            if (result)
            {
                MessageBox.Show("Пользователь успешно добавлен!");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Администратор {AppState.CurrentUser.name} добавил пользователя с данными: {clogin}, {cpassword}, {cname}, {crole}, {cposts}\n");
                LoadUserWorkerData();
                ClearBox();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |WARN| - Ошибка при добавлении пользователя\n");
            }
        }

        public void ClearBox()
        {
            CComboLogin.Text = "";
            CFIOBox.Text = "";
            CComboRole.Text = "";
            CPasswordBox.Text = "";
            COtdelBox.Text = "";
        } //Метод очищения полей

        private async void AdminForm_Load(object sender, EventArgs e) //Добавление данных в combobox для облегчения управления пользователями
        {
            SupabaseClient client = new SupabaseClient();

            try
            {
                bool success = await client.ComboboxUsers();
                if (!success)
                {
                    MessageBox.Show("Ошибка загрузки пользователей");
                    return;
                }

                var usersData = AppState.UsersData;

                if (usersData == null || usersData.Count == 0)
                {
                    MessageBox.Show("Нет данных для отображения");
                    return;
                }

                var displayList = usersData.Select(u => new
                {
                    Display = u.login,
                    Value = u.id
                }).ToList();

                CComboLogin.DataSource = null;
                CComboLogin.DataSource = displayList;
                CComboLogin.DisplayMember = "Display";
                CComboLogin.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки пользователей: {ex.Message}");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка при загрузке combobox {ex}\n");
            }

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

                COtdelBox.DataSource = null;
                COtdelBox.DataSource = displayLists;
                COtdelBox.DisplayMember = "Display";
                COtdelBox.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки отделов: {ex.Message}");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка при загрузке combobox {ex}\n");
            }
        }

        private void ConfigureDataGridView() //Постройка конфигурации datagrid
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn //Настройка столбцов
            {
                Name = "loginColumn",
                DataPropertyName = "login",
                HeaderText = "Логин",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "passwordColumn",
                DataPropertyName = "password",
                HeaderText = "Пароль",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "roleColumn",
                DataPropertyName = "role",
                HeaderText = "Должность",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "nameColumn",
                DataPropertyName = "name",
                HeaderText = "ФИО",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "birthdayColumn",
                DataPropertyName = "birthday",
                HeaderText = "Дата рождения",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "postsColumn",
                DataPropertyName = "posts",
                HeaderText = "Отдел",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "mailColumn",
                DataPropertyName = "mail",
                HeaderText = "Почта",
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
                bool success = await AppState.Supabase.InfoForAdmin();

                if (!success || AppState.infoAdmin == null)
                {
                    MessageBox.Show("Ошибка загрузки данных");
                    return;
                }

                // Фильтрация данных
                var userDataAdmin = AppState.infoAdmin
                    .ToList();

                var table = new DataTable();
                table.Columns.Add("login", typeof(string));
                table.Columns.Add("password", typeof(string));
                table.Columns.Add("role", typeof(string));
                table.Columns.Add("name", typeof(string));
                table.Columns.Add("birthday", typeof(string));
                table.Columns.Add("posts", typeof(string));
                table.Columns.Add("mail", typeof(string));

                foreach (var workers in userDataAdmin)
                {
                    table.Rows.Add(workers.login, workers.password, workers.role, workers.name, workers.birthday, workers.posts, workers.mail);
                }

                dataGridView1.DataSource = table;

                dataGridView1.Refresh();

                dataGridView1.ClearSelection();
                dataGridView1.FirstDisplayedScrollingRowIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка блока администрации: {ex}\n");
            }
        }

        private void ExitAdminButton_Click(object sender, EventArgs e) //Выйход из аккаунта
        {
            File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Администратор {AppState.CurrentUser.name} вышел из аккаунта\n");
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private async void UpdateUserButton_Click(object sender, EventArgs e)
        {
            string ulogin = CComboLogin.Text;
            string uname = CFIOBox.Text;
            string upassword = CPasswordBox.Text;
            string urole = CComboRole.Text; 
            string uposts = COtdelBox.Text;
            if (ulogin == "" || uname == "" || upassword == "" || urole == "" || uposts == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            bool result = await AppState.Supabase.UpdateUserAdmin(ulogin, uname, upassword, urole, uposts);
            if (result)
            {
                MessageBox.Show($"Данные успешно пользователя {ulogin} обновлены");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Администратор {AppState.CurrentUser.name} обновил данные пользователя {ulogin}\n");
                ClearBox();
                LoadUserWorkerData();
            }
            else
            {
                MessageBox.Show("Ошибка обновления данных");
            }
        } //Обновление данных пользователя
    }
}
