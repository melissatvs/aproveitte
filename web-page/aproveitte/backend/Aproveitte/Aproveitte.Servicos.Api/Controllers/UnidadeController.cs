using Aproveitte.Aplicacao.DTO;
using Aproveitte.Aplicacao.Interfaces;
using Aproveitte.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Aproveitte.Servicos.Api.Controllers
{
    [ApiController]
    public class UnidadeController : ControllerBase<Unidade, UnidadeDTO>
    {
        private readonly IAppBase<Unidade, UnidadeDTO> app;
        public UnidadeController(IAppBase<Unidade, UnidadeDTO> app) : base(app)
        {
            this.app = app;
        }
    }
}
