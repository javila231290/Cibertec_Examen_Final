using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class RepositorioLibro : AccesoBaseDatos<Libros>
    {
        public Libros ObtenerPorId(int id)
        {
            using (var dbContexto = new ContextoBD())
            {
                return dbContexto.Libros.FirstOrDefault(p => p.libro_id == id);
            }
        }
        
    }
}
