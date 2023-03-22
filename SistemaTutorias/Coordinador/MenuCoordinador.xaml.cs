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
using SistemaTutorias.Coordinador.AdministrarEstudiantes;

namespace SistemaTutorias.Coordinador
{
    /// <summary>
    /// Lógica de interacción para MenuCoordinador.xaml
    /// </summary>
    public partial class MenuCoordinador : Window
    {
        

        public MenuCoordinador()
        {
            InitializeComponent();

        }

        private void administrarEstudiantes_Click(object sender, RoutedEventArgs e)
        {
            

            MenuAdministrarEstudiantes administrarEstudiantes = new MenuAdministrarEstudiantes();
            administrarEstudiantes.Show();


        }
    }
}
