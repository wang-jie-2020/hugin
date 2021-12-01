using AutoMapper;
using LG.NetCore.Sample.BookStore.Dtos;

namespace LG.NetCore.Sample.BookStore.Mappers
{
    public class AuthorMapper : Profile
    {
        public AuthorMapper()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorEditDto>();
            CreateMap<AuthorEditDto, Author>();
        }
    }
}
