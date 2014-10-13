﻿using System.Data.Entity.ModelConfiguration;
using SecondFloor.Model;

namespace SecondFloor.RepositoryEF.Mappings
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            ToTable("tbEndereco");
            HasKey(e=>e.Id);
            Property(e => e.Id).HasColumnName("Id");
            Property(e => e.Logradouro).HasColumnName("Logradouro").HasMaxLength(250);
            Property(e => e.Numero).HasColumnName("Numero").HasMaxLength(5);
            Property(e => e.Complemento).HasColumnName("Complemento").HasMaxLength(15);
            Property(e => e.Bairro).HasColumnName("Bairro").HasMaxLength(250);
            Property(e => e.Cidade).HasColumnName("Cidade").HasMaxLength(50);
            //Property(e => e.Estado).HasColumnName("Estado").HasMaxLength(10);
            
            HasRequired(f => f.Estado).WithOptional()
                .Map(x => x.MapKey("EstadoId").ToTable("tbEndereco")).WillCascadeOnDelete(false);

            Ignore(e => e.BrokenRules);
        }
    }
}