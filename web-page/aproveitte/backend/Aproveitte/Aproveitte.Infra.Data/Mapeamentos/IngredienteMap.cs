using Aproveitte.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aproveitte.Infra.Data.Mapeamentos
{
    public class IngredienteMap : MapBase<Ingrediente>
    {
        public override void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            base.Configure(builder);

            builder.ToTable("ingrediente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).IsRequired().HasColumnName("nome").HasMaxLength(100);

            builder.Property(c => c.IdReceita).IsRequired().HasColumnName("id_receita");

            builder.Property(c => c.IdUnidade).IsRequired().HasColumnName("id_unidade");

            builder.HasOne(r => r.Receita).WithMany(i => i.Ingredientes).HasForeignKey(f => f.IdReceita);

            builder.HasOne(r => r.Unidade).WithMany(i => i.Ingredientes).HasForeignKey(f => f.IdUnidade);

        }

    }
}
