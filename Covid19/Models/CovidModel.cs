using System;
using System.Collections.Generic;

namespace Covid19.Models.API
{
    public class CovidModel
    {
        #region Dados Hits API
        public class Shards
        {
            public int total { get; set; }
            public int successful { get; set; }
            public int skipped { get; set; }
            public int failed { get; set; }
        }

        public class Total
        {
            public int value { get; set; }
            public string relation { get; set; }
        }

        public class Source
        {
            public string estado { get; set; }
            public string estadoSigla { get; set; }
            public string municipio { get; set; }
            public string cnes { get; set; }
            public DateTime dataNotificacaoOcupacao { get; set; }
            public int ocupHospCli { get; set; }
            public int ocupHospUti { get; set; }
            public int ocupSRAGCli { get; set; }
            public int ocupSRAGUti { get; set; }
            public int altas { get; set; }
            public int obitos { get; set; }
            public bool ocupacaoInformada { get; set; }
            public bool algumaOcupacaoInformada { get; set; }
            public string nomeCnes { get; set; }
            public int? ofertaRespiradores { get; set; }
            public int? ofertaHospCli { get; set; }
            public int? ofertaHospUti { get; set; }
            public int? ofertaSRAGCli { get; set; }
            public int? ofertaSRAGUti { get; set; }
        }

        public class Hit
        {
            public string _index { get; set; }
            public string _type { get; set; }
            public string _id { get; set; }
            public double _score { get; set; }
            public Source _source { get; set; }
        }

        public class Hits
        {
            public Total total { get; set; }
            public double max_score { get; set; }
            public List<Hit> hits { get; set; }
        }

        public class Root
        {
            public int took { get; set; }
            public bool timed_out { get; set; }
            public Shards _shards { get; set; }
            public Hits hits { get; set; }
        }



        #endregion
    }

}