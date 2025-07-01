using System.Threading.Tasks;

namespace WorkerApp
{
    public partial class Autorization : Form
    {   
        public Autorization()
        {
            InitializeComponent();
            AppState.Supabase = new SupabaseClient();
        }

        private async void EnterAutorizButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            bool loginSuccess = await AppState.Supabase.AuthenticateUser(login, password);
            if (loginSuccess)
            {
                if (AppState.CurrentUser.role == "admin")
                {
                    MessageBox.Show("Вы авторизованы как администратор");
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Вы авторизованы как сотрудник");
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует");
            }
        }
    }
}
