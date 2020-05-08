using Aproveitte.Aplicacao.DTO;
using Aproveitte.Aplicacao.Interfaces;
using Aproveitte.Dominio.Entidades;

namespace Aproveitte.Servicos.Api.Controllers
{
    public class ReceitaController : ControllerBase<Receita, ReceitaDTO>
    {
        public ReceitaController(IAppBase<Receita, ReceitaDTO> app) : base(app)
        {
        }
    }
}
