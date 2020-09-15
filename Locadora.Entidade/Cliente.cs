using System.ComponentModel.DataAnnotations;

namespace Locadora.Entidade
{
    public partial class Cliente
    {
        [Key]
        int idCliente { get; set; }
        string nome { get; set; }
        int idade { get; set; }
        string endereco { get; set; }
    }
}
