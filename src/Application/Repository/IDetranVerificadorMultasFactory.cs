using System;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorMultasFactory
    {
        public IDetranVerificadorMultasFactory Register(string UF, Type repository);
        public IDetranVerificadorMultasRepository Create(string UF);
    }
}
