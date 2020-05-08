using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Repositorios;
using Aproveitte.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aproveitte.Dominio.Serviços
{
    public class ReceitaServico : ServicoBase<Receita>, IReceitaServico
    {
        public ReceitaServico(IReceitaRepositorio repositorio)
            : base(repositorio)
        {

        }
    }
}
