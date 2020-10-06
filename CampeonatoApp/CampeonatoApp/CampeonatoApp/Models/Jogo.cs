using System;
using System.Collections.Generic;
using System.Text;

namespace CampeonatoApp.Models
{
    public class Jogo
    {
        public int id { get; set; }
        public int selecaoCasa { get; set; }
        public int selecaoVisitante { get; set; }
        public int placarCasa { get; set; }
        public int placarVisitante { get; set; }
        public int penaltisCasa { get; set; }
        public int penaltisVisitante { get; set; }
        public DateTime data { get; set; }
        public string estadio { get; set; }


        public string dataFormatada
        {
            get
            {
                return data.ToString("dd/MM/yyyy");
            }
        }

        public override string ToString()
        {
            return $"{selecaoCasa} {placarCasa} X {selecaoVisitante} {placarVisitante} ";
        }
    }
}
