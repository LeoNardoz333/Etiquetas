using Crud;
using Etiquetas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class MProductos
    {
        Graficos g = new Graficos();
        Productos productos = new Productos();
        public void mostrarProductos(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = productos.Mostrar().Tables["Datos"];
            tabla.Columns[1].Width = 136;
            tabla.Columns[2].Width = 130;
            tabla.Columns.Insert(3, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
        }
    }
}
