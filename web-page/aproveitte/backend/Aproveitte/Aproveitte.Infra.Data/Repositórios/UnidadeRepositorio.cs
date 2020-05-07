using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Repositorios;
using Aproveitte.Infra.Data.Contextos;

namespace Aproveitte.Infra.Data.Repositórios
{
    public class UnidadeRepositorio : RepositorioBase<Unidade>, IUnidadeRepositorio
    {
        public UnidadeRepositorio(Contexto contexto)
            : base(contexto)
        {

        }
    }
}
