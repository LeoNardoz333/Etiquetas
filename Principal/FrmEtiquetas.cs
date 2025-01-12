using Etiquetas;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        Condiciones condiciones;
        int fila, columna;
        public static string Producto, Fecha;
        public static int Folio;
        public static bool modificar = false;
        public FrmEtiquetas()
        {
            condiciones = new Condiciones();
            producto = new Productos();
            etiqueta = new Etiqueta();
            mProducto = new MProductos();
            mEtiqueta = new MEtiquetas();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += Pd_PrintPage;
            pd.Print();
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
            modificar = false;
            FrmAddEtiquetas owo = new FrmAddEtiquetas();
            owo.ShowDialog();
            Actualizar();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(FrmVerEtiquetas.funcion.Equals("modificar"))
            {
                etiqueta.Altura = float.Parse(txtAltura.Text);
                etiqueta.Ancho = float.Parse(txtAncho.Text);
                etiqueta.Piezas = int.Parse(txtPiezas.Text);
                etiqueta.Tipo = cmbTipo.Text;
                etiqueta.fkProducto = int.Parse(cmbProducto.SelectedValue.ToString());
                etiqueta.Moficicar(FrmVerEtiquetas.id);
            }
            else
            condiciones.evaluar(cmbTipo.Text,float.Parse(txtAltura.Text),float.Parse(txtAncho.Text)
                ,cmbProducto,int.Parse(txtPiezas.Text), "guardar",pCodigo);
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(1000, 1000);
            pCodigo.DrawToBitmap(bm, new Rectangle(0, 0, 1000, 1000));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            condiciones.evaluar(cmbTipo.Text, float.Parse(txtAltura.Text), float.Parse(txtAncho.Text)
                , cmbProducto, int.Parse(txtPiezas.Text), "ver", pCodigo);
        }

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            FrmVerEtiquetas et = new FrmVerEtiquetas();
            et.ShowDialog();
        }

        private void FrmEtiquetas_Activated(object sender, EventArgs e)
        {
            if (FrmVerEtiquetas.funcion.Equals("cargar"))
            {
                txtAltura.Text = FrmVerEtiquetas.altura.ToString();
                txtAncho.Text = FrmVerEtiquetas.ancho.ToString();
                txtPiezas.Text = FrmVerEtiquetas.piezas.ToString();
                cmbProducto.SelectedValue = FrmVerEtiquetas.folio;
                cmbTipo.Text = FrmVerEtiquetas.tipo;
                btnGenerar.Text = "Guardar";
                btnCancelar.Text = "Limpiar";
            }
            else if (FrmVerEtiquetas.funcion.Equals("modificar"))
            {
                txtAltura.Text = FrmVerEtiquetas.altura.ToString();
                txtAncho.Text = FrmVerEtiquetas.ancho.ToString();
                txtPiezas.Text = FrmVerEtiquetas.piezas.ToString();
                cmbProducto.SelectedValue = FrmVerEtiquetas.folio;
                cmbTipo.Text = FrmVerEtiquetas.tipo;
                btnCancelar.Text = "Cancelar";
                btnGenerar.Text = "Actualizar";
            }
            else
            {
                btnGenerar.Text = "Actualizar";
                btnCancelar.Text = "Limpiar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmVerEtiquetas.funcion = "";
            txtAltura.Text = "";
            txtAncho.Text = "";
            txtPiezas.Text = "";
            mEtiqueta.ExtraerProducto(cmbProducto);
            cmbTipo.Text = "Barras";
            btnCancelar.Text = "Limpiar";
            btnGenerar.Text = "Guardar";
        }

        private void dtgEtiquetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Folio= int.Parse(dtgEtiquetas.Rows[fila].Cells[0].Value.ToString());
            Fecha = dtgEtiquetas.Rows[fila].Cells[1].Value.ToString();
            Producto = dtgEtiquetas.Rows[fila].Cells[2].Value.ToString();
            switch (columna)
            {
                case 3:
                    {
                        modificar = true;
                        FrmAddEtiquetas owo = new FrmAddEtiquetas();
                        owo.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        DialogResult rs = MessageBox.Show("¿Estás seguro que deseas eliminar este producto", "ATENCIÓN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                            producto.Borrar(Folio);
                        Actualizar();
                    }
                    break;
            }
        }

        private void FrmEtiquetas_Load(object sender, EventArgs e)
        {
            mEtiqueta.ExtraerProducto(cmbProducto);
            FrmVerEtiquetas.funcion = "";
            Actualizar();
        }
    }
}
