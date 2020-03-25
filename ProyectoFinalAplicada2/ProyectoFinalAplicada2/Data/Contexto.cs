using Microsoft.EntityFrameworkCore;
using ProyectoFinalAplicada2.Models;
using ProyectoFinalAplicada2.Models.ModelsForQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Entradas> Entradas { get; set; }
        public DbSet<FacturasConsulta> FacturasConsulta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Database/ProyectoFinalDb.db");
        }
    }
}
