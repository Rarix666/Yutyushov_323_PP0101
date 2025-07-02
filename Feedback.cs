using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerApp
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void EnterFeedback_Click(object sender, EventArgs e)
        {
            if (FeedbackFIO.Text == "" && richTextFeedback.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                var fromAddress = new MailAddress("RUshan.Bog@mail.ru", "Rarix Corp");
                var toAddress = new MailAddress("RUshan.Bog@mail.ru");
                string fio = FeedbackFIO.Text;
                const string subject = "Отзыв сотрудника";
                string text = richTextFeedback.Text;
                string body = $"Я {fio}, {text}";
                var smtp = new SmtpClient
                {
                    Host = "smtp.mail.ru",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("RUshan.Bog@mail.ru", "um9wgq8cL2ecpiZrDy4U"),
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("Сообщение доставлено");
                MainWindow main = new MainWindow();
                main.Show();
                this.Hide();
            }
        }

        private void ExitFeedbeckButton_Click(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
