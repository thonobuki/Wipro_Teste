using Locadora.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Infra.Interface
{
    public interface ILocacaoRepository
    {
        void add(Locacao locacao);

        Locacao find(Locacao locacao);

        Locacao devolucao(Locacao locacao);
    }
}
