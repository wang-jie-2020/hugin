using AutoMapper;
using Hugin.Sample.BookStore.Dtos;

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
