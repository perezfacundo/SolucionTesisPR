using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaTesis.Entity;

namespace SistemaTesis.DAL.DBContext
{
    public partial class TESISPRv2Context : DbContext
    {
        public TESISPRv2Context()
        {
        }

        public TESISPRv2Context(DbContextOptions<TESISPRv2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; } = null!;
        public virtual DbSet<Direcciones> Direcciones { get; set; } = null!;
        public virtual DbSet<Empleados> Empleados { get; set; } = null!;
        public virtual DbSet<Estados> Estados { get; set; } = null!;
        public virtual DbSet<Localidades> Localidades { get; set; } = null!;
        public virtual DbSet<Provincias> Provincias { get; set; } = null!;
        public virtual DbSet<Solicitudes> Solicitudes { get; set; } = null!;
        public virtual DbSet<SolicitudesEmpleados> SolicitudesEmpleados { get; set; } = null!;
        public virtual DbSet<SolicitudesTransportes> SolicitudesTransportes { get; set; } = null!;
        public virtual DbSet<TiposDeRegistro> TiposDeRegistros { get; set; } = null!;
        public virtual DbSet<Transportes> Transportes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Clave)
                    .HasMaxLength(15)
                    .HasColumnName("clave");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.DniCliente).HasColumnName("dniCliente");

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(50)
                    .HasColumnName("domicilio");

                entity.Property(e => e.FechaNac)
                    .HasColumnType("date")
                    .HasColumnName("fechaNac");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Clientes_Estados");

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdLocalidad)
                    .HasConstraintName("FK_Clientes_Localidades");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_Clientes_Provincias");

                entity.HasOne(d => d.IdTipoRegistroNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdTipoRegistro)
                    .HasConstraintName("FK_Clientes_TiposDeRegistro");
            });

            modelBuilder.Entity<Direcciones>(entity =>
            {
                entity.HasKey(e => e.IdDireccion);

                entity.Property(e => e.IdDireccion)
                    .ValueGeneratedNever()
                    .HasColumnName("idDireccion");

                entity.Property(e => e.CalleCiudadProvincia)
                    .HasMaxLength(100)
                    .HasColumnName("calleCiudadProvincia");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Numeracion)
                    .HasMaxLength(6)
                    .HasColumnName("numeracion");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Clave)
                    .HasMaxLength(15)
                    .HasColumnName("clave");

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo");

                entity.Property(e => e.DniEmpleado).HasColumnName("dniEmpleado");

                entity.Property(e => e.FechaNac)
                    .HasColumnType("date")
                    .HasColumnName("fechaNac");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .HasColumnName("nombres");

                entity.Property(e => e.PorcComision).HasColumnName("porcComision");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empleados_Estados");

                entity.HasOne(d => d.IdTipoRegistroNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdTipoRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empleados_TiposDeRegistro");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(15)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.HasOne(d => d.IdTipoRegistroNavigation)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.IdTipoRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estados_TiposDeRegistro");
            });

            modelBuilder.Entity<Localidades>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad);

                entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(40)
                    .HasColumnName("localidad");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Localidades)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Localidades_Provincias");

                entity.HasOne(d => d.IdTipoRegistroNavigation)
                    .WithMany(p => p.Localidades)
                    .HasForeignKey(d => d.IdTipoRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Localidades_TiposDeRegistro");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.Property(e => e.Provincia1)
                    .HasMaxLength(20)
                    .HasColumnName("provincia");

                entity.HasOne(d => d.IdTipoRegistroNavigation)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.IdTipoRegistro)
                    .HasConstraintName("FK_Provincias_TiposDeRegistro");
            });

            modelBuilder.Entity<Solicitudes>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.Property(e => e.IdSolicitud).HasColumnName("idSolicitud");

                entity.Property(e => e.DireccionFinal)
                    .HasMaxLength(100)
                    .HasColumnName("direccionFinal");

                entity.Property(e => e.DireccionInicio)
                    .HasMaxLength(100)
                    .HasColumnName("direccionInicio");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnType("date")
                    .HasColumnName("fechaSolicitud");

                entity.Property(e => e.FechaTrabajo)
                    .HasColumnType("date")
                    .HasColumnName("fechaTrabajo");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdLocalidadFinal).HasColumnName("idLocalidadFinal");

                entity.Property(e => e.IdLocalidadInicio).HasColumnName("idLocalidadInicio");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.Property(e => e.PagoFaltante).HasColumnName("pagoFaltante");
            });

            modelBuilder.Entity<SolicitudesEmpleados>(entity =>
            {
                entity.HasKey(e => new { e.IdSe, e.IdSolicitud, e.IdEmpleado })
                    .HasName("PK_SolicitudesEmpleados_1");

                entity.Property(e => e.IdSe)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idSE");

                entity.Property(e => e.IdSolicitud).HasColumnName("idSolicitud");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.SolicitudesEmpleados)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudesEmpleados_Empleados1");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.SolicitudesEmpleados)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudesEmpleados_Solicitudes");
            });

            modelBuilder.Entity<SolicitudesTransportes>(entity =>
            {
                entity.HasKey(e => new { e.IdSt, e.IdSolicitud, e.IdTransporte })
                    .HasName("PK_SolicitudesTransportes_1");

                entity.Property(e => e.IdSt)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idST");

                entity.Property(e => e.IdSolicitud).HasColumnName("idSolicitud");

                entity.Property(e => e.IdTransporte).HasColumnName("idTransporte");

                entity.HasOne(d => d.IdSolicitudNavigation)
                    .WithMany(p => p.SolicitudesTransportes)
                    .HasForeignKey(d => d.IdSolicitud)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudesTransportes_Solicitudes");

                entity.HasOne(d => d.IdTransporteNavigation)
                    .WithMany(p => p.SolicitudesTransportes)
                    .HasForeignKey(d => d.IdTransporte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudesTransportes_Transportes");
            });

            modelBuilder.Entity<TiposDeRegistro>(entity =>
            {
                entity.HasKey(e => e.IdTipoRegistro);

                entity.ToTable("TiposDeRegistro");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(15)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Transportes>(entity =>
            {
                entity.HasKey(e => e.IdTransporte);

                entity.Property(e => e.IdTransporte).HasColumnName("idTransporte");

                entity.Property(e => e.Capacidad).HasColumnName("capacidad");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .HasColumnName("marca");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(50)
                    .HasColumnName("modelo");

                entity.Property(e => e.Patente)
                    .HasMaxLength(7)
                    .HasColumnName("patente");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Transportes)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transportes_Estados");

                entity.HasOne(d => d.IdTipoRegistroNavigation)
                    .WithMany(p => p.Transportes)
                    .HasForeignKey(d => d.IdTipoRegistro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transportes_TiposDeRegistro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
