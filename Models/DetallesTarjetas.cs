using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class DetallesTarjetas
    {
        [ScaffoldColumn(false)]
        public int NumeroTarjeta { get; set; }
        [Required, StringLength(100), Display(Name ="")]

        public string NombreTitular { get; set; }
        [Required, StringLength(1000), Display(Name ="")]

        public string FechaVencimiento { get; set; }
        [Required, StringLength(1000)]

        public int CVV {  get; set; }
        [Required, StringLength(1000)]
    }
}