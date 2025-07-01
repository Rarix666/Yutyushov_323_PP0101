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

        public void ProfUser()
        {
            FIOLabel.Text = AppState.CurrentUser.name;
            BirthdayLabel.Text = AppState.CurrentUser.birthday.ToString();
            PostLabel.Text = AppState.CurrentUser.posts;
            mailLabel.Text = AppState.CurrentUser.mail;
        }
        private void ButtonExitProf_Click(object sender, EventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.Show();
            this.Close();
        }

        private void UpdateUsers_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                BirthdayLabel.Text = AppState.CurrentUser.birthday.ToString();
                PostLabel.Text = AppState.CurrentUser.posts;
                mailLabel.Text = AppState.CurrentUser.mail;
            }
        }

        private async void Updatebut_Click(object sender, EventArgs e)
        {
            int ids = AppState.CurrentUser.id;
            DateTime ubirthday = DateTime.Parse(birthdayTextBox.Text);
            string upost = PostsTextBox.Text;
            string umail = mailTextBox.Text;
            if (birthdayTextBox.Text == "" || PostsTextBox.Text == "" || mailTextBox.Text == "")
            {
                MessageBox.Show("Заполните поле логина!");
                return;
            }
            bool result = await AppState.Supabase.UpdateUser(ids, ubirthday, upost, umail);
            if (result)
            {
                MessageBox.Show("Данные успешно обновлены, перезайдите в аккаунт!");
            }
            else
            {
                MessageBox.Show("Ошибка обновления данных");
            }
        }
    }
}
