namespace LG.NetCore.Infrastructure.Abp.Dtos
{
    public class StopFilterPagedAndSortedResultRequestDto : FilterPagedAndSortedResultRequestDto
    {
        public bool? IsStop { get; set; }
    }
}
