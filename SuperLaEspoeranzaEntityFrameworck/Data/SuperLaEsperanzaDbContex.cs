using Microsoft.EntityFrameworkCore;
using SuperLaEspoeranzaEntityFrameworck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Data
{
    public class SuperLaEsperanzaDbContex : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = localhost\SQLDEV; database = GestionComercial; trusted_connection = true; trustserverCertificate = true;");
        } 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Filtro global para entidades con campo Estado
          

           // modelBuilder.Entity<Usuario>().HasQueryFilter(u => u.Estado == true);
            modelBuilder.Entity<Proveedor>().HasQueryFilter(p => p.Estado == true);
            modelBuilder.Entity<Producto>().HasQueryFilter(p => p.Estado == true);
            //Configuracion de claves primarias
            modelBuilder.Entity<Cliente>().HasKey(c => c.IdCliente);
            modelBuilder.Entity<Categoria>().HasKey(c => c.IdCategoria);
            modelBuilder.Entity<Compra>().HasKey(c => c.IdCompra);
            modelBuilder.Entity<DetalleCompra>().HasKey(dc => dc.IdDetalleCompra);
            modelBuilder.Entity<DetalleFactura>().HasKey(df => df.IdDetalle);
            modelBuilder.Entity<Factura>().HasKey(f => f.IdFactura);
            modelBuilder.Entity<Movimiento>().HasKey(m => m.IdMovimiento);
            modelBuilder.Entity<Producto>().HasKey(p => p.IdProducto);
            modelBuilder.Entity<Proveedor>().HasKey(pv => pv.IdProveedor);
            modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);




            base.OnModelCreating(modelBuilder);
        }
    }
}
