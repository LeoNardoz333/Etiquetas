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
        Base b = new Base("localhost","root","","");
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public string Producto { get; set; }
        public int Piezas { get; set; }
        public float Ancho { get; set; }
        public float Altura { get; set; }
        public void Borrar(int id)
        {
            b.comando("delete from where id = "+id);
        }

        public void Crear(dynamic entidad)
        {
            b.comando(string.Format("insert into values({0},'{1}','{2}',{3})",Folio,Fecha,Producto,Piezas));
        }

        public void Moficicar(int id)
        {
            b.comando(string.Format("update from set folio={0}, fecha='{1}', producto='{2}', piezas={3}" +
                " where id={4}", Folio, Fecha, Producto, Piezas,id));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("Select * from where producto like '%{0}%'",filtro),"");
        }
    }
}
