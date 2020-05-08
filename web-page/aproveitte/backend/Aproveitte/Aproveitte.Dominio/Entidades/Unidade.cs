using System.Collections.Generic;

namespace Aproveitte.Dominio.Entidades
{
    public enum TipoMedida
    {
        Capacidade,
        Massa,
        Culinario
    }

    public class Unidade : EntidadeBase
    {
        public string Nome { get; set; }

        public TipoMedida Tipo { get; set; }

        public virtual ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
