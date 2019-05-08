namespace BooksAndVideosShop.Core.Interfaces
{
    public interface IPurchaseOrderProcessor
    {
        void Process(IPurchaseOrder order);
    }
}
