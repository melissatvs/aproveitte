using Aproveitte.Aplicacao.DTO;
using Aproveitte.Aplicacao.Interfaces;
using Aproveitte.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Aproveitte.Servicos.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ControllerBase<Entidade, EntidadeDTO> : Controller
    where Entidade : EntidadeBase
    where EntidadeDTO : DTOBase
    {
        readonly protected IAppBase<Entidade, EntidadeDTO> app;

        public ControllerBase(IAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var receitas = app.SelecionarTodos();
                return new OkObjectResult(receitas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Busca por id
        /// </summary>
        /// <param name="id">Id do item que será retornado</param>
        /// <returns>
        /// 200 OK
        /// 400 Bad Request
        /// </returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                var receitas = app.SelecionarPorId(id);
                return new OkObjectResult(receitas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] EntidadeDTO dado)
        {
            try
            {
                return new OkObjectResult(app.Incluir(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO dado)
        {
            try
            {
                app.Alterar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                app.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
