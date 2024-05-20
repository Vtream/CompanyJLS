using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class DetalleFactura
    {
        [ScaffoldColumn(false)]
        public int Codigo { get; set; }
        [Required, StringLength(100), Display(Name="")]

        public int Cantidad { get; set; }
        [Required, StringLength(1000), Display(Name="")]

        public string valor { get; set;}
        [Required, StringLength(1000)]

        public int? CodigoPlato { get; set; }

        public virtual Plato Plato { get; set; }
    }
}