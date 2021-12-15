using AutoMapper;
using Hugin.Sample.BookStore.Dtos;

namespace Hugin.Sample.BookStore.Mappers
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
