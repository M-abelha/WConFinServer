using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WConFinServer.Models;

namespace WConFinServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        public static List<Estado> lista = new List<Estado>();

        [HttpGet]
        public List<Estado> GetEstados()
        {
            return lista;
        }

        [HttpPost]
        public string PostEstado(Estado estado)
        {
            lista.Add(estado);
            return "Cadastro efetuado!";

        }

        [HttpPut]
        public string PutEstado(Estado estado)
        {
            Estado estadoAux = lista.Where(x => x.Sigla == estado.Sigla).FirstOrDefault();
            estadoAux.Nome = estado.Nome;
            return "Alteração concluída!";

        }

        [HttpDelete]
        public string DeleteEstado(Estado estado)
        {
            Estado estadoAux = lista.Where(x => x.Sigla == estado.Sigla).FirstOrDefault();
            lista.Remove(estadoAux);
            return "Alteração concluída!";
        }

    }

       
}
