using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorMultasRepository
    {
        Task<IEnumerable<PontuacaoPessoa>> ConsultarMultas(Pessoa pessoa);
    }
}
