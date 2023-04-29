using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaVenta.Model;

namespace SistemaVenta.DAL.DBContext ;

public partial class LasLugoDbContext : DbContext
{
    public LasLugoDbContext()
    {
    }

    public LasLugoDbContext(DbContextOptions<LasLugoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteProducto> ClienteProductos { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaProducto> FacturaProductos { get; set; }

    public virtual DbSet<MateriaPrima> MateriaPrimas { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuRol> MenuRols { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<NumerosTelefono> NumerosTelefonos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoMateriaprima> ProductoMateriaprimas { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<ProveedorMateriaprima> ProveedorMateriaprimas { get; set; }

    public virtual DbSet<Prueba> Pruebas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PK__cargo__6C985625E13379A1");

            entity.ToTable("cargo");

            entity.Property(e => e.Salario).HasColumnName("salario");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaProducto).HasName("PK__categori__8A4F21C36DAFEAEC");

            entity.ToTable("categoriaProducto");

            entity.Property(e => e.EsActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__categori__A3C02A1023C9C810");

            entity.ToTable("categoria");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.EsActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoCategoria)
                .HasMaxLength(30)
                .HasColumnName("tipoCategoria");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__cliente__D5946642CA38D8B0");

            entity.ToTable("cliente");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDeliveryNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdDelivery)
                .HasConstraintName("FK__cliente__IdDeliv__3F466844");
        });

        modelBuilder.Entity<ClienteProducto>(entity =>
        {
            entity.HasKey(e => e.IdClienteProducto).HasName("PK__cliente___CC700264F17C5FB3");

            entity.ToTable("cliente_producto");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ClienteProductos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__cliente_p__IdCli__440B1D61");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ClienteProductos)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__cliente_p__IdPro__44FF419A");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.IdDelivery).HasName("PK__delivery__77F64F5DA3DCE230");

            entity.ToTable("delivery");

            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(30)
                .HasColumnName("nombreEmpresa");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.IdDepartamento).HasName("PK__departam__787A433D57A62006");

