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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SistemaTutorias.Coordinador.AdministrarEstudiantes.Registrar
{
    /// <summary>
    /// Lógica de interacción para RegistrarEstudiante.xaml
    /// </summary>
    public partial class RegistrarEstudiante : Window
    {
        Estudiante estudiante;
        EstudianteDAO estudianteDAO;
        public RegistrarEstudiante()
        {
            InitializeComponent();

            estudiante = new Estudiante();
            estudianteDAO = new EstudianteDAO();
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            estudiante.nombre = nombreTextBox.Text;
            estudiante.apellidoPaterno = apellidoPaternoTextBox.Text;
            estudiante.apellidoMaterno = apellidoMaternoTextBox.Text;
            estudiante.matricula = matriculaTextBox.Text;
            estudiante.programaEducativo = programaEducativoTextBox.Text;

            MessageBoxButtons botones = MessageBoxButtons.OK;
            DialogResult dialogResult;

            if (estudianteDAO.registrarEstudiante(estudiante))
            {
                dialogResult = System.Windows.Forms.MessageBox.Show("Se han registrado un nuevo Estudiante", "Confirmacion", botones);
                Debug.WriteLine(dialogResult);
                this.Close();

            }
            else
            {
                dialogResult = System.Windows.Forms.MessageBox.Show("Fallido", "No se ha registrado el estudiante", botones);
                Debug.WriteLine(dialogResult);
                this.Close();
            }
        }
    }
}
