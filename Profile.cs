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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            ProfUser();
        }

        public void ProfUser() //Метод заполнения label-ов данными авторизованного пользователя
        {
            FIOLabel.Text = AppState.CurrentUser.name;
            BirthdayLabel.Text = AppState.CurrentUser.birthday.ToString("dd.MM.yyyy");
            PostLabel.Text = AppState.CurrentUser.role;
            mailLabel.Text = AppState.CurrentUser.mail;
            GroupLabel.Text = AppState.CurrentUser.posts;
        }
        private void ButtonExitProf_Click(object sender, EventArgs e) //Кнопка выхода
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void UpdateUsers_Click(object sender, EventArgs e) //Кнопка отображения панели обновления
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                BirthdayLabel.Text = AppState.CurrentUser.birthday.ToString();
                mailLabel.Text = AppState.CurrentUser.mail;
            }
        }

        private async void Updatebut_Click(object sender, EventArgs e) //Кнопка обновления данных
        {
            Updatebut.Enabled = false;
            int ids = AppState.CurrentUser.id;
            DateTime ubirthday = DateTime.Parse(birthdayTextBox.Text);
            string umail = mailTextBox.Text;
            if (birthdayTextBox.Text == "" || mailTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                Updatebut.Enabled = true;
                return;
            }
            bool result = await AppState.Supabase.UpdateUser(ids, ubirthday, umail);
            if (result)
            {
                MessageBox.Show("Данные успешно обновлены, перезайдите в аккаунт!");
                Updatebut.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ошибка обновления данных");
                Updatebut.Enabled = true;
            }
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            if (AppState.CurrentUser.role == "Менеджер")
            {
                ManagerWindow manager = new ManagerWindow();
                manager.Show();
                this.Close();
            }
            if (AppState.CurrentUser.role == "Директор")
            {
                DirectorWindow director = new DirectorWindow();
                director.Show();
                this.Close();
            }
            if (AppState.CurrentUser.role != "Директор" && AppState.CurrentUser.role != "Менеджер")
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        } //Кнопка возвращения в главное окно
    }
}
