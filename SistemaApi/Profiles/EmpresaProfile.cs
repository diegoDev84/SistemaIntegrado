using AutoMapper;
using SistemaApi.Data.Dtos.Empresa;
using SistemaApi.Models;

namespace SistemaApi.Profiles
{
    public class EmpresaProfile : Profile
    {
        public EmpresaProfile()
        {
            CreateMap<DadosEmpresa, ReadEmpresaDto>();
            CreateMap<UpdateEmpresaDto, DadosEmpresa>();
        }
        
    }
}
