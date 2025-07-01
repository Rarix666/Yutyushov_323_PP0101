using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp
{
    public class SupabaseClient
    {
        private readonly RestClient client;
        //URL БД Supabase
        private const string BaseURL = "https://mxyvgbsuiqovqzmemtfa.supabase.co";
        //API ключ
        private const string APIkey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im14eXZnYnN1aXFvdnF6bWVtdGZhIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTA4NDc0NjEsImV4cCI6MjA2NjQyMzQ2MX0.CHOjEuYT1V-A-N4QVZ-2FJ_Ev-PhVlphBdL5LpVRZkg";

        public SupabaseClient()
        {
            client = new RestClient(BaseURL); //Инициализация клиента RestRequest
        }

        private RestRequest CreateRequest(string endpoint, Method method = Method.Post) //Структура запроса к Supabase
        {
            var request = new RestRequest(endpoint, method);
            request.AddHeader("apikey", APIkey);
            request.AddHeader("Authorization", $"Bearer {APIkey}");
            request.AddHeader("Content-Type", "application/json");
            return request;
        }

        public async Task<bool> AuthenticateUser(string login, string password) //Авторизация
        {
            var request = CreateRequest("/rest/v1/rpc/auth_user"); //Путь к функции 
            request.AddJsonBody(new { login, password }); //Добавление тела запроса
            var response = await client.ExecuteAsync(request); //Ответ от Supabase

            var rawJson = JObject.Parse(response.Content); //Преобразование полученного необработанного json в JObject программы

            if (rawJson["id"] != null && rawJson["id"].Type != JTokenType.Null)
            {
                AppState.CurrentUser = rawJson.ToObject<UserData>(); //Создание пользователя
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> ComboboxUsers() //Заполнение combobox с пользователями для дальнейшей удобной работы в admin системе и чате
        {
            var request = CreateRequest("/rest/v1/rpc/users");
            var response = await client.ExecuteAsync(request);
            try
            {
                var users = JsonConvert.DeserializeObject<List<UsersObject>>(response.Content);
                AppState.UsersData = users;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка парсинга: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> CreateUser(string clogin, string cname, string crole, string cpassword) //Метод добавления данных работающий по принципу метода авторизации
        {
            var param = new {clogin, cname, crole, cpassword};
            var request = CreateRequest("rest/v1/rpc/create_users", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<bool>DeleteUser(string dlogin) //Метод удаления данных работающий по принципу метода авторизации
        {
            var param = new {dlogin};
            var request = CreateRequest("rest/v1/rpc/delete_users", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<bool>UpdateUser(int ids, DateTime ubirthday, string upost, string umail) //Метод обновления данных работающий по принципу метода авторизации
        {
            var param = new { ids, ubirthday, upost, umail };
            var request = CreateRequest("rest/v1/rpc/update_user", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<List<MessagesData>> GetChatMessages(int currentUserId, int selectedUserId) //Метод получения сообщений из JSON и их фильтрация
        {
            // Точный фильтр для двустороннего чата
            string url = $"/rest/v1/messages?select=*" +
                        $"&or=(and(sender_id.eq.{currentUserId},receiver_id.eq.{selectedUserId})" +
                        $",and(sender_id.eq.{selectedUserId},receiver_id.eq.{currentUserId}))" +
                        $"&order=time.asc";

            var request = CreateRequest(url, Method.Get);
            var response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<List<MessagesData>>(response.Content);
        }

        public async Task<bool> SendMessage(int senderId, int receiverId, string messageText) //Метод для отправки сообщений
        {
            // Проверка ID
            if (senderId <= 0 || receiverId <= 0)
            {
                MessageBox.Show($"Ошибка: Некорректные ID (отправитель: {senderId}, получатель: {receiverId})");
                return false;
            }

            var request = CreateRequest("/rest/v1/messages", Method.Post);
            request.AddJsonBody(new
            {
                sender_id = senderId,
                receiver_id = receiverId,
                text = messageText
            });

            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful;
        }
    }
}
