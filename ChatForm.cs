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
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Timer refreshTimer; //Таймер для listbox

        public ChatForm(List<UsersObject> usersData) //Конструктор заполнения combobox
        {
            InitializeComponent();

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 2000;
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();


            if (usersData == null || usersData.Count == 0) //Проверка, загрузились ли пользователи в combobox
            {
                MessageBox.Show("Ошибка отображения пользователей");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка загрузки окна выбора чата\n");
                return;
            }

            var displayList = usersData.Select(u => new { Display = u.name, Value = u.id }).ToList(); // Временный список для привязки данных

            //Заполнение данных в combobox в правильном порядке
            comboBoxPeopleChat.DataSource = null;
            comboBoxPeopleChat.DataSource = displayList;
            comboBoxPeopleChat.DisplayMember = "Display";
            comboBoxPeopleChat.ValueMember = "Value";
            this.FormClosing += (sender, e) => refreshTimer?.Stop();
        }

        private async void RefreshTimer_Tick(object sender, EventArgs e) //Обработка тика таймера
        {
            if (comboBoxPeopleChat.SelectedValue != null)
            {
                await LoadMessages();
            }
        }

        private async Task LoadMessages() //Метод загрузки сообщений
        {
            try
            {
                int currentUserId = AppState.CurrentUser.id;
                int selectedUserId = (int)comboBoxPeopleChat.SelectedValue;

                var messages = await AppState.Supabase.GetChatMessages(currentUserId, selectedUserId);

                listBox1.Items.Clear();

                foreach (var msg in messages.OrderBy(m => m.time))
                {
                    bool isMyMessage = msg.sender_id == currentUserId;
                    string prefix = isMyMessage ? "Я: " : $"{comboBoxPeopleChat.Text}: ";

                    listBox1.Items.Add($"[{msg.time.ToLocalTime():HH:mm}] {prefix}{msg.text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сообщений: {ex.Message}");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка загрузки сообщений: {ex}\n");
            }
        }

        private async void EnterChatButton_Click(object sender, EventArgs e) //Кнопка отправки сообщений
        {
            if (AppState.CurrentUser.id == 0)
            {
                MessageBox.Show("Ошибка: ID пользователя невалиден. Закройте чат и войдите снова.");
                return;
            }
            // Проверка авторизации
            if (AppState.CurrentUser == null || AppState.CurrentUser.id <= 0)
            {
                MessageBox.Show("Ошибка: Вы не авторизованы. Перезайдите в систему");
                return;
            }
            // Проверка выбора собеседника
            if (comboBoxPeopleChat.SelectedValue == null)
            {
                MessageBox.Show("Выберите собеседника");
                return;
            }
            // Проверка текста сообщения
            if (string.IsNullOrWhiteSpace(chatTextBox.Text))
            {
                MessageBox.Show("Введите текст сообщения");
                return;
            }
            // Отправка сообщения
            bool success = await AppState.Supabase.SendMessage(
                AppState.CurrentUser.id,
                (int)comboBoxPeopleChat.SelectedValue,
                chatTextBox.Text
            );
            if (success)
            {
                chatTextBox.Clear();
                await LoadMessages();
            }
            else
            {
                MessageBox.Show("Не удалось отправить сообщение");
            }
        }

        private void ExitChatButton_Click(object sender, EventArgs e) //Выход из формы чата
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
        }
    }
}
