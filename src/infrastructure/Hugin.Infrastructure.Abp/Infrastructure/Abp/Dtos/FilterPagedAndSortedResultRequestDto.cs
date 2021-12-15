using Volo.Abp.Application.Dtos;

namespace LG.NetCore.Infrastructure.Abp.Dtos
{
    public class FilterPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
