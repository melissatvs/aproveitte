using Aproveitte.Aplicacao.DTO;
using Aproveitte.Aplicacao.Interfaces;
using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Servicos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aproveitte.Aplicacao.Serviços
{
    public class UnidadeApp : ServicoAppBase<Unidade, UnidadeDTO>, IUnidadeApp
    {
        public UnidadeApp(IMapper iMapper, IUnidadeServico servico)
            : base(iMapper, servico)
        {

        }

    }
}
