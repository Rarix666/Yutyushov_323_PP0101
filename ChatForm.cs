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
        public ChatForm(List<UsersObject> usersData) //Конструктор заполнения combobox
        {
            InitializeComponent();

            if (usersData == null || usersData.Count == 0)
            {
                MessageBox.Show("Ошибка отображения пользователей");
                return;
            }

            var displayList = usersData.Select(u => new { Display = u.login, Value = u.id }).ToList(); // Временный список для привязки данных

            //Заполнение данных в combobox в правильном порядке, в соответсвии с id и login
            comboBoxPeopleChat.DataSource = null;
            comboBoxPeopleChat.DataSource = displayList;
            comboBoxPeopleChat.DisplayMember = "Display";
            comboBoxPeopleChat.ValueMember = "Value";
        }

        private async Task LoadMessages()
        {
            try
            {
                int currentUserId = AppState.CurrentUser.id;
                int selectedUserId = (int)comboBoxPeopleChat.SelectedValue;

                var messages = await AppState.Supabase.GetChatMessages(currentUserId, selectedUserId);

                listBox1.Items.Clear();

                foreach (var msg in messages.OrderBy(m => m.time))
                {
                    // Временная проверка (выводим в Output)
                    MessageBox.Show(
                        $"Текущий пользователь: ID={currentUserId}\n" +
                        $"Отправитель сообщения: ID={msg.sender_id}\n" +
                        $"Получатель: ID={msg.receiver_id}\n" +
                        $"Текст: {msg.text}\n" +
                        $"Время: {msg.time}"
                    );

                    bool isMyMessage = msg.sender_id == currentUserId;
                    string prefix = isMyMessage ? "Я: " : $"{comboBoxPeopleChat.Text}: ";

                    listBox1.Items.Add($"[{msg.time.ToLocalTime():HH:mm}] {prefix}{msg.text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сообщений: {ex.Message}");
            }
        }

        private async void EnterChatButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Текущий пользователь: ID={AppState.CurrentUser.id}");

            if (AppState.CurrentUser.id == 0)
            {
                MessageBox.Show("Ошибка: ID пользователя невалиден. Закройте чат и войдите снова.");
                return;
            }
            // 1. Жесткая проверка авторизации
            if (AppState.CurrentUser == null || AppState.CurrentUser.id <= 0)
            {
                MessageBox.Show("Ошибка: Вы не авторизованы. Перезайдите в систему");
                return;
            }

            // 2. Проверка выбора собеседника
            if (comboBoxPeopleChat.SelectedValue == null)
            {
                MessageBox.Show("Выберите собеседника");
                return;
            }

            // 3. Проверка текста сообщения
            if (string.IsNullOrWhiteSpace(chatTextBox.Text))
            {
                MessageBox.Show("Введите текст сообщения");
                return;
            }

            // 4. Отправка сообщения
            bool success = await AppState.Supabase.SendMessage(
                AppState.CurrentUser.id, // Используем реальный ID из AppState
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
    }
}
