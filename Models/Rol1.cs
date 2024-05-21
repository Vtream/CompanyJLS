using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class Rol1
    {
        
        [ScaffoldColumn(false)]
        public int idRol { get; set; }
        [Required, StringLength(100), Display(Name = "Id")]
        public string NombreRol { get; set; }
        [Required, StringLength(1000), Display(Name = "Rol")]

        public string Description { get; set; }

        public virtual Persona Persona { get; set; }
       
        //[Required, StringLength(1000)]
    
    }
}