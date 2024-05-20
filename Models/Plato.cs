using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class Plato
    {
        [ScaffoldColumn(false)]

        public int CodigoPlato { get; set; }
        [Required, StringLength(100), Display(Name ="")]

        public string Nombre { get; set; }
        [Required, StringLength(1000), Display(Name ="")]

        public string Ingredientes { get; set; }
        [Required, StringLength(1000), Display(Name ="")]
        public string Valor {  get; set; }
        


    }
}