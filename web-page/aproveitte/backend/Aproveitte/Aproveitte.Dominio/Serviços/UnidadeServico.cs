using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Repositorios;
using Aproveitte.Dominio.Interfaces.Servicos;

namespace Aproveitte.Dominio.Serviços
{
    public class UnidadeServico : ServicoBase<Unidade>, IUnidadeServico
    {
        public UnidadeServico(IUnidadeRepositorio repositorio)
            : base(repositorio)
        {

        }
    }
}
