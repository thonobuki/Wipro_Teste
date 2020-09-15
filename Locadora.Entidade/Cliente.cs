using System.ComponentModel.DataAnnotations;

namespace Locadora.Entidade
{
    public partial class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string endereco { get; set; }
    }
}
