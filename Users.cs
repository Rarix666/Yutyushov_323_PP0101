using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp
{
    public class UserData //Конструктор для пользователя
    {
        public int id { get; set; }
        public string name { get; set; } //ФИО
        public string role { get; set; } //Должность
        public DateTime birthday { get; set; } //День рождения
        public string posts { get; set; } //Отдел
        public string mail { get; set; } //Почта
    }

    public class MessagesData //Конструктор для данных чата
    {
        public int id;
        public int sender_id; //Отправляющий
        public int receiver_id; //Получатель
        public string text; //Сообщение
        public DateTime time; //Время отправления
    }

    public class UsersObject //Конструктор для заполнения combobox-ов в админ панели и чате
    {
        public int id;
        public string login;
        public string name;
    }

    public class DepartmentObject
    {
        public int id;
        public string department;
    }

    public class InformationWorker //Конструктор для заполнения datagrid у сотрудника и менеджера
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string salary { get; set; }
        public string worknum { get; set; }
        public string status { get; set; }
    }

    public class InformationManager //Конструктор для заполнения datagrid у менеджера и директора
    {
        public int id;
        public string department;
        public string task;
        public string deadline;
        public string status;
    }

    public class InformationAdmin //Конструктор для заполнения datagrid у администратора
    {
        public int id;
        public string login;
        public string password;
        public string role;
        public string name;
        public DateTime birthday;
        public string posts;
        public string mail;
    }
}
