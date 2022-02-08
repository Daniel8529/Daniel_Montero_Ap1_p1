using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Daniel_Montero_Ap1_p1
{

   public class Productos{
      
       [Key] public int ProductoId { get; set; }
       public string? Descripcion { get; set; }
       public int  Existencia { get; set; }
       public int  Costo { get; set; }

       public int ValorInventario { get; set; }
       
       public Productos(int productoId , string? descripcion,int  existencia,int  costo,int valorInventario  )
       {
           this.ProductoId=productoId;
           this.Descripcion=descripcion;
           this.Existencia=existencia;
           this.Costo=costo;
           this.ValorInventario=valorInventario;


       }

   }
    
}