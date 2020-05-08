using Aproveitte.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aproveitte.Infra.Data.Mapeamentos
{
    public class UnidadeMap : MapBase<Unidade>
    {
        public override void Configure(EntityTypeBuilder<Unidade> builder)
        {
            base.Configure(builder);

            builder.ToTable("unidade");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).IsRequired().HasColumnName("nome").HasMaxLength(40);
        }
    }
}
