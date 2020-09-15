using Locadora.Entidade;
using Locadora.Infra.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web.Http.Cors;



namespace LocadoraWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ClienteController : Controller
    {
          private readonly IClienteRepository _ClienteRepository;

        public ClienteController(IClienteRepository _clienteRepo)
        {
            _ClienteRepository = _clienteRepo;
        }

        [System.Web.Http.HttpPost]
        public IActionResult Create([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }
            else
            {
                try
                {
                  var retornoCliente =  _ClienteRepository.find(cliente.idCliente);

                    // valida se cliente já existe ante de inserir
                    if (retornoCliente != null)
                    {
                        _ClienteRepository.add(cliente);
                        return Ok(true);
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }

        }
    }
}
