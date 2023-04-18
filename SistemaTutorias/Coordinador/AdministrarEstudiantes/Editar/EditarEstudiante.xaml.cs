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
using SistemaTutorias.Emergentes;

namespace SistemaTutorias.Coordinador.AdministrarEstudiantes.Editar
{
    /// <summary>
    /// Lógica de interacción para EditarEstudiante.xaml
    /// </summary>
    public partial class EditarEstudiante : Window
    {
        Estudiante estudiante;
        EstudianteDAO estudianteDAO;
        public EditarEstudiante(string matricula)
        {
            InitializeComponent();

           

            estudianteDAO = new EstudianteDAO();

            estudiante = estudianteDAO.getEstudiante(matricula);

            nombreTextBox.Text = estudiante.nombre.ToString();
            apellidoPaternoTextBox.Text = estudiante.apellidoPaterno.ToString();
            apellidoMaternoTextBox.Text = estudiante.apellidoMaterno.ToString();
            matriculaTextBox.Text = estudiante.matricula.ToString();
            programaEducativoTextBox.Text = estudiante.programaEducativo.ToString();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            estudiante.nombre = nombreTextBox.Text;
            estudiante.apellidoPaterno = apellidoPaternoTextBox.Text;
            estudiante.apellidoMaterno = apellidoMaternoTextBox.Text;
            estudiante.matricula = matriculaTextBox.Text;
            estudiante.programaEducativo = programaEducativoTextBox.Text;

            if (estudianteDAO.actualizarEstudiante(estudiante))
            {
                Exitoso exitoso = new Exitoso();
                exitoso.Show();
            }
            

        }
    }
}
