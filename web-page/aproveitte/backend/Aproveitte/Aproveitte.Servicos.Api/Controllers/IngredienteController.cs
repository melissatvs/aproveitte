using Aproveitte.Aplicacao.DTO;
using Aproveitte.Aplicacao.Interfaces;
using Aproveitte.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aproveitte.Servicos.Api.Controllers
{
    public class IngredienteController : ControllerBase<Ingrediente, IngredienteDTO>
    {
        public IngredienteController(IAppBase<Ingrediente, IngredienteDTO> app) : base(app)
        {
        }
    }
}
