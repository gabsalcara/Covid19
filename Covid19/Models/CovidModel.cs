using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covid19.Models.API
{
    public class CovidModel
    {
        #region DadosAPI
        public class Search
        {
            public int Took { get; set; }
            public bool TimeOut { get; set; }
        }

        public class Shards
        {
            public int Total { get; set; }

            public int Successful { get; set; }

            public int Skipped { get; set; }

            public int Failed { get; set; }
        }
        public class Hits
        {
            public TotalHits TotalHits { get; set; }
            public int MaxScore { get; set; }

            public HitsDetalhados HitsDetalhados { get; set; }
        }

        public class TotalHits
        {
            public int Value { get; set; }
            public string Relation { get; set; }
        }
        public class HitsDetalhados
        {
            // detalhar os demais campos
            //_index: "leito_ocupacao",
            //_type: "_doc",
            //_id: "2509636",
            //_score: 1,
            //_source: {
            //estado: "Bahia",
            //estadoSigla: "BA",
            //municipio: "Rio de Contas",
            //cnes: "2509636",
            //nomeCnes: "HOSPITAL DE RIO DE CONTAS",
            //dataNotificacaoOcupacao: "2020-08-10T03:00:27.587Z",
            //ofertaRespiradores: 0,
            //ofertaHospCli: 17,
            //ofertaHospUti: 0,
            //ofertaSRAGCli: 0,
            //ofertaSRAGUti: 0,
            //ocupHospCli: 2,
            //ocupHospUti: 0,
            //ocupSRAGCli: 0,
            //ocupSRAGUti: 0,
            //altas: 0,
            //obitos: 0,
            //ocupacaoInformada: true,
            //algumaOcupacaoInformada: true
        }

    }
    #endregion
}