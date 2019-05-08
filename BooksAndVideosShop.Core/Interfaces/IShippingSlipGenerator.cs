using BooksAndVideosShop.Core.Model;

namespace BooksAndVideosShop.Core.Interfaces
{
    public interface IShippingSlipGenerator
    {
        string Generate(long orderId, long customerId, PhysicalProduct products);
    }
}
