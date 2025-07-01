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
        public int id;
        public string name;
        public string role;
        public DateTime birthday;
        public string posts;
        public string mail;
    }

    public class MessagesData //Конструктор для данных чата
    {
        public int id;
        public int sender_id;
        public int receiver_id;
        public string text;
        public DateTime time;
    }

    public class UsersObject //Конструктор для заполнения combobox-ов
    {
        public int id;
        public string login;
    }

    public class InformationWorker
    {
        public int id;
        public int user_id;
        public string salary;
        public string worknum;
    }
}
