using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas
{
    public interface IImprimir
    {
        void Imprimir(string tipo, string tamano);
        string tamano(float altura, float ancho);
        string tipo(string tipo, int piezas);
    }
}
