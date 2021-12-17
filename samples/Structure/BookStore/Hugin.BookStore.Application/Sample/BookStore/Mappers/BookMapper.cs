using AutoMapper;
using Hugin.BookStore;
using Hugin.BookStore.Dtos;
using Hugin.Sample.BookStore.Daos;

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
