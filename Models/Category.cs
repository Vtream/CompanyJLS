using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]

        public int IdCategory { get; set; }
        [Required, StringLength(100), Display(Name ="id")]

        public string CategoryName { get; set; }
        [Display(Name ="Categoria")]

        public string Description { get; set; }

        public virtual DetalleFactura DetalleFacturas { get; set; }

        public virtual ICollection<Plato> platos { get; set; }
    }
}