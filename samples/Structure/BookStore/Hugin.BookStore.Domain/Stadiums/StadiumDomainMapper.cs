using AutoMapper;
using Volo.Abp.MultiStadium;

namespace Hugin.Stadiums
{
    public class StadiumDomainMapper : Profile
    {
        public StadiumDomainMapper()
        {
            CreateMap<Stadium, StadiumConfiguration>();
        }
    }
}
