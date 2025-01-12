using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas
{
    public interface IAlmacenar
    {
        void almacenar(float altura, float ancho, int producto, int piezas, string tipo);
        string mostrar(int folio, string producto, int piezas);
    }
}
