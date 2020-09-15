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

        public IActionResult Create([FromBody] Locacao locacao)
        {
            if (locacao == null)
            {
                return BadRequest();
            }
            try
            {
                _locacaoRepository.add(locacao);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
