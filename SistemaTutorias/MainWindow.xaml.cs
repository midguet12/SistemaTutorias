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
using System.Security.Cryptography;
using System.Diagnostics.CodeAnalysis;
using SistemaTutorias.Coordinador;

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


            //Hasheo de contraseña
            var sha = new System.Security.Cryptography.SHA256Managed();
            byte[] preHasheado = Encoding.UTF8.GetBytes(passwordText.Password.ToString());
            byte[] hashBytes = sha.ComputeHash(preHasheado);
            string password = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

            

            if (password == user.password) {

                switch (user.usertype) {
                    case 1:
                        break;
                    case 2:
                        MenuCoordinador menuCoordinador = new MenuCoordinador();
                        menuCoordinador.Show();
                        this.Close();

                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
                
                
            } else
            {
                wrongPassword.Content = "Contraseña Incorrecta";
                wrongPassword.Foreground = Brushes.Red;
           }

        }

        
    }
}
