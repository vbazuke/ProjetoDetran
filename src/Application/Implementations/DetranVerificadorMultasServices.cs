using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorMultasServices : IDetranVerificadorMultasService
    {
        private readonly IDetranVerificadorMultasFactory _Factory;

        public DetranVerificadorMultasServices(IDetranVerificadorMultasFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<PontuacaoPessoa>> ConsultarMultas(Pessoa pessoa)
        {
            IDetranVerificadorMultasRepository repository = _Factory.Create(pessoa.UF);
            return repository.ConsultarMultas(pessoa);
        }
    }
}
