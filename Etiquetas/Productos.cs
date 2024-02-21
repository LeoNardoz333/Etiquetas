using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas
{
    public class Productos : IFunciones
    {
        Base b = new Base("localhost", "userEtiquetador", "chivas123", "Etiquetas"); 
        public int Folio { get; set; }
        public string Fecha { get; set; }
        public string Producto { get; set; }
        public void Borrar(int id)
        {
            b.comando("delete from Datos where id = " + id);
        }

        public void Crear()
        {
            //MessageBox.Show(string.Format("insert into Datos values({0},'{1}','{2}')", Folio, Fecha, Producto));
            b.comando(string.Format("insert into Datos values({0},'{1}','{2}')", Folio, Fecha, Producto));
        }

        public void Moficicar(int id)
        {
            b.comando(string.Format("update Datos set fecha='{0}', producto='{1}'"
                + "where folio={2}"
                , Fecha, Producto, id));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("Select * from Datos where producto like '%{0}%'", filtro), "Datos");
        }
    }
}
