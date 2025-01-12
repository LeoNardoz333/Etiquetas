using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas
{
    public interface IImprimir
    {
        void Generar(float altura, float ancho, ComboBox producto, int piezas, string funcion, Panel panel, string tipo);
    }
}
