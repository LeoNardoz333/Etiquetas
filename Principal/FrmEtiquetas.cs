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
    public partial class FrmEtiquetas : Form
    {
        Etiqueta etiqueta;
        Productos producto;
        MEtiquetas mEtiqueta;
        MProductos mProducto;
        int fila, columna;
        public FrmEtiquetas()
        {
            producto = new Productos();
            etiqueta = new Etiqueta();
            mProducto = new MProductos();
            mEtiqueta = new MEtiquetas();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            etiqueta.Altura = int.Parse(txtAltura.Text);
            etiqueta.Ancho = int.Parse(txtAncho.Text);
            etiqueta.fkProducto=int.Parse(cmbProducto.SelectedValue.ToString());
            etiqueta.Piezas = int.Parse(txtPiezas.Text);
            etiqueta.Tipo = cmbTipo.Text;
            etiqueta.Crear();
        }

        private void dtgEtiquetas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
        void Actualizar()
        {
            mProducto.mostrarProductos(dtgEtiquetas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddEtiquetas owo = new FrmAddEtiquetas();
            owo.ShowDialog();
        }

        private void dtgEtiquetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.Folio= int.Parse(dtgEtiquetas.Rows[fila].Cells[0].Value.ToString());
            producto.Fecha = dtgEtiquetas.Rows[fila].Cells[1].Value.ToString();
            producto.Producto = dtgEtiquetas.Rows[fila].Cells[2].Value.ToString();
            switch (columna)
            {
                case 3:
                    {
                        herramientas.Opcion = 2;
                        FrmHerramientasAdd owo = new FrmHerramientasAdd();
                        owo.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        if (eliminar == false)
                            MessageBox.Show("No tienes permisos para eliminar datos");
                        else
                        {
                            herramientas.Opcion = 3;
                            DialogResult rs = MessageBox.Show("¿Estás seguro que deseas eliminar a este usuario", "ATENCIÓN",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rs == DialogResult.Yes)
                                mh.manipularHerramientas(herramientas);
                            Actualizar();
                        }
                    }
                    break;
            }
        }

        private void FrmEtiquetas_Load(object sender, EventArgs e)
        {
            mEtiqueta.ExtraerProducto(cmbProducto);
            Actualizar();
        }
    }
}
