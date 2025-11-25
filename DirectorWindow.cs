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

namespace WorkerApp
{
    public partial class DirectorWindow : Form
    {
        public DirectorWindow()
        {
            InitializeComponent();
        }

        private void ClickPictureProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void ExitButtonMain_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private async void ChatClickDirector_Click(object sender, EventArgs e)
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

        public void ClearBox()
        {
            LoginBox.Text = "";
            NameAdminTextBox.Text = "";
            PasswordAdminTextBox.Text = "";
        }
        private async void CreateAdminButton_Click(object sender, EventArgs e)
        {
            string clogin = LoginBox.Text;
            string cname = NameAdminTextBox.Text;
            string crole = "admin";
            string cpassword = PasswordAdminTextBox.Text;
            string cposts = "Административный";
            if (clogin == "" || cpassword == "" || cname == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool result = await AppState.Supabase.CreateUser(clogin, cname, crole, cpassword, cposts);
            if (result)
            {
                MessageBox.Show("Пользователь успешно добавлен!");
                ClearBox();
            }
            else
            {
                MessageBox.Show("Такой администратор уже существует");
            }
        }

        private async void DeleteAdminButton_Click(object sender, EventArgs e)
        {
            string dlogin = LoginBox.Text;
            if (LoginBox.Text == "")
            {
                MessageBox.Show("Заполните поле логина!");
                return;
            }
            bool result = await AppState.Supabase.DeleteUser(dlogin);
            if (result)
            {
                MessageBox.Show("Пользователь успешно удалён!");
                ClearBox();
            }
            else
            {
                MessageBox.Show("Ошибка при удалении пользователя");
            }
        }

        private void EnterDepartments_Click(object sender, EventArgs e)
        {
            TaskDepartment task = new TaskDepartment();
            task.Show();
            this.Hide();
        }

        private async void DirectorWindow_Load(object sender, EventArgs e)
        {
            SupabaseClient client = new SupabaseClient();

            try
            {
                bool success = await client.ComboboxUsersDirector();
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

                LoginBox.DataSource = null;
                LoginBox.DataSource = displayList;
                LoginBox.DisplayMember = "Display";
                LoginBox.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки пользователей: {ex.Message}");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка загрузки combobox {ex}\n");
            }
        }
    }
}
