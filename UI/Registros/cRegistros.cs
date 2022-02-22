
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using Daniel_Montero_Ap1_p1.Entidades;
using Daniel_Montero_Ap1_p1.BLL;

namespace Daniel_Montero_Ap1_p1.UI.Registros
{
    public partial class cRegistros : Window
    {

        Productos producto = new Productos();
        public cRegistros()
        {

            InitializeComponent();


            this.DataContext = producto;


        }





        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var encontrado = ProductosBLL.Buscar(int.Parse(Productoidtxt.Text));
            if (encontrado != null)
            {
                Descriciontxt.Text = encontrado.Descripcion.ToString();
                Existenciatxt.Text = encontrado.Existencia.ToString();
                Costotxt.Text = encontrado.Costo.ToString();
                ValorInventariotxt.Text = encontrado.ValorInventario.ToString();

            }
            else
            {

                MessageBox.Show("No se pudo encontar el producto", "Falido", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            limpiar();

        }
        public void limpiar()
        {
            Productoidtxt.Text = "0";
            Descriciontxt.Text = "";
            Existenciatxt.Text = "0";
            Costotxt.Text = "0";
            ValorInventariotxt.Text = "0";

        }



        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {




            if (Descriciontxt.Text == string.Empty || Existenciatxt.Text == string.Empty || Costotxt.Text == string.Empty)
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {

                if (!ProductosBLL.Existe(producto.Descripcion))
                {
                    bool paso = false;


                    producto.ValorInventario=producto.Existencia*producto.Costo;
                    paso = ProductosBLL.insertar(producto);

                    if (paso)
                    {
                        MessageBox.Show("El producto se guardó con exito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El producto no se guardó", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                }
                else
                {
                    MessageBox.Show($"Ya hay un producto con la descripción ", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                    limpiar();
                }








            }


        }


        private void Editar_Click(object sender, RoutedEventArgs e)
        {

            var encontrado = ProductosBLL.Buscar(int.Parse(Productoidtxt.Text));
            if (encontrado != null)
            {
                ProductosBLL.Editar(producto);
                MessageBox.Show("Se Edito", "Falido", MessageBoxButton.OK, MessageBoxImage.Error);
                limpiar();

            }
            else
            {

                MessageBox.Show("No se pudo encontar el producto", "Falido", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ProductosBLL.Eliminar(int.Parse(Productoidtxt.Text)))
            {
                limpiar();
                MessageBox.Show("No  exixte no se puede eliminar");


            }
            else
            {
                limpiar();
                MessageBox.Show("Eliminado con exito");
            }

        }
    }
}