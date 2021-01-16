using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranRSVerificadorMultasRepository : DetranVerificadorMultasRepositoryCrawlerBase
    {
        private readonly ILogger _Logger;

        public DetranRSVerificadorMultasRepository(ILogger<DetranRJVerificadorMultasRepository> logger)
        {
            _Logger = logger;
        }

        protected override Task<IEnumerable<PontuacaoPessoa>> PadronizarResultado(string html)
        {
            _Logger.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult<IEnumerable<PontuacaoPessoa>>(new List<PontuacaoPessoa>() { new PontuacaoPessoa() });
        }

        protected override Task<string> RealizarAcesso(Pessoa Pessoa)
        {
            _Logger.LogDebug($"Consultando multas do do condutor {Pessoa.CNH} para o estado de RS.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/RS");
        }
    }
}
