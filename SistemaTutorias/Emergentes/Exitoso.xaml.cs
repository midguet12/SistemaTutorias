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

namespace SistemaTutorias.Emergentes
{
    /// <summary>
    /// Lógica de interacción para Exitoso.xaml
    /// </summary>
    public partial class Exitoso : Window
    {
        public Exitoso()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
