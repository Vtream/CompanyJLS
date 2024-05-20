using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc.Html;

namespace CompanyJLSUNOF.Models
{
    public class Bodega
    {
        
        [ScaffoldColumn(false)]
        public int idProducto { get; set; }
        [Required, StringLength(100), Display(Name = "")]

        public string NombreProducto { get; set; }
        [Required, StringLength(1000), Display(Name = ""),DataType(DataType.MultilineText)]

        public string FechaVencimiento { get; set; }
        [Required, StringLength(1000)]

        public string NombreProveedor { get; set; }
        [Required, StringLength(1000), Display(Name ="")]

        public string TelefonoProveedor { get; set; }
        [Required, StringLength(1000),]

        public int CantidadInventario { get; set; }
        [Required, StringLength(1000), Display(Name = "")] 

        public string Correo {  get; set; }


    } 
}