using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace CompanyJLSUNOF.Models
{
    public class DatabaseInitializer1 : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            GetCategories().ForEach(c =>context.Categories.Add(c));
            GetPlatos().ForEach(p =>context.Platos.Add(p));

        }

        private static List<Category> GetCategories() 
        {
            var categories = new List<Category> {
                 new Category
                    {
                        IdCategory = 1,
                        CategoryName = "Comida Colombiana",

                    },
            new Category
            {
                IdCategory = 2,
                CategoryName = "Comida Francesa"
            },
            new Category
            {
                IdCategory = 3,
                CategoryName = "Comida Española"
            },
          };
            return categories;

          }


        private static List<Plato> GetPlatos() 
        {
            var platos = new List<Plato>
            {
                new Plato
                {
                    CodigoPlato = 1,
                    Nombre = "",
                    Ingredientes ="",
                    Valor = 12.000,
                    IdCategory = 1,
                },
                new Plato 
                { 
                    CodigoPlato = 2,
                    Nombre ="",
                    Ingredientes ="",
                    Valor =1,
                    IdCategory = 1,
                },
                new Plato 
                {
                     CodigoPlato = 3,
                     Nombre ="",
                     Ingredientes ="",
                     Valor =1,
                     IdCategory = 1,
                },
                new Plato
                {
                      CodigoPlato = 4,
                      Nombre ="",
                      Ingredientes ="",
                      Valor =1,
                      IdCategory = 2,
                },
                new Plato 
                {
                    CodigoPlato = 5,
                    Nombre ="",
                    Ingredientes ="",
                    Valor =1,
                    IdCategory = 2,
                },
                new Plato  
                { 
                    CodigoPlato = 6,
                    Nombre ="",
                    Ingredientes ="",
                    Valor =1,
                    IdCategory = 2,
                },
                new Plato
                {
                    CodigoPlato = 7,
                    Nombre ="",
                    Ingredientes ="",
                    Valor =1,
                    IdCategory = 3,
                },
                new Plato
                {
                    CodigoPlato= 8,
                    Nombre ="",
                    Ingredientes ="",
                    Valor =1,
                    IdCategory = 3,
                },
                new Plato
                {
                    CodigoPlato= 9,
                    Nombre ="",
                    Ingredientes ="",
                    Valor =1,
                    IdCategory = 3,
                }


            };
            return platos;
        }


    }
}