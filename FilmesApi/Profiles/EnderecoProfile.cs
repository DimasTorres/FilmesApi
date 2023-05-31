using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<UpdateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
        }
    }
}
