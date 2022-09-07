using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dominio;

namespace Persistencia
{

   public class AppContext : DbContext
    {
        public DbSet<Persona> Persona {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured) 
            {
              optionsBuilder
              .UseSqlServer(@"Data Source=localhost\192.168.1.11,1433;Initial Catalog=Empresa;Integrated Security=True");
          
            }
        }
    
    }

}