using AutoMapper;
using Hugin.Sample.BookStore.Daos;
using Hugin.Sample.BookStore.Dtos;

namespace Hugin.Sample.BookStore.Mappers
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
