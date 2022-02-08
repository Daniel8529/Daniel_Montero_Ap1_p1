
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using Daniel_Montero_Ap1_p1.Entidades;
using Daniel_Montero_Ap1_p1.BLL;

namespace Daniel_Montero_Ap1_p1.UI.Registros
{
    public partial class cRegistros : Window
    {
       

        public cRegistros()
        {
            InitializeComponent();

         
        }

        private void Cargar()
        {

        }

        private void Limpiar()
        {
            
        }

       
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Productoidtxt.Text="";
            Descriciontxt.Text="";
            Existenciatxt.Text="";
            Costotxt.Text="";
            ValorInventariotxt.Text="";
       
        }


        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
           Productos producto = new Productos(int.Parse(Productoidtxt.Text),Descriciontxt.Text,int.Parse(Existenciatxt.Text),
           int.Parse(Costotxt.Text));
           if(!ProductosBLL.Existe(int.Parse(Productoidtxt.Text)))
           {
               
               var paso=ProductosBLL.insertar(producto);
               MessageBox.Show("Guardado con exito");
           }else{
               MessageBox.Show("Ya exixte");
           }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if(!ProductosBLL.Eliminar(int.Parse(Productoidtxt.Text)))
           {
              MessageBox.Show("No  exixte no se puede eliminar");
               
           }else{
               MessageBox.Show("Eliminado con exito");
           }
         
        }
    }
}