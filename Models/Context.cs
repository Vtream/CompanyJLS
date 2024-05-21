using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class Context : DbContext 
    {
        public Context() : base("CompanyJLS")
        {
        }
           public DbSet<Bodega> Bodegas { get; set; }
           public DbSet<DetalleFactura> DetalleFacturas { get; set;}

           public DbSet<Plato> Platos { get; set; }

           public DbSet<FormadePago> Formas { get; set; }

           public DbSet<DetallesTarjetas> Detalles { get; set; }

           public DbSet<Persona> Personas { get; set; }

           public DbSet<Rol1> Roles { get; set; }

           public DbSet<Factura> Facturas { get; set; }

           public DbSet<Category> Categories { get; set; }



        
    }
}