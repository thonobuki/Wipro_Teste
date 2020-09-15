using Locadora.Entidade;
using Locadora.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Locadora.Infra.Repository
{
        public class FilmeRepository : IFilmeRepository
        {
            private readonly LocadoraContetx _locadoraContext;

            public FilmeRepository(LocadoraContetx locadoraContext)
            {
                _locadoraContext = locadoraContext;
            }
            public void add(Filme filme)
            {
                    _locadoraContext.FILME.Add(filme);
                    _locadoraContext.SaveChanges();
            }

            public Filme find(string nome)
            {
                return _locadoraContext.FILME.FirstOrDefault(u => u.nomeFilme == nome);
            }
        }
    }

