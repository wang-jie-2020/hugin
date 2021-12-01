using AutoMapper;
using Volo.Abp.MultiStadium;

namespace LG.NetCore.Sample.Stadiums
{
    public class StadiumDomainMapper : Profile
    {
        public StadiumDomainMapper()
        {
            CreateMap<Stadium, StadiumConfiguration>();
        }
    }
}
