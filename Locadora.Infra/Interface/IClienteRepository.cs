using Locadora.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Infra.Interface
{
    public interface IClienteRepository
    {
        void add(Cliente cliente);

        Cliente find(Cliente cliente);

    }
}
