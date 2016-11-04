using Hackathon.Infra.DataModels;
using Hackathon.Service.Service.Interface;
using System.Web.Http;

namespace Hackathon.Api.Controllers
{
    public class TesteController : ApiController
    {
        private readonly ITesteService _service;

        public TesteController()
        {
            var teste = 0;
        }

        public TesteController(ITesteService service)
        {
            _service = service;
        }

        [HttpGet]
        public string Buscar()
        {
            return _service.Buscar(2).Descricao;
        }

        public void Inserir()
        {
            var teste = new Teste();
            teste.Descricao = "Umadescricao legal;";
            _service.Inserir(teste);
        }
    }
}
