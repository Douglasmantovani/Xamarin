﻿using System;
using System.Collections.Generic;

namespace GameStore.WebApi.Domains
{
    public partial class Jogo
    {
        public int IdJogo { get; set; }
        public string TituloJogo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLan { get; set; }
        public decimal Valor { get; set; }
        public string Caminho { get; set; }
    }
}
