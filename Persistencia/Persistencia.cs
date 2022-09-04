using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace Persistencia
{
    public class Persistencia
    {
         public class ApplicationContext: DbContext

    {

        private const string connectionString = @"Data Source=localhost\HSSQLLocalDB;Initial Catalog=Empresa;Integrated Security=True;";



        public DbSet<Persona> Persona {get; set;}



        //public DbSet<Perro> perros {get; set;}



        public ApplicationContext(){}



        public ApplicationContext(DbContextOptions<ApplicationContext> options)

        :base(options)

    {

    }



     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

    {

        optionsBuilder.UseSqlServer(connectionString);

    }



    }
    }
}