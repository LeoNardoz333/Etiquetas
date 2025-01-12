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
    public partial class FrmVerEtiquetas : Form
    {
        MEtiquetas et;
        Etiqueta etiqueta;
        int fila, columna;
        public static int id, folio, piezas;
        public static float ancho, altura;
        public static string tipo, producto, funcion;
        public FrmVerEtiquetas()
        {
            InitializeComponent();
            et = new MEtiquetas();
            etiqueta = new Etiqueta();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Actualizar()
        {
            et.mostrar(dtgEtiquetas);
        }

        private void FrmVerEtiquetas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgEtiquetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dtgEtiquetas.Rows[fila].Cells[0].Value.ToString());
            tipo = dtgEtiquetas.Rows[fila].Cells[1].Value.ToString();
            piezas = int.Parse(dtgEtiquetas.Rows[fila].Cells[2].Value.ToString());
            ancho = float.Parse(dtgEtiquetas.Rows[fila].Cells[3].Value.ToString());
            altura = float.Parse(dtgEtiquetas.Rows[fila].Cells[4].Value.ToString());
            producto = dtgEtiquetas.Rows[fila].Cells[5].Value.ToString();
            folio = int.Parse(dtgEtiquetas.Rows[fila].Cells[6].Value.ToString());
            switch (columna)
            {
                case 7:
                    {
                        funcion = "cargar";
                        Close();
                    }
                    break;
                case 8:
                    {
                        DialogResult rs = MessageBox.Show("¿Estás seguro que deseas eliminar esta etiqueta", "ATENCIÓN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                            etiqueta.Borrar(id);
                        Actualizar();
                        funcion = "eliminar";
                    }
                    break;
                case 9:
                    {
                        funcion = "modificar";
                        Close();
                    }
                    break;
            }
        }

        private void dtgEtiquetas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
