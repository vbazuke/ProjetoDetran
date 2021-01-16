using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranRJVerificadorMultasRepository : DetranVerificadorMultasRepositoryCrawlerBase
    {
        private readonly ILogger _Logger;

        public DetranRJVerificadorMultasRepository(ILogger<DetranRJVerificadorMultasRepository> logger)
        {
            _Logger = logger;
        }

        protected override Task<IEnumerable<PontuacaoPessoa>> PadronizarResultado(string html)
        {
            _Logger.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<PontuacaoPessoa>>(new List<PontuacaoPessoa>() { new PontuacaoPessoa() { } });
        }

        protected override Task<string> RealizarAcesso(Pessoa pessoa)
        {
            Task.Delay(5000).Wait(); //Deixando o serviço mais lento para evidenciar o uso do CACHE.
            _Logger.LogDebug($"Consultando multas do condutor(a) {pessoa.UF} para o estado do RJ.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/RJ");
        }
    }
}
