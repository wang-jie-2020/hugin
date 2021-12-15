namespace LG.NetCore.Infrastructure.Interfaces
{
    public interface IHoused<T>
    {
        public T Item { get; set; }
    }
}
