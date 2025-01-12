using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class Condiciones
    {
        public string evaluar(string tipo, float altura, float ancho, ComboBox producto, int piezas,
            string funcion, Panel panel)
        {
            if(tipo.Equals("Barras"))
            {
                Barras b = new Barras();
                b.Generar(altura,ancho,producto,piezas,funcion,panel,"Barras");
            }
            else if (tipo.Equals("QR"))
            {
                QR qr = new QR();
                qr.Generar(altura, ancho, producto, piezas, funcion, panel, "QR");
            }
            return "";
        }
    }
}
