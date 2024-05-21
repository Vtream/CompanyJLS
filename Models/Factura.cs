using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class Factura
    {
        [ScaffoldColumn(false)]
        public int CodigoFactura { get; set; }
        [Required, StringLength(100), Display(Name ="codigo")]

        public string fecha { get; set;}
        [Required, StringLength(1000)]

        public int? idProducto { get; set; }
        public int? Codigo {  get; set; }
        public int? NumerodePago { get; set; }

        
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Bodega> Bodegas { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
  
        public virtual ICollection<FormadePago> Formas{ get; set;}
    }
}