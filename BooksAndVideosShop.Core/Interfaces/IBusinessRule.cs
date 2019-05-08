using BooksAndVideosShop.Core.Model;

namespace BooksAndVideosShop.Core.Interfaces
{
    public interface IBusinessRule
    {
        void Apply(long orderId, long customerId, Product product);
    }
}
