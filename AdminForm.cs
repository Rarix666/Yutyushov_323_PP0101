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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private async void CreateUsers_Click(object sender, EventArgs e) //Кнопка добавления пользователей
        {
            string clogin = CComboLogin.Text;
            string cname = CFIOBox.Text;
            string crole = CComboRole.Text;
            string cpassword = CPasswordBox.Text;
            if (clogin == "" || cpassword == "" || cname == "" || crole == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool result = await AppState.Supabase.CreateUser(clogin, cname, crole, cpassword);
            if (result)
            {
                MessageBox.Show("Пользователь успешно добавлен!");
                ClearBox();
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении пользователя");
            }
        }

        private async void DeleteUsers_Click(object sender, EventArgs e) //Кнопка удаления пользователей
        {
            string dlogin = CComboLogin.Text;
            if (CComboLogin.Text == "")
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

        public void ClearBox()
        {
            CComboLogin.Text = "";
            CFIOBox.Text = "";
            CComboRole.Text = "";
            CPasswordBox.Text = "";
        }

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
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void ExitAdminButton_Click(object sender, EventArgs e) //Выйход из аккаунта
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }
    }
}
