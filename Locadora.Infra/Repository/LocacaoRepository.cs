using Locadora.Entidade;
using Locadora.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Infra.Repository
{
   public class LocacaoRepository: ILocacaoRepository
    {
        private readonly LocadoraContetx _locadoraContext;

        public LocacaoRepository(LocadoraContetx locadoraContext)
        {
            _locadoraContext = locadoraContext;
        }
        public void add(Locacao locacao)
        {
            _locadoraContext.LOCACAO.Add(locacao);
            _locadoraContext.SaveChanges();
        }

        public Locacao devolucao(Locacao locacao)
        {
            try
            {
                _locadoraContext.LOCACAO.Update(locacao);
                _locadoraContext.SaveChanges();

                return locacao;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public Locacao find(Locacao locacao)
        {
            throw new NotImplementedException();
        }
    }
}
