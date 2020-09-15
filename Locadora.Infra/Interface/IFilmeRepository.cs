using Locadora.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Infra.Interface
{
    public interface IFilmeRepository
    {
        void add(Filme filme);

        Filme find(String nome);
    }
}
