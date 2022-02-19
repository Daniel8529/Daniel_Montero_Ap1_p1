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
             var lista =ProductosBLL.GeLista();
             Base.ItemsSource = lista;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            
            var listado = new List<Productos>();
           
           
                if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))
                { //si no hay criterio, busco todos         
                    listado = ProductosBLL.GetList(l => true);

                }
                else
                {
                   
                    
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            listado = ProductosBLL.GetList(l => l.ProductoId.ToString()==(CriterioTextBox.Text));

                            break;
                        case 1:
                          listado = ProductosBLL.GetList(l => l.Descripcion==(CriterioTextBox.Text));
                           break;



                    }
                }
                Base.ItemsSource = null;
                Base.ItemsSource = listado;

            
         
          

        }
    }
}