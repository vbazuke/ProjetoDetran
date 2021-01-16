using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificadorMultasRepository : IDetranVerificadorMultasRepository
    {
        private readonly ILogger _Logger;

        public DetranSPVerificadorMultasRepository(ILogger<DetranSPVerificadorMultasRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontuacaoPessoa>> ConsultarMultas(Pessoa pessoa)
        {
            _Logger.LogDebug($"Consultando multas do condutor {pessoa.UF} para o estado de SP.");
            return Task.FromResult<IEnumerable<PontuacaoPessoa>>(new List<PontuacaoPessoa>() { new PontuacaoPessoa() });
        }
    }
}