            entity.ToTable("departamento");

            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Cedula).HasName("PK__empleado__415B7BE44183DD23");

            entity.ToTable("empleado");

            entity.Property(e => e.Cedula)
                .HasMaxLength(30)
                .HasColumnName("cedula");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .HasColumnName("clave");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .HasColumnName("correo");
            entity.Property(e => e.EsActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdCargo)
                .HasConstraintName("FK__empleado__IdCarg__4BAC3F29");

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdMunicipio)
                .HasConstraintName("FK__empleado__IdMuni__4AB81AF0");

            entity.HasOne(d => d.IdNumeroTelefonoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.IdNumeroTelefono)
                .HasConstraintName("FK__empleado__IdNume__49C3F6B7");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__factura__50E7BAF12B9A3D8F");

            entity.ToTable("factura");

            entity.Property(e => e.CantidadTotal).HasColumnName("cantidad_total");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.IdEmpleado).HasMaxLength(30);
            entity.Property(e => e.NumeroMesa).HasColumnName("numeroMesa");
            entity.Property(e => e.PrecioTotal).HasColumnName("precioTotal");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__factura__IdClien__5070F446");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__factura__IdEmple__5165187F");

            entity.HasOne(d => d.IdPagoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdPago)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__factura__IdPago__52593CB8");
        });

        modelBuilder.Entity<FacturaProducto>(entity =>
        {
            entity.HasKey(e => e.IdFacturaProducto).HasName("PK__factura___0C949569F25F438A");

            entity.ToTable("factura_producto");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.FacturaProductos)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__factura_p__IdFac__5535A963");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.FacturaProductos)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__factura_p__IdPro__5629CD9C");
        });

        modelBuilder.Entity<MateriaPrima>(entity =>
        {
            entity.HasKey(e => e.IdMateriaPrima).HasName("PK__materiaP__F8B56D41E5519CEE");

            entity.ToTable("materiaPrima");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.MateriaPrimas)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__materiaPr__IdCat__5AEE82B9");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.IdMenu).HasName("PK__menu__4D7EA8E198FB0A1E");

            entity.ToTable("menu");

            entity.Property(e => e.Icono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("icono");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Urls)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("urls");
        });

        modelBuilder.Entity<MenuRol>(entity =>
        {
            entity.HasKey(e => e.IdMenuRol).HasName("PK__MenuRol__F8D2D5B6E1F2A158");

            entity.ToTable("MenuRol");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdCargo)
                .HasConstraintName("FK__MenuRol__IdCargo__5224328E");

            entity.HasOne(d => d.IdMenuNavigation).WithMany(p => p.MenuRols)
                .HasForeignKey(d => d.IdMenu)
                .HasConstraintName("FK__MenuRol__IdMenu__51300E55");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.IdMunicipio).HasName("PK__municipi__610059783D47C0CD");

            entity.ToTable("municipio");

            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdDepartamentoNavigation).WithMany(p => p.Municipios)
                .HasForeignKey(d => d.IdDepartamento)
                .HasConstraintName("FK__municipio__IdDep__38996AB5");
        });

        modelBuilder.Entity<NumerosTelefono>(entity =>
        {
            entity.HasKey(e => e.IdNumeroTelefono).HasName("PK__numerosT__E691A948DF374769");

            entity.ToTable("numerosTelefonos");

            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("numero");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("PK__pago__FC851A3A3ED170D0");

            entity.ToTable("pago");

            entity.Property(e => e.FormaDePago)
                .HasMaxLength(30)
                .HasColumnName("formaDePago");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__producto__09889210BE174534");

            entity.ToTable("producto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.EsActivo)
                .HasDefaultValueSql("((1))")
                .HasColumnName("esActivo");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");

            entity.HasOne(d => d.IdCategoriaProductoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoriaProducto)
                .HasConstraintName("FK__producto__IdCate__5D95E53A");
        });

        modelBuilder.Entity<ProductoMateriaprima>(entity =>
        {
            entity.HasKey(e => e.Idproductomateriaprima).HasName("PK__producto__93B32674D0E845E9");

            entity.ToTable("producto_materiaprima");

            entity.Property(e => e.CantidadUsada).HasColumnName("cantidadUsada");

            entity.HasOne(d => d.IdMateriaPrimaNavigation).WithMany(p => p.ProductoMateriaprimas)
                .HasForeignKey(d => d.IdMateriaPrima)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__producto___IdMat__5DCAEF64");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductoMateriaprimas)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__producto___IdPro__5EBF139D");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Ruc).HasName("PK__proveedo__CAF3326AF70FB576");

            entity.ToTable("proveedor");

            entity.Property(e => e.Ruc)
                .ValueGeneratedNever()
                .HasColumnName("RUC");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdMunicipioNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdMunicipio)
                .HasConstraintName("FK__proveedor__IdMun__628FA481");

            entity.HasOne(d => d.IdNumeroTelefonoNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.IdNumeroTelefono)
                .HasConstraintName("FK__proveedor__IdNum__619B8048");
        });

        modelBuilder.Entity<ProveedorMateriaprima>(entity =>
        {
            entity.HasKey(e => e.IdProveedorMateriaprima).HasName("PK__proveedo__4F652B09F0F7AFC6");

            entity.ToTable("proveedor_Materiaprima");

            entity.Property(e => e.IdProveedorMateriaprima).HasColumnName("IdProveedor_Materiaprima");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("date");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Ruc).HasColumnName("RUC");

            entity.HasOne(d => d.IdMateriaPrimaNavigation).WithMany(p => p.ProveedorMateriaprimas)
                .HasForeignKey(d => d.IdMateriaPrima)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__proveedor__IdMat__656C112C");

            entity.HasOne(d => d.RucNavigation).WithMany(p => p.ProveedorMateriaprimas)
                .HasForeignKey(d => d.Ruc)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__proveedor_M__RUC__66603565");
        });

        modelBuilder.Entity<Prueba>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pruebas__3213E83F81CA6BBE");

            entity.ToTable("pruebas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
