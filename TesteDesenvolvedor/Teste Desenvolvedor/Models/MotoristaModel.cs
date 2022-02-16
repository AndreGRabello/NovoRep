using System.ComponentModel.DataAnnotations;

namespace Teste_Desenvolvedor.Models
{
    public class MotoristaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome do Motorista")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Digite o Sobrenome do Motorista")] 
        public string? Sobrenome { get; set; }
        public string? MarcaDoCaminhao { get; set; }
        public string? ModeloDoCaminhao { get; set; }
        public string? PlacaDoCaminhao { get; set; }
        public int? QuantidadeDeEixosDoCaminhao { get; set; }
        [Required(ErrorMessage = "Digite o Endereço do Motorista")]
        public string? EnderecoCompleto { get; set; }

    }
}
