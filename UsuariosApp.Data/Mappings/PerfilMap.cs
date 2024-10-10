using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuariosApp.Domain.Models.Entities;

namespace UsuariosApp.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Perfil
    /// </summary>
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("PERFIL");

            //chave primária
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .HasColumnName("ID");

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            //definindo o campo nome como único
            builder.HasIndex(p => p.Nome)
                .IsUnique();

        }
    }
}
