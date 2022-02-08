using Microsoft.EntityFrameworkCore;
using Daniel_Montero_Ap1_p1.Entidades;
using Daniel_Montero_Ap1_p1.DAL;

namespace Daniel_Montero_Ap1_p1.DAL
{
   public class Contexto : DbContext
    { 

        public DbSet<Productos> Productos {get; set;}
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source = DATA\Aportes.db");
        }
    }
}