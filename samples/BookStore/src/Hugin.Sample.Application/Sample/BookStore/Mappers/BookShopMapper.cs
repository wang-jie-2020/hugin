using AutoMapper;
using LG.NetCore.Sample.BookStore.Ctos;
using LG.NetCore.Sample.BookStore.Daos;
using LG.NetCore.Sample.BookStore.Dtos;

namespace LG.NetCore.Sample.BookStore.Mappers
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
