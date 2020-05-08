using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Repositorios;
using Aproveitte.Infra.Data.Contextos;

namespace Aproveitte.Infra.Data.Repositórios
{
    public class IngredienteRepositorio : RepositorioBase<Ingrediente>, IIngredienteRepositorio
    {
        public IngredienteRepositorio(Contexto contexto)
            : base(contexto)
        {

        }
    }
}
