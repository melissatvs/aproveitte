using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Repositorios;
using Aproveitte.Dominio.Interfaces.Servicos;

namespace Aproveitte.Dominio.Serviços
{
    public class IngredienteServico : ServicoBase<Ingrediente>, IIngredienteServico
    {
        public IngredienteServico(IIngredienteRepositorio repositorio)
            : base(repositorio)
        {
        }
    }
}
