using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Models.Configuraciones
{
    public class UsuariosConfig : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            //Se declaran las propiedades de la tabla.
            builder.Property(prop => prop.DocumentId)
                .IsRequired();

            builder.Property(prop => prop.Nombres)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(prop => prop.Apellidos)
                .HasMaxLength(80);

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.Property(prop => prop.Password)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(true);

            builder.Property(prop => prop.Rol)
                .HasMaxLength(5);

            builder.Property(prop => prop.FechRegistro)
                .HasColumnType("date");

            builder.Property(prop => prop.CodValid)
                .IsRequired()
                .HasMaxLength(6);

            builder.Property(prop => prop.Celular)
                .IsRequired();
        }
    }
}
