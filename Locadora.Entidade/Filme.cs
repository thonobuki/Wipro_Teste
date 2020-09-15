using System.ComponentModel.DataAnnotations;

namespace Locadora.Entidade
{
    public partial class Filme
    {
        [Key]
        public int idFilme { get; set; }
        public string nomeFilme { get; set; }
        public int qtdEstoque { get; set; }
    }
}
