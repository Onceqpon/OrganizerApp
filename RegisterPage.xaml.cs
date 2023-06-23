using OrganizerApp.UserMenagment;
using System.Text.RegularExpressions;
using System.Windows;

namespace OrganizerApp
{
    /// <summary>
    /// Logika interakcji dla klasy RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Window
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string userUsername = txtUsername.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Password;

            var register = new UserManagement();
            if (CanCreate(userUsername, userEmail, userPassword))
            {
                if (register.IsAccountExist(userEmail))
                    MessageBox.Show("Istnieje konto o podanym emailu.");
                else
                {
                    register.registerAccount(userUsername, userEmail, userPassword);
                    MessageBox.Show("Konto utworzone poprawnie. Teraz możesz się zalogować.");
                    LoginPage logiPage = new LoginPage();
                    logiPage.Show();
                    Close();
                }
            }

        }

        private static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private static bool CanCreate(string name, string email, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nie podano nazwy użytkownika");
                return false;
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Adres Email jest nie poprawny");
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Nie wpisano hasła");
                return false;
            }

            return true;

        }

    }
}
