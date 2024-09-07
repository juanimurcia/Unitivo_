using Microsoft.EntityFrameworkCore;
using Unitivo.Modelos;

namespace Unitivo.Modelos
{
    public partial class UnitivoContext : DbContext
    {
        public UnitivoContext()
        {
        }

        public UnitivoContext(DbContextOptions<UnitivoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Perfile> Perfiles { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Talle> Talles { get; set; }
        public virtual DbSet<Color> Colores { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<TipoTalle> TipoTalles { get; set; }  // Agrega aquí

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__categorias__3213E83F1F7D98A1");
                entity.ToTable("categorias");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Descripcion).HasMaxLength(255).IsUnicode(false).HasColumnName("descripcion");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.TipoTalleId).HasColumnName("tipoTalle_id");

                // Relación con TipoTalle
                entity.HasOne(d => d.TipoTalleIdNavigation)
                      .WithMany(p => p.Categorias)
                      .HasForeignKey(d => d.TipoTalleId)
                      .HasConstraintName("FK_categorias_tipoTalle")
                      .OnDelete(DeleteBehavior.ClientSetNull); // O el comportamiento que desees
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__clientes__3213E83FF9015EC7");
                entity.ToTable("clientes");
                entity.HasIndex(e => e.Correo, "UQ__clientes__2A586E0B61E822EA").IsUnique();
                entity.HasIndex(e => e.Dni, "UQ__clientes__D87608A76C636E05").IsUnique();
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("apellido");
                entity.Property(e => e.Correo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("correo");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion");
                entity.Property(e => e.Dni).HasColumnName("dni");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__detalle___3213E83F9DB6B74C");
                entity.ToTable("detalle_facturas");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Cantidad).HasColumnName("cantidad");
                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IdFactura).HasColumnName("id_factura");
                entity.Property(e => e.IdProducto).HasColumnName("id_producto");
                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("precio");
                entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("FK_id_factura_DETALLE_FACTURAS");
                entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_id_productos_DETALLE_FACTURAS");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__empleado__3213E83FB98FA38A");
                entity.ToTable("empleados");
                entity.HasIndex(e => e.Telefono, "UQ__empleado__2A16D94522BFDC57").IsUnique();
                entity.HasIndex(e => e.Correo, "UQ__empleado__2A586E0BA47974F3").IsUnique();
                entity.HasIndex(e => e.Dni, "UQ__empleado__D87608A721C75DDD").IsUnique();
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Apellido)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("apellido");
                entity.Property(e => e.Correo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("correo");
                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("direccion");
                entity.Property(e => e.Dni).HasColumnName("dni");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__facturas__3213E83F608B55C9");
                entity.ToTable("facturas");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
                entity.Property(e => e.Precio).HasColumnName("total");
                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
                entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_cliente_FACTURAS");
                entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_usuario_FACTURAS");
            });

            modelBuilder.Entity<Perfile>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__perfiles__3213E83F0DE10597");
                entity.ToTable("perfiles");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.DescripcionPerfil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion_perfil");
                entity.Property(e => e.EstadoPerfil).HasColumnName("estado_perfil");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__producto__3213E83FCACDE7CC");
                entity.ToTable("productos");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
                entity.Property(e => e.IdTalle).HasColumnName("id_talle");
                entity.Property(e => e.IdColor).HasColumnName("id_color");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
                entity.Property(e => e.Precio).HasColumnName("precio");
                entity.Property(e => e.Stock).HasColumnName("stock");
                entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_categoria_PRODUCTOS");
                entity.HasOne(d => d.IdTalleNavigation).WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdTalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_talle_PRODUCTOS");
                entity.HasOne(d => d.IdColorNavigation).WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdColor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_color_PRODUCTOS");
            });

            modelBuilder.Entity<Talle>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__talles__3213E83FACA61F17");
                entity.ToTable("talles");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Descripcion).HasMaxLength(50).IsUnicode(false).HasColumnName("descripcion");
                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.TipoTalleId).HasColumnName("tipoTalle_id"); // Nombre de columna en la base de datos

                // Relación con TipoTalle
                entity.HasOne(d => d.TipoTalleIdNavigation)
                      .WithMany(p => p.Talles)
                      .HasForeignKey(d => d.TipoTalleId)
                      .HasConstraintName("FK_talles_tipoTalle")
                      .OnDelete(DeleteBehavior.ClientSetNull); // O el comportamiento que desees
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__colores__3213E83FACA61F17");
                entity.ToTable("colores");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Descripcion).HasMaxLength(50).IsUnicode(false).HasColumnName("descripcion");
                entity.Property(e => e.Estado).HasColumnName("estado");

            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__usuarios__3213E83F1B5510E3");
                entity.ToTable("usuarios");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Estado).HasColumnName("estado");
                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");
                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");
                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombre_usuario");
                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");
                entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_empleado_USUARIOS");
                entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_perfil_USUARIOS");
            });

            modelBuilder.Entity<TipoTalle>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__tipotalle__3213E83F12345678");
                entity.ToTable("tipoTalle");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
