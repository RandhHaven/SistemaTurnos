namespace EFAgendaMedica
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelAgendaMedica : DbContext
    {
        public ModelAgendaMedica()
            : base("name=ModelAgendaMedica")
        {
        }

        public virtual DbSet<estados> estados { get; set; }
        public virtual DbSet<tipos_usuarios> tipos_usuarios { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<estados>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<estados>()
                .HasMany(e => e.usuarios)
                .WithRequired(e => e.estados)
                .HasForeignKey(e => e.estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipos_usuarios>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tipos_usuarios>()
                .HasMany(e => e.usuarios)
                .WithRequired(e => e.tipos_usuarios)
                .HasForeignKey(e => e.tipo_usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.usuario_alta)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.usuario_modificacion)
                .IsUnicode(false);
        }
    }
}
