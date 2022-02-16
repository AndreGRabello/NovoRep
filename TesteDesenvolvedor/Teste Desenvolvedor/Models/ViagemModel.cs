namespace Teste_Desenvolvedor.Models
{
    public class ViagemModel
    {
        public DateOnly Data { get; set; }
        public TimeOnly Hora { get; set; }
        public string? LocalDeEntrega { get; set; }
        public string? LocalDeSaida { get; set; }
        public int? DistanciaEntreCidades { get; set; }

    }
}
