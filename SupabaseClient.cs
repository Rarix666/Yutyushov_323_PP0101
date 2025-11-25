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
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |WARN| - Попытка авторизации с несуществующими данными\n");
                return false;
            }
        }

        public async Task<bool> ComboboxUsers() //Заполнение combobox с пользователями для дальнейшей удобной работы в admin системе и чате через функцию
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
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка парсинга ComboboxUsers {ex}\n");
                return false;
            }
        }

        public async Task<bool> ComboboxUsersDirector() //Заполнение combobox пользователей с ролью админ
        {
            var request = CreateRequest("/rest/v1/rpc/admins_for_director");
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
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка парсинга ComboboxUsersDirector {ex}\n");
                return false;
            }
        }

        public async Task<bool> ComboboxDepartment() //Заполнение combobox с определением отделов
        {
            var request = CreateRequest("/rest/v1/rpc/departments");
            var response = await client.ExecuteAsync(request);
            try
            {
                var departments = JsonConvert.DeserializeObject<List<DepartmentObject>>(response.Content);
                AppState.DepartmentData = departments;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка парсинга: {ex.Message}");
                File.AppendAllText("logerWorkerApp.txt", $"{DateTime.Now} |ERROR| - Ошибка парсинга ComboboxDepartment {ex}\n");
                return false;
            }
        }

        public async Task<bool> CreateDepartment(string cdepartment) //Метод добавления данных нового отдела
        {
            var param = new { cdepartment };
            var request = CreateRequest("rest/v1/rpc/create_departments", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        public async Task<bool> DeleteDepartment(string ddepartment) //Метод удаления данных отдела
        {
            var param = new { ddepartment };
            var request = CreateRequest("rest/v1/rpc/delete_departments", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<bool> WorkerInform() //Метод необходимый для заполнения datagridview в главном окне сотрудников
        {
            var request = CreateRequest("/rest/v1/rpc/workerinfo");
            var response = await client.ExecuteAsync(request);
            try
            {
                var info = JsonConvert.DeserializeObject<List<InformationWorker>>(response.Content);
                AppState.infowork = info;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка парсинга: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> ManagerInform() //Метод необходимый для заполнения datagridview в главном окне менеджеров
        {
            var request = CreateRequest("/rest/v1/rpc/info_for_manager"); 
            var response = await client.ExecuteAsync(request);
            try
            {
                var info = JsonConvert.DeserializeObject<List<InformationManager>>(response.Content);
                AppState.infoManager = info;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка парсинга: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> InfoForAdmin() //Метод необходимый для заполнения datagridview в окне администратора 
        {
            var request = CreateRequest("/rest/v1/rpc/info_for_admin");
            var response = await client.ExecuteAsync(request);
            try
            {
                var infoA = JsonConvert.DeserializeObject<List<InformationAdmin>>(response.Content);
                AppState.infoAdmin = infoA;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка парсинга: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> CreateUser(string clogin, string cname, string crole, string cpassword, string cposts) //Метод добавления данных работающий по принципу метода авторизации
        {
            var param = new { clogin, cname, crole, cpassword, cposts };
            var request = CreateRequest("rest/v1/rpc/create_users", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<bool> CreateTaskEmployee(int cuser_id, string csalary, string cworknum) //Метод добавления данных о задаче для сотрудников
        {
            var param = new { cuser_id, csalary, cworknum};
            var request = CreateRequest("rest/v1/rpc/create_task_employee", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<bool> CreateTaskDepartment(string cdepartment, string ctask, string cdeadline) //Метод добавления данных о задаче для сотрудников
        {
            var param = new { cdepartment, ctask, cdeadline };
            var request = CreateRequest("rest/v1/rpc/create_task_department", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<bool> DeleteUser(string dlogin) //Метод удаления данных работающий по принципу метода авторизации
        {
            var param = new { dlogin };
            var request = CreateRequest("rest/v1/rpc/delete_users", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<bool> UpdateUser(int ids, DateTime ubirthday, string umail) //Метод обновления данных работающий по принципу метода авторизации
        {
            var param = new { ids, ubirthday, umail };
            var request = CreateRequest("rest/v1/rpc/update_user", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        public async Task<bool> UpdateStatusTask(int ids, string ustatus) //Метод обновления данных о статусе задач сотрудников
        {
            var param = new { ids, ustatus };
            var request = CreateRequest("rest/v1/rpc/update_workinf", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        public async Task<bool> UpdateStatusTaskManager(int ids, string ustatus) //Метод обновления данных о статусе задач отделов
        {
            var param = new { ids, ustatus };
            var request = CreateRequest("rest/v1/rpc/update_managerinf", Method.Post);
            request.AddJsonBody(param);
            var response = await client.ExecuteAsync(request);
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        public async Task<List<MessagesData>> GetChatMessages(int currentUserId, int selectedUserId) //Метод получения сообщений из JSON и их фильтрация
        {
            // Точный фильтр для двустороннего чата через прямой запрос к Supabase
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

        public async Task<List<UserData>> GetDepartmentUsers(string managerDepartment, long currentUserId) //Метод для получение всех задач конкретного сотрудника
        {
            var request = CreateRequest("/rest/v1/rpc/get_department_users", Method.Post);
            request.AddJsonBody(new
            {
                manager_department = managerDepartment,
                current_user_id = currentUserId
            });

            var response = await client.ExecuteAsync(request);

            try
            {
                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    var users = JsonConvert.DeserializeObject<List<UserData>>(response.Content);
                    return users ?? new List<UserData>();
                }
                else
                {
                    MessageBox.Show($"Ошибка запроса: {response.StatusCode}");
                    return new List<UserData>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка получения пользователей отдела: {ex.Message}");
                return new List<UserData>();
            }
        }
    }
}
