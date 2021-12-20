using AutoMapper;
using Hugin.BookStore.Ctos;
using Hugin.BookStore.Daos;
using Hugin.BookStore.Dtos;

namespace Hugin.BookStore.Mappers
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
                .ForMember(m => m.OwnerName,
                    s => s.MapFrom(g => g.BookShopOwner.Name));

            CreateMap<BookShopCto, BookShopDao>();
            CreateMap<BookShopDao, BookShopCto>();
        }
    }
}
