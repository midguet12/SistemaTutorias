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
using System.Windows.Shapes;

namespace SistemaTutorias.Administrador.AdministrarDocentes
{
    /// <summary>
    /// Lógica de interacción para AdministrarDocentes.xaml
    /// </summary>
    public partial class MenuAdministrarDocentes : Window
    {
        DocenteDAO docenteDAO;

        public MenuAdministrarDocentes()
        {
            InitializeComponent();

            docenteDAO = new DocenteDAO();

            tabla.ItemsSource = docenteDAO.getDocentes();


            
        }
        private void editarDocente_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {

            }
        }
        private void registrarDocente_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void eliminarDocente_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
