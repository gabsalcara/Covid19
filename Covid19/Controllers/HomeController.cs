using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using Covid19.Models.API;
using static Covid19.Models.API.CovidModel;

namespace Covid19.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult SearchAPI()
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
                var search = JsonConvert.DeserializeObject<Search>(objResponse.ToString());
                var hits = JsonConvert.DeserializeObject<Hits>(objResponse.ToString());
                streamDados.Close();
                resposta.Close();

                var data = new
                {
                    search.Took,
                    search.TimeOut,
                    hits.MaxScore,
                    hits.Relation,
                    Total.Total,
                };

                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }

    }
}