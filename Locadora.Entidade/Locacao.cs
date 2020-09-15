using System;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Entidade
{
    public partial class Locacao
    {
        [Key]
        public int idLocacao { get; set; }
        public string idCliente { get; set; }
        public int qtdLocada { get; set; }
        public DateTime dtLocacao { get; set; }
        public DateTime dtDevolucao { get; set; }
        public Filme filme { get; set; }
    }
}
