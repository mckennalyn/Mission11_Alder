namespace WaterProjectReal.Models
{
    public interface IWaterRepository
    {
        public IQueryable<Book> Books { get; }
    }
}