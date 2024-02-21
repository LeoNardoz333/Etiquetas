using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarRedReal;

namespace Etiquetas
{
    public class Etiqueta:IFunciones
    {
        Base b = new Base("localhost", "userEtiquetador", "chivas123", "Etiquetas");
        public int fkProducto { get; set; }
        public int Piezas { get; set; }
        public float Ancho { get; set; }
        public float Altura { get; set; }
        public void Borrar(int id)
        {
            b.comando("delete from Etiqueta where id = "+id);
        }

        public void Crear(dynamic entidad)
        {
            b.comando(string.Format("insert into Etiqueta values({0},{1},{2},{3})",fkProducto,Piezas,Ancho,Altura));
        }

        public void Moficicar(int id)
        {
            b.comando(string.Format("update Etiqueta set fkProducto={0}, piezas={1}, ancho={2}, altura={3}"
                +"where id={4}"
                , fkProducto, Piezas, Ancho, Altura, id));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("Select * from Etiqueta"),"Etiqueta");
        }
    }
}
