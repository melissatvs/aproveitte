using Aproveitte.Aplicacao.DTO;
using Aproveitte.Aplicacao.Interfaces;
using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Servicos;
using AutoMapper;

namespace Aproveitte.Aplicacao.Serviços
{
    public class ReceitaApp : ServicoAppBase<Receita, ReceitaDTO>, IReceitaApp
    {
        public ReceitaApp(IMapper iMapper, IReceitaServico servico)
            : base(iMapper, servico)
        {

        }
    }
}
