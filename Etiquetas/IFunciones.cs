using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas
{
    public interface IFunciones
    {
        void Crear(dynamic entidad);
        void Moficicar(int id);
        DataSet Mostrar(string filtro);
        void Borrar(int id);
    }
}
