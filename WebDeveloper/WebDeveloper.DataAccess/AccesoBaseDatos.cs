using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.DataAccess
{
    public class AccesoBaseDatos<T> : IAccesoDatos<T> where T : class
    {
        public int Actualizar(T entidad)
        {
            using (var dbContexto = new ContextoBD())
            {
                dbContexto.Entry(entidad).State = EntityState.Modified;
                return dbContexto.SaveChanges();
            }
        }

        public int Adicionar(T entidad)
        {
            using (var dbContexto = new ContextoBD())
            {
                dbContexto.Entry(entidad).State = EntityState.Added;
                return dbContexto.SaveChanges();
            }
        }
        
        public int Eliminar(T entidad)
        {
            using (var dbContexto = new ContextoBD())
            {
                dbContexto.Entry(entidad).State = EntityState.Deleted;
                return dbContexto.SaveChanges();
            }
        }
        
        public List<T> ObtenerLista()
        {
            using (var dbContexto = new ContextoBD())
            {
                return dbContexto.Set<T>().ToList();
            }
        }
        
    }
}
