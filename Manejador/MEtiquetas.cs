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
        public void ExtraerProducto(ComboBox caja)
        {
            caja.DataSource = Etiqueta.Producto().Tables["Etiqueta"];
            caja.DisplayMember = "producto";
            caja.ValueMember = "folio";
        }
    }
}
