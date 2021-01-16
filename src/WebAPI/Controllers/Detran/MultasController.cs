using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using DesignPatternSamples.WebAPI.Models;
using DesignPatternSamples.WebAPI.Models.Detran;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.WebAPI.Controllers.Detran
{
    [Route("api/Detran/MultasController")]
    [ApiController]
    public class MultasController : ControllerBase
    {
        private readonly IMapper _Mapper;
        private readonly IDetranVerificadorMultasService _DetranVerificadorMultasServices;

        public MultasController(IMapper mapper, IDetranVerificadorMultasService detranVerificadorMultasServices)
        {
            _Mapper = mapper;
            _DetranVerificadorMultasServices = detranVerificadorMultasServices;
        }

        [HttpGet()]
        [ProducesResponseType(typeof(SuccessResultModel<IEnumerable<PontuacaoPessoaModel>>), StatusCodes.Status200OK)]
        public async Task<ActionResult> Get([FromQuery]PessoaModel model)
        {
            var multas = await _DetranVerificadorMultasServices.ConsultarMultas(_Mapper.Map<Pessoa>(model));
            var result = new SuccessResultModel<IEnumerable<PontuacaoPessoaModel>>(_Mapper.Map<IEnumerable<PontuacaoPessoaModel>>(multas));

            return Ok(result);
        }
    }
}