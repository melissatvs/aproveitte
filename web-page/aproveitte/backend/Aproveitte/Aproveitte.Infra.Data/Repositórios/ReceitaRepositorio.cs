using Aproveitte.Dominio.Entidades;
using Aproveitte.Dominio.Interfaces.Repositorios;
using Aproveitte.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aproveitte.Infra.Data.Repositórios
{
    public class ReceitaRepositorio : RepositorioBase<Receita>, IReceitaRepositorio
    {
        public ReceitaRepositorio(Contexto contexto)
            : base(contexto)
        {

        }
    }
}
