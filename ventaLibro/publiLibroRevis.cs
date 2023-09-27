using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaLibro
{
    public abstract class publiLibroRevis
    {
        [Required(ErrorMessage = "EL NOMBRE DEL LIBRO SE DEBE REGISTRAR... POR FAVOR INGRESE EL TITULO")]
        public string titulo { get; set; }
        [Required(ErrorMessage =" EL COSTO QUE INGRESO NO SE ENCUENTRA POR FAVOR INGRESE EL COSTO VERDADERO")]
        [Range(0,200)]
        public  double costos { get; set; }
        [Required(ErrorMessage = "EL NOMBRE DEL AUTOR SE DEBE REGISTRAR... POR FAVOR INGRESE EL NOMBRE DEL AUTOR")]
        public string autor { get; set; }
        public DateTime fecha { get; set; }

        public abstract string Informacion();

    }
}
