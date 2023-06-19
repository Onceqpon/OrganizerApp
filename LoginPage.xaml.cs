using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
