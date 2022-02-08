using System.Windows;
using System.Linq;
using System.Collections.Generic;
using Daniel_Montero_Ap1_p1.Entidades;
using Daniel_Montero_Ap1_p1.BLL;

namespace Daniel_Montero_Ap1_p1.UI.Consultas
{
    public partial class cConsultas : Window
    {

        public cConsultas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var lista = new List<Productos>();
            if(FiltroComboBox.Text=="consulta")
            {
                if(string.IsNullOrWhiteSpace(CriterioTextBox.Text))
                {
                    // lista=ProductosBLL.GeLista(l=> true);
                }
            }
          

        }

    }
}