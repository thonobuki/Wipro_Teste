using Locadora.Entidade;
using Locadora.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.Infra.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly LocadoraContetx _locadoraContext;

        public ClienteRepository(LocadoraContetx locadoraContext)
        {
            _locadoraContext = locadoraContext;
        }

        public void add(Cliente cliente)
        {
            _locadoraContext.CLIENTE.Add(cliente);
            _locadoraContext.SaveChanges();
        }

        public Cliente find(int id)
        {
            return _locadoraContext.CLIENTE.FirstOrDefault(u => u.idCliente == id);
        }
    }
}
