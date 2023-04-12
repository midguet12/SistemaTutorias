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
            
            StudentDAO studentDAO = new StudentDAO();   
            
            table.ItemsSource = studentDAO.getStudents();


        }

        private void editarEstudiante_Click(object sender, RoutedEventArgs e)
        {
            if (table.SelectedItem == null)
            {
                Debug.WriteLine("Selecciona un estudiante");
            }

            if (table.SelectedItem != null)
            {
                Student student = (Student)table.SelectedItem;
                Debug.WriteLine(student.matricula);

                EditarEstudiante editarEstudiante = new EditarEstudiante(student.matricula);
                editarEstudiante.Show();
            } 
            
        }
    }
}
