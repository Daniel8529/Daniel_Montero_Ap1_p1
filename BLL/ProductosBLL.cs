using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using Daniel_Montero_Ap1_p1.Entidades;
using Daniel_Montero_Ap1_p1.DAL;
using System.Linq.Expressions;

namespace Daniel_Montero_Ap1_p1.BLL
{
    public class ProductosBLL
    {

        public static bool insertar(Productos inseta)
        {
            bool paso = false;
            using (var contexto = new Contexto())
            {
                contexto.Productos.Add(inseta);
                paso = contexto.SaveChanges() > 0;
            }
            return paso;
        }

        public static bool Editar(Productos editar)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(editar).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;




            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();

            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                var adicionales = contexto.Productos.Find(id);
                if (adicionales != null)
                {


                    contexto.Productos.Remove(adicionales);
                    paso=contexto.SaveChanges()>0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();

            }
            return paso;

        
      }
      public static bool Existe(int id)
      {
        
            Contexto contexto = new Contexto();
              bool encontrado = false;

            try
            {

                encontrado=contexto.Productos.Any(e=>e.ProductoId==id);
              
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();

            }
            return encontrado;
          
      }
      public static bool Existes(string id)
      {
        
            Contexto contexto = new Contexto();
              bool encontrado = false;

            try
            {

                encontrado=contexto.Productos.Any(e=>e.Descripcion==id);
              
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();

            }
            return encontrado;
          
      }
      public static List<Productos> GetList(Expression<Func<Productos, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Productos> lista = new List<Productos>();
            try
            {
                lista = contexto.Productos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
      public static List<Productos> GeLista()
      {
           using (var contexto = new Contexto())
            {
                     return contexto.Productos.ToList();
            }
      

      }
          



    }

}