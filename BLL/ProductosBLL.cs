using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using Daniel_Montero_Ap1_p1.Entidades;
using Daniel_Montero_Ap1_p1.DAL;

namespace Daniel_Montero_Ap1_p1.BLL
{
   public class ProductosBLL{

      public static bool insertar (Productos inseta)
      {
          bool paso=false;
          using(var contexto=new  Contexto())
          {
              contexto.Productos.Add(inseta);
              paso=contexto.SaveChanges()>0;
          }
        
      }



   }
    
}