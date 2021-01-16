using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public abstract class DetranVerificadorMultasRepositoryCrawlerBase : IDetranVerificadorMultasRepository
    {
        public async Task<IEnumerable<PontuacaoPessoa>> ConsultarMultas(Pessoa pessoa)
        {
            var html = await RealizarAcesso(pessoa);
            return await PadronizarResultado(html);
        }

        protected abstract Task<string> RealizarAcesso(Pessoa pessoa);
        protected abstract Task<IEnumerable<PontuacaoPessoa>> PadronizarResultado(string html);
    }
}
