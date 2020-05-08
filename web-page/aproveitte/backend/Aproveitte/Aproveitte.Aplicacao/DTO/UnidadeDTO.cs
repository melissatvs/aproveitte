using Aproveitte.Dominio.Entidades;

namespace Aproveitte.Aplicacao.DTO
{
    public class UnidadeDTO : DTOBase
    {
        public int Nome { get; set; }
        public TipoMedida Tipo { get; set; }
    }
}
