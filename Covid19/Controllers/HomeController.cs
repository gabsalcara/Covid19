using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web.Mvc;
using static Covid19.Models.API.CovidModel;

namespace Covid19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return SearchAPI();
        }

        [HttpGet]
        public ActionResult SearchAPI()
        {
            var requisicaoWeb = WebRequest.CreateHttp("https://elastic-leitos.saude.gov.br/leito_ocupacao/_search");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "Covid";
            requisicaoWeb.Credentials = new NetworkCredential("user-api-leitos", "aQbLL3ZStaTr38tj");
            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(objResponse.ToString()); 
                streamDados.Close();
                resposta.Close();

                return View(myDeserializedClass);
            }
        }

    }
}