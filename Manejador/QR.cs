using Etiquetas;
using System;
using System.Collections.Generic;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using QRCoder;

namespace Manejador
{
    public class QR : IImprimir
    {
        MAlmacenar alm = new MAlmacenar();
        public void Generar(float altura, float ancho, ComboBox producto, int piezas, string funcion,
            Panel panel, string tipo)
        {
            QRCodeGenerator QRgen = new QRCodeGenerator();
            if (funcion.Equals("guardar"))
            {
                alm.almacenar(altura, ancho, int.Parse(producto.SelectedValue.ToString()), piezas, tipo);
            }
            var QRDatos = QRgen.CreateQrCode(alm.mostrar(int.Parse(producto.SelectedValue.ToString()),
                producto.Text, piezas), QRCodeGenerator.ECCLevel.H);
            var QRCode = new QRCode(QRDatos);
            panel.BackgroundImage = QRCode.GetGraphic(50);
        }
    }
}