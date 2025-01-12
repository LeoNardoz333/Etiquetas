using Crud;
using Etiquetas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class MEtiquetas
    {
        Etiqueta Etiqueta = new Etiqueta();
        Graficos g = new Graficos();
        public void ExtraerProducto(ComboBox caja)
        {
            caja.DataSource = Etiqueta.Producto().Tables["Etiqueta"];
            caja.DisplayMember = "producto";
            caja.ValueMember = "folio";
        }
        public void mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = Etiqueta.MostrarCodigo("").Tables["etiqueta"];
            tabla.Columns.Insert(7, g.Boton("Cargar", Color.Sienna));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.Columns.Insert(9, g.Boton("Modificar", Color.Green));
        }
    }
}
