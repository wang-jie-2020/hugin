using AutoMapper;
using Volo.Abp.MultiStadium;

namespace Hugin.Sample.Stadiums
{
    public class StadiumDomainMapper : Profile
    {
        public StadiumDomainMapper()
        {
            CreateMap<Stadium, StadiumConfiguration>();
        }
    }
}
