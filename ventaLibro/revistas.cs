using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaLibro
{
    public class revistas : publiLibroRevis
    {
        public string titulo { get; set; }
        public double periMensual { get; set; }
        public double periSema { get; set; }
        public double periQuince { get; set; }
        
        public override string Informacion()
        {
            return $"TITULO:(titulo),PERIODICIDAD MENSUAL:(periMensual),PERIODICIDAD SEMANAL:(periSema),PERIODICIDAD QUINCENAL(periQuince)";
        }
    }
}
