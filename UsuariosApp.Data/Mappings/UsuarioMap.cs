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
    /// Classe de mapeamento para a tabela de usuário
    /// </summary>
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .HasColumnName("ID");

            builder.Property(u => u.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(60)
                .IsRequired();

            //definindo email como campo unico
            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u => u.Senha)
                .HasColumnName("SENHA")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
