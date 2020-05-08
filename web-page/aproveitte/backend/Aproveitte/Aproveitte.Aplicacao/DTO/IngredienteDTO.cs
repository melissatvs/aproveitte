using Aproveitte.Dominio.Entidades;

namespace Aproveitte.Aplicacao.DTO
{
    public class IngredienteDTO : DTOBase
    {
        public string Nome { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual Receita Receita { get; set; }
    }
}
