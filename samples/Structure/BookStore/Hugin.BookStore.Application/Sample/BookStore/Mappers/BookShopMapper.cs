using AutoMapper;
using Hugin.BookStore;
using Hugin.BookStore.Dtos;
using Hugin.Sample.BookStore.Ctos;
using Hugin.Sample.BookStore.Daos;

namespace Hugin.Sample.BookStore.Mappers
{
    public class BookShopMapper : Profile
    {
        public BookShopMapper()
        {
            CreateMap<BookShop, BookShopDto>();
            CreateMap<BookShop, BookShopEditDto>();
            CreateMap<BookShopEditDto, BookShop>();

            CreateMap<BookShopDao, BookShopDto>()
                .IncludeMembers(s => s.BookShop)
                .ForMember(m => m.OwnerName, s => s.MapFrom(g => g.BookShopOwner.Name));

            CreateMap<BookShopCto, BookShopDao>();
            CreateMap<BookShopDao, BookShopCto>();
        }
    }
}
