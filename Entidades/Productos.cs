using System.Windows.Input;
using System.ComponentModel.DataAnnotations;

namespace Daniel_Montero_Ap1_p1.Entidades
{

   public class Productos{
      
       [Key] public int ProductoId { get; set; }
       public string? Descripcion { get; set; }
       public int  Existencia { get; set; }
       public int  Costo { get; set; }

       public float ValorInventario { get; set; }
       
      

   }
    
}