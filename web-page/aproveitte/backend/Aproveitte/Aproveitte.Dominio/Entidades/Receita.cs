using System.Collections.Generic;

namespace Aproveitte.Dominio.Entidades
{
    public class Receita : EntidadeBase
    {
        public string Nome { get; set; }
        public virtual ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
