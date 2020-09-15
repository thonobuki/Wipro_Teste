using Locadora.Entidade;
using Microsoft.EntityFrameworkCore;
using System;

namespace Locadora.Infra
{
    public partial class LocadoraContetx: DbContext
    {
        public LocadoraContetx(DbContextOptions<LocadoraContetx> options) : base(options)
        {

        }

        public DbSet<Filme> FILME { get; set; }
        public DbSet<Cliente> CLIENTE { get; set; }
        public DbSet<Locacao> LOCACAO { get; set; }
    }
}
