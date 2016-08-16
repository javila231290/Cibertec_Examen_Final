using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.DataAccess
{
    public interface IAccesoDatos<T>
    {
        List<T> ObtenerLista();
        int Adicionar(T entidad);
        int Eliminar(T entidad);
        int Actualizar(T entidad);
    }
}
