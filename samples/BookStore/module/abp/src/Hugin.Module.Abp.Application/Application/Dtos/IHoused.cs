namespace LG.NetCore.Application.Dtos
{
    public interface IHoused<T>
    {
        public T Item { get; set; }
    }
}
