using Etiquetas;
using System;
using System.Collections.Generic;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manejador
{
    public class QR : IImprimir
    {
        public void Imprimir(string tipo, string tamano)
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\emman\Escritorio", FileMode.Create));
            doc.Open();
            BarcodeQRCode barcodeQRCode = new BarcodeQRCode(String.Format("{0}", tipo), 1000, 1000, null);
            Image qrImage = barcodeQRCode.GetImage();
            qrImage.ScaleAbsolute(100,100);
            doc.Add(qrImage);
            doc.Close();
        }
        public string tamano(float altura, float ancho)
        {
            return "";
        }

        public string tipo(string tipo, int piezas)
        {
            return "";
        }
    }
}