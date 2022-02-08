using Microsoft.EntityFrameworkCore;


namespace Daniel_Montero_Ap1_p1.DAL
{
   public class Contexto : DbContext
    { 

        public DbSet<Productos> productos {get; set;}
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source = DATA\Aportes.db");
        }
    }
}