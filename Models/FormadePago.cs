using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class FormadePago
    {
        [ScaffoldColumn(false)]
        public int Numerodepago { get; set; }
        [Required, StringLength(100), Display(Name ="")]

        public string Efectivo {  get; set; }
        public string Tarjeta { get; set; }

        public int? NumeroTarjeta { get; set; }
        public virtual DetallesTarjetas DetallesTarjetas { get; set; }
    }
}