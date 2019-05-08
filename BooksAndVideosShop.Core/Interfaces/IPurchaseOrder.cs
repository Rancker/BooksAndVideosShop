using BooksAndVideosShop.Core.Model;
using System.Collections.Generic;

namespace BooksAndVideosShop.Core.Interfaces
{
    public interface IPurchaseOrder
    {
        long PurchaseOrderId { get; set; }
        long CustomerId { get; }
        decimal TotalPrice { get; }
        IEnumerable<Product> LineItems { get; }
    }
}