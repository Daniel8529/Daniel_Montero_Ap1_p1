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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Daniel_Montero_Ap1_p1.UI.Consultas;
using Daniel_Montero_Ap1_p1.UI.Registros;

namespace Daniel_Montero_Ap1_p1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistroLibrosMenuItem_Click(object sender, RoutedEventArgs e)
        {
           var cRegistros = new cRegistros();
            cRegistros.Show();
        }


        private void ConsultaLibrosMenuItem_Click(object sender, RoutedEventArgs e)
        {
             var cConsultas = new cConsultas();
            cConsultas.Show();
            /*h*/
        }
    }
}
