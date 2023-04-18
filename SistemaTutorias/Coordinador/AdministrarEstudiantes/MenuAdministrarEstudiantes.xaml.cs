using SistemaTutorias.DAO;
using SistemaTutorias.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using SistemaTutorias.Coordinador.AdministrarEstudiantes.Editar;
using System.Printing;

namespace SistemaTutorias.Coordinador.AdministrarEstudiantes
{
    /// <summary>
    /// Lógica de interacción para MenuAdministrarEstudiantes.xaml
    /// </summary>
    public partial class MenuAdministrarEstudiantes : Window
    {
        public MenuAdministrarEstudiantes()
        {
            InitializeComponent();
            
            EstudianteDAO estudianteDAO = new EstudianteDAO();

            tabla.ItemsSource = estudianteDAO.getEstudiantes() ;


        }

        private void editarEstudiante_Click(object sender, RoutedEventArgs e)
        {
            if (tabla.SelectedItem == null)
            {
                Debug.WriteLine("Selecciona un estudiante");
            }

            if (tabla.SelectedItem != null)
            {
                Estudiante estudiante = (Estudiante)tabla.SelectedItem;
                Debug.WriteLine($"Estudiante con matricula: {estudiante.matricula} seleccionado");

                EditarEstudiante editarEstudiante = new EditarEstudiante(estudiante.matricula);
                editarEstudiante.Show();
            } 
            
        }
    }
}
