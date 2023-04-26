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
using System.Windows.Shapes;
using SistemaTutorias.Administrador.AdministrarDocentes;

namespace SistemaTutorias.Administrador
{
    /// <summary>
    /// Lógica de interacción para MenuAdministrador.xaml
    /// </summary>
    public partial class MenuAdministrador : Window
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void administrarDocentes_Click(object sender, RoutedEventArgs e)
        {
            MenuAdministrarDocentes administrarDocentes = new MenuAdministrarDocentes();
            administrarDocentes.Show();


        }

        private void cerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
    }
}
