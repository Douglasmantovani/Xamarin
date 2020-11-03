using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Models
{
    class JogoClass
    {
        public int IdJogo { get; set; }
        public string TituloJogo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLan { get; set; }
        public decimal Valor { get; set; }
        public string Caminho { get; set; }
    }
}
