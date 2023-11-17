using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ASP_NET_CORE_EntityFramework_MaestroDetalle.Models;

public partial class DbcompraContext : DbContext
{
    public DbcompraContext()
    {
    }

    public DbcompraContext(DbContextOptions<DbcompraContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.IdCompra).HasName("PK__COMPRA__0A5CDB5C213733D3");

            entity.ToTable("COMPRA");

            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<DetalleCompra>(entity =>
        {
            entity.HasKey(e => e.IdDetalleCompra).HasName("PK__DETALLE___E046CCBBFC30345E");

            entity.ToTable("DETALLE_COMPRA");

            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Producto)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdCompraNavigation).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.IdCompra)
                .HasConstraintName("FK_IdVenta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
