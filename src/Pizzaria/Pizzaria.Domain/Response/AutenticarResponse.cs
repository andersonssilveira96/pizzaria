using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response
{
    public class AutenticarResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
