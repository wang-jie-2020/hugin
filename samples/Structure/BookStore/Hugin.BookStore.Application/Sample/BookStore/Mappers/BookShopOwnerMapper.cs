using AutoMapper;
using Hugin.BookStore;
using Hugin.BookStore.Dtos;

namespace Hugin.Sample.BookStore.Mappers
{
    public class BookShopOwnerMapper : Profile
    {
        public BookShopOwnerMapper()
        {
            CreateMap<BookShopOwner, BookShopOwnerDto>();
        }
    }
}
