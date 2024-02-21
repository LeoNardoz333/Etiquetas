using Etiquetas;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class FrmAddEtiquetas : Form
    {
        MProductos productos;
        Productos producto;
        bool modificar = true;
        public FrmAddEtiquetas()
        {
            producto=new Productos();
            productos = new MProductos();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modificar == false)
            {
                producto.Folio = int.Parse(txtFolio.Text);
                producto.Fecha = txtFecha.Text;
                producto.Producto = txtProducto.Text;
                producto.Crear();
            }
            else
            {
                producto.Fecha = txtFecha.Text;
                producto.Producto = txtProducto.Text;
                producto.Moficicar(123);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
