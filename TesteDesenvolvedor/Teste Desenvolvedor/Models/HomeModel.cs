namespace Teste_Desenvolvedor.Models
{
    public class HomeModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}