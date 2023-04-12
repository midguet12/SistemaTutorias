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

namespace SistemaTutorias.Coordinador.AdministrarEstudiantes.Editar
{
    /// <summary>
    /// Lógica de interacción para EditarEstudiante.xaml
    /// </summary>
    public partial class EditarEstudiante : Window
    {
        public EditarEstudiante(string matricula)
        {
            InitializeComponent();

           

            StudentDAO studentDAO = new StudentDAO();

            Student student = studentDAO.getStudent("S18012173");

            Debug.Write(student.nombre);



        }
    }
}
