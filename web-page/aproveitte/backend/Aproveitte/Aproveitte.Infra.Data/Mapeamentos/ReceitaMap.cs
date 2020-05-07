using Aproveitte.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aproveitte.Infra.Data.Mapeamentos
{
    public class ReceitaMap : MapBase<Receita>
    {
        public override void Configure(EntityTypeBuilder<Receita> builder)
        {
            base.Configure(builder);

            builder.ToTable("receita");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).IsRequired().HasColumnName("nome").HasMaxLength(100);

        }
    }
}
