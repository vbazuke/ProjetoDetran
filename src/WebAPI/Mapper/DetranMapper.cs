using AutoMapper;
using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.WebAPI.Models.Detran;

namespace DesignPatternSamples.WebAPI.Mapper
{
    public class DetranMapper : Profile
    {
        public DetranMapper()
        {
            CreateMap<VeiculoModel, Veiculo>();
            CreateMap<PessoaModel, Pessoa>();
            CreateMap<DebitoVeiculo, DebitoVeiculoModel>();
            CreateMap<PontuacaoPessoa, PontuacaoPessoaModel>();
        }
    }
}
