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

            for (int i = 0; i < table.Columns.Count; i++)
            {
                table.Columns[i].Width = DataGridLength.Auto;
            }

            //table.Width

            


        }

       
    }
}
