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
    }
}
