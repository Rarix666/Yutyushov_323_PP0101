using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerApp
{
    public static class AppState
    {
        public static SupabaseClient Supabase { get; set; }
        public static UserData CurrentUser { get; set; }

        public static List<UsersObject> UsersData { get; set; }

        public static void Reset()
        {
            Supabase = null;
            CurrentUser = null;
            UsersData = null;
        }
    }
}
