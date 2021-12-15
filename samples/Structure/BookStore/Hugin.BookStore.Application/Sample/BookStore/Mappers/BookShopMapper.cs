using AutoMapper;
using Hugin.Sample.BookStore.Ctos;
using Hugin.Sample.BookStore.Daos;
using Hugin.Sample.BookStore.Dtos;

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
