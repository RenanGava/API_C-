using ControleFacil.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFacil.Api.Data.Mappings{

    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario").HasKey(user => user.Id);

            // campo email comfigurado
            builder.Property(p => p.Email).HasColumnType("VARCHAR").IsRequired();

            // campo senha configurado
            builder.Property(p => p.Senha).HasColumnType("VARCHAR").IsRequired();

            // campo datacadastro configurado
            builder.Property(p => p.DataCadastro).HasColumnType("timestamp").IsRequired();

            // campo datainativacao configurado
            builder.Property(p => p.DataInativacao).HasColumnType("timestamp");
        }
    }
}