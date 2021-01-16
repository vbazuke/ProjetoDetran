﻿using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranVerificadorMultasService
    {
        Task<IEnumerable<PontuacaoPessoa>> ConsultarMultas(Pessoa pessoa);
    }
}
