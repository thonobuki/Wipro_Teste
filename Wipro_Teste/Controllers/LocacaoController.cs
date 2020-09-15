using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locadora.Entidade;
using Locadora.Infra.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocacaoController : ControllerBase
    {
        private readonly ILocacaoRepository _locacaoRepository;

        public LocacaoController(ILocacaoRepository _locacaoRepo)
        {
            _locacaoRepository = _locacaoRepo;
        }

        [System.Web.Http.HttpPost]
        public IActionResult Create([FromBody] Locacao locacao, Filme filme)
        {
            if (locacao == null)
            {
                return BadRequest();
            }
            try
            {

                // Verifica se eu já tenho o filme estoque para locar
                if (filme.qtdEstoque <= 0)
                {
                    return null;
                }
                else
                {
                    _locacaoRepository.add(locacao);
                    return Ok(true);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult devolucao(int id, [FromBody] Locacao locacao, Filme ficlme)
        {
            if (locacao == null || locacao.idLocacao != id)
            {
                return BadRequest();
            }

            var _locacao = _locacaoRepository.find(locacao);

            if (locacao == null)
            {
                return NotFound();
            }

            _locacao.idCliente = locacao.idCliente;
            _locacao.qtdLocada = locacao.qtdLocada;
            _locacao.dtLocacao = DateTime.Now;
            _locacao.dtDevolucao = locacao.dtDevolucao;
            _locacao.filme = locacao.filme;


            // Verifica se a data de devolução está excedida
            if (locacao.dtDevolucao > DateTime.Now)
            {
                
                _locacaoRepository.devolucao(_locacao);
                return NotFound(
                   new
                   {
                       Mensagem = "Data de devolução excedida!",
                       Erro = false
                   });
            }
            else
            {
                _locacaoRepository.devolucao(_locacao);
                return new NoContentResult();
            }

           
            

        }
    }
}
