using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class RepositorioAutor : AccesoBaseDatos<Autores>
    {
        public Autores ObtenerPorId(int id)
        {
            using (var dbContexto = new ContextoBD())
            {
                return dbContexto.Autores.FirstOrDefault(p => p.au_id == id);
            }
        }
        
    }
}
