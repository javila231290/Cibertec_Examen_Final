using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ContextoBD : DbContext
    {
        public ContextoBD() : base("WebDeveloperCadenaConexion")
        {
            //Database.SetInitializer(new WebDeveloperInitializer());
            Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Ordenes> AutorLibro { get; set; }
        
    }
}
