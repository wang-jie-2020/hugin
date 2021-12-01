using AutoMapper;
using LG.NetCore.Sample.BookStore.Dtos;

namespace LG.NetCore.Sample.BookStore.Mappers
{
    public class BookShopOwnerMapper : Profile
    {
        public BookShopOwnerMapper()
        {
            CreateMap<BookShopOwner, BookShopOwnerDto>();
        }
    }
}
