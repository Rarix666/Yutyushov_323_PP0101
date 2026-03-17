using AutoUpdaterDotNET;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkerApp
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Приложение запущено. \n");
            File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Версия приложения: {Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "Unknown"} \n");
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            InitializeComponent();
            sw.Stop();
            AppState.Supabase = new SupabaseClient();
            File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Время выполнения {sw.ElapsedMilliseconds} ms \n");
            AutoUpdater.Start("https://raw.githubusercontent.com/Rarix666/Yutyushov_323_PP0101/master/update.xml");
        }

        private async void EnterAutorizButton_Click(object sender, EventArgs e) //Блок авторизации
        {
            try
            {
                EnterAutorizButton.Enabled = false;
                string login = LoginTextBox.Text;
                string password = PasswordTextBox.Text;

                if (login == "" || password == "")
                {
                    MessageBox.Show("Заполните поля!");
                    EnterAutorizButton.Enabled = true;
                    return;
                }

                if (!IsValidText(login) || !IsValidText(password))
                {
                    MessageBox.Show("Пароль или логин содержат запрещённые символы!");
                    EnterAutorizButton.Enabled = true;
                    return;
                }

                bool loginSuccess = await AppState.Supabase.AuthenticateUser(login, password);
                string localIp = GetLocalIp();
                string hostName = Environment.MachineName;
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Выполняется авторизация пользователя: {login}\n" +
                    $"IP: {localIp}\n" +
                    $"Имя хоста: {hostName}\n");
                if (loginSuccess)
                {
                    File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Выполнен вход пользователя: {login}...\n");
                    if (AppState.CurrentUser.role == "admin")
                    {
                        MessageBox.Show("Вы авторизованы как администратор");
                        EnterAutorizButton.Enabled = true;
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Администратор {login} авторизовался в системе\n");
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Выполняется переход в панель Администратора\n");
                        AdminForm admin = new AdminForm();
                        admin.Show();
                        this.Hide();
                    }
                    if (AppState.CurrentUser.role == "Менеджер")
                    {
                        MessageBox.Show("Вы авторизованы как менеджер");
                        EnterAutorizButton.Enabled = true;
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Менеджер {login} авторизовался в системе\n");
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Выполняется переход в окно Менеджера\n");
                        ManagerWindow manager = new ManagerWindow();
                        manager.Show();
                        this.Hide();
                    }
                    if (AppState.CurrentUser.role == "Директор")
                    {
                        MessageBox.Show("Вы авторизованы как директор");
                        EnterAutorizButton.Enabled = true;
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Директор {login} авторизовался в системе\n");
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Выполняется переход в окно Директора\n");
                        DirectorWindow director = new DirectorWindow();
                        director.Show();
                        this.Hide();
                    }
                    if (AppState.CurrentUser.role != "Директор" && AppState.CurrentUser.role != "Менеджер" && AppState.CurrentUser.role != "admin")
                    {
                        MessageBox.Show("Вы авторизованы как сотрудник");
                        EnterAutorizButton.Enabled = true;
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Сотрудник {login} авторизовался в системе\n");
                        File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Выполняется переход в окно Сотрудника\n");
                        MainWindow main = new MainWindow();
                        main.Show();
                        this.Hide();
                    }
                }
                else
                {
                    File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Попытка авторизации пользователя {login} не удалась\n");
                    File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |INFO| - Причина: Неверный логин или пароль\n");
                    MessageBox.Show("Данного пользователя не существует");
                    EnterAutorizButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - {ex}\n");
            }
        }

        private void EyeOpen_Click(object sender, EventArgs e)
        {
            EyeClose.Visible = true;
            EyeOpen.Visible = false;
            PasswordTextBox.PasswordChar = '*';
        } //Открытый пароль

        private void EyeClose_Click(object sender, EventArgs e)
        {
            EyeClose.Visible = false;
            EyeOpen.Visible = true;
            PasswordTextBox.PasswordChar = '\0';
        } //Закрытый пароль

        private bool ContainsEmoji(string input) //содержит эмодзи
        {
            return Regex.IsMatch(input, @"\p{Cs}");
        }
        private bool IsValidText(string text) //валидация
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            //запрет эмодзи
            if (ContainsEmoji(text))
                return false;

            var pattern = @"^[\p{L}\p{Nd}\s\.\,\-\–\—\!\?\+\-\*\:\;\(\)\[\]\{\}""'`«»\/\\\+\=\%\&\#]+$";
            return Regex.IsMatch(text, pattern);
        }
        private static string GetLocalIp()
        {
            try
            {
                var hostName = Dns.GetHostName();
                var hostEntry = Dns.GetHostEntry(hostName);
                var ip = hostEntry.AddressList
                    .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                return ip?.ToString() ?? "Не найден IPv4";
            }
            catch (Exception ex)
            {
                return $"Ошибка получения IP: {ex.Message}";
            }
        }

        private void Autorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
