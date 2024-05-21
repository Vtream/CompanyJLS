using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class Persona
    {
        [ScaffoldColumn(false)]
        public int idPersona { get; set; }
        [Required, StringLength(100), Display(Name = "id")] 
        public string Nombres { get; set; }
        [Required, StringLength(1000), Display(Name ="Nombre")]

        public string Apellidos { get; set; }
        [Required, StringLength(1000), Display(Name ="Apellido")]

        public string TipoDocumento { get; set; }
        [Required, StringLength(1000)]

        public string correo {  get; set; }
        [Required, StringLength(1000)]

        public int Telefono { get; set; }
        [Required, StringLength(100), Display(Name ="Numero")]

        public string Direccion {  get; set; }

        public string TipoRol {  get; set; }
        [Required, StringLength(1000), Display(Name ="Rol")]

        public int? idRol { get; set; }
        public int? CodigoFactura { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Rol1> Roles { get; set; }
    }
}