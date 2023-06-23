using OrganizerApp.UserMenagment;
using System.Windows;

namespace OrganizerApp
{
    public partial class LoginPage : Window
    {

        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Password;

            var ob = new UserManagement();

            if (ob.IsAccountExist(userEmail, userPassword))
            {
                MessageBox.Show("Zalogowano poprawnie.");
                MainWindow aplication = new MainWindow();
                aplication.Show();
                Close();
            }
            else
                MessageBox.Show("Nie zalogowano");

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            Close();
        }
    }
}
