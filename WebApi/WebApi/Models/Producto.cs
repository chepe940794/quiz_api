using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApi.Models
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesEnAlmacen { get; set; }
    }

    class ProductosDbContext : DbContext
    {
         public DbSet<Producto> Productos { get; set; } 
    }
}