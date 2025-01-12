using Etiquetas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class Barras : IImprimir
    {
        MAlmacenar alm = new MAlmacenar();
        public void Generar(float altura, float ancho, ComboBox producto, int piezas, string funcion, Panel panel, string tipo)
        {
            Zen.Barcode.Code128BarcodeDraw mGeneradorCB =
            Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            if(funcion.Equals("guardar"))
            {
                alm.almacenar(altura,ancho,int.Parse(producto.SelectedValue.ToString()),piezas, tipo);
            }
            panel.BackgroundImage = mGeneradorCB.Draw(alm.mostrar(int.Parse(producto.SelectedValue.ToString()),
                producto.Text,piezas), 60);
        }
    }
}
