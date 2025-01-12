using Etiquetas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class MAlmacenar : IAlmacenar
    {
        Etiqueta etiqueta = new Etiqueta();
        public void almacenar(float altura, float ancho, int producto, int piezas, string tipo)
        {
            etiqueta.Altura = altura;
            etiqueta.Ancho = ancho;
            etiqueta.fkProducto = producto;
            etiqueta.Piezas = piezas;
            etiqueta.Tipo = tipo;
            etiqueta.Crear();
        }

        public string mostrar(int folio, string producto, int piezas)
        {
            StringBuilder resultado = new StringBuilder();
            /*if (etiqueta.MostrarCodigo(folio).Tables["Etiqueta"].Rows.Count > 0)
            {
                foreach (DataRow fila in etiqueta.MostrarCodigo(folio).Tables["Etiqueta"].Rows)
                {
                    resultado.AppendLine($"Producto: {fila["producto"]}, Folio: {fila["folio"]}," +
                        $" Piezas: {fila["Piezas"]}");
                }
            }*/
            resultado.AppendLine($"Producto: {producto}, Folio: {folio}," +
                        $" Piezas: {piezas}");
            return resultado.ToString();
        }
    }
}
