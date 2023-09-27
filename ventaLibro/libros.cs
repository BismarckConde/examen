using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaLibro
{
    public class libros : publiLibroRevis
    {

        public string autor { get; set; }
        public string titulo { get; set; }
        public double costo { get; set; }
        public DateTime fecha { get; set; }

        public override string Informacion()
        {
            return $" LIBRO : (titulo), AUTOR: (autor), FECHA DE PUBLICACION: (fecha), COSTO:(costo)";
        }
    }
}
