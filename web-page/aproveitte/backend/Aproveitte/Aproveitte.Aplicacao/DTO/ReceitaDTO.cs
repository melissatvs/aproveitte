using Aproveitte.Dominio.Entidades;
using System.Collections.Generic;

namespace Aproveitte.Aplicacao.DTO
{
    public class ReceitaDTO : DTOBase
    {
        public string Nome { get; set; }
        public virtual ICollection<Ingrediente> Ingredientes { get; set; }
    }
}
