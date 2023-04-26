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
using System.Windows.Forms;
using SistemaTutorias.Coordinador.AdministrarEstudiantes.Registrar;

namespace SistemaTutorias.Coordinador.AdministrarEstudiantes
{
    /// <summary>
    /// Lógica de interacción para MenuAdministrarEstudiantes.xaml
    /// </summary>
    public partial class MenuAdministrarEstudiantes : Window
    {
        EstudianteDAO estudianteDAO;
        public MenuAdministrarEstudiantes()
        {
            InitializeComponent();
            
            estudianteDAO = new EstudianteDAO();

            tabla.ItemsSource = estudianteDAO.getEstudiantes() ;


        }

        private void editarEstudiante_Click(object sender, RoutedEventArgs e)
        {
            if (tabla.SelectedItem == null)
            {
                Debug.WriteLine("Selecciona un estudiante");
                MessageBoxButtons botones = MessageBoxButtons.OK;
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Escoge un estudiante", "Confirmacion", botones);

            }

            if (tabla.SelectedItem != null)
            {
                Estudiante estudiante = (Estudiante)tabla.SelectedItem;
                Debug.WriteLine($"Estudiante con matricula: {estudiante.matricula} seleccionado");

                EditarEstudiante editarEstudiante = new EditarEstudiante(estudiante.matricula);
                

                bool senalDeCerrado = (bool)editarEstudiante.ShowDialog();

               
                if (!senalDeCerrado)
                {
                    
                    tabla.ItemsSource = estudianteDAO.getEstudiantes();
                }

                
                
            } 
            
        }

        

        private void registrarEstudiante_Click_1(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Abriendo ventana de Registrar estudiante");
            RegistrarEstudiante registrarEstudiante = new RegistrarEstudiante();

            bool senalCerrado = (bool)registrarEstudiante.ShowDialog();

            if (!senalCerrado)
            {
                tabla.ItemsSource = estudianteDAO.getEstudiantes();
            }


        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.OK;
            MessageBoxButtons botonesConfirmacion = MessageBoxButtons.YesNo;

            if (tabla.SelectedItem == null)
            {
                Debug.WriteLine("Selecciona un estudiante");
                
                DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Escoge un estudiante", "Confirmacion", botones);

            }

            if (tabla.SelectedItem != null)
            {
                Estudiante estudiante = (Estudiante)tabla.SelectedItem;
                Debug.WriteLine($"Eliminando Estudiante: {estudiante.matricula}");
                DialogResult dialogResult;


                if (System.Windows.Forms.MessageBox.Show($"Desea eliminar Estudiante: {estudiante.nombre}?", "Confirmacion", botonesConfirmacion).ToString() == "Yes")
                { 
                    if (estudianteDAO.eliminarEstudiante(estudiante))
                    {
                        dialogResult = System.Windows.Forms.MessageBox.Show($"Estudiante {estudiante.nombre} eliminado correctamente", "Confirmacion", botones);

                        if (dialogResult.ToString() == "OK")
                        {
                            tabla.ItemsSource = estudianteDAO.getEstudiantes();
                        }

                    }
                }

                
            }
        }
    }
}
