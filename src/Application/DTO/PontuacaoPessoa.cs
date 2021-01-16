using System;

namespace DesignPatternSamples.Application.DTO
{
    [Serializable]
    public class PontuacaoPessoa
    {
        public DateTime Vencimento { get; set; }
        public int Total { get; set; }
        public double Valor { get; set; }
    }
}