using AutoMapper;
using LG.NetCore.Sample.BookStore.Daos;
using LG.NetCore.Sample.BookStore.Dtos;

namespace LG.NetCore.Sample.BookStore.Mappers
{
    public class BookMapper : Profile
    {
        public BookMapper()
        {
            CreateMap<Book, BookDto>();
            CreateMap<Book, BookEditDto>();
            CreateMap<BookEditDto, Book>();

            CreateMap<BookDao, BookDto>()
                .IncludeMembers(s => s.Book);
        }
    }
}
