using AutoMapper;
using Volo.Abp.MultiStadium;

namespace Hugin.Platform.Stadiums
{
    public class StadiumDomainMapper : Profile
    {
        public StadiumDomainMapper()
        {
            CreateMap<Stadium, StadiumConfiguration>();
        }
    }
}
