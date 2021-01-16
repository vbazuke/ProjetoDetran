using System;

namespace DesignPatternSamples.WebAPI.Models.Detran
{
    public class PontuacaoPessoaModel
    {
        public DateTime Vencimento { get; set; }
        public int Total { get; set; }
        public double Valor { get; set; }
    }
}