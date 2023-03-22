using SistemaTutorias.DAO;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SistemaTutorias.Domain;
using System.Diagnostics;

namespace SistemaTutorias
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            UserDAO userDao = new UserDAO();

            User user = userDao.getUser(usernameText.Text);

            string password = passwordText.Text;

            string passwordDb = user.password;

            Debug.WriteLine(password + " " + passwordDb);

        }
    }
}
