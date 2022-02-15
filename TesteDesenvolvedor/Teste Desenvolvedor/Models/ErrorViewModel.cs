namespace Teste_Desenvolvedor.Models
{
    public class BancoContext
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}