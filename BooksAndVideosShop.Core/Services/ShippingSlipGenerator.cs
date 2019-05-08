using BooksAndVideosShop.Core.Interfaces;
using BooksAndVideosShop.Core.Model;
using System;

namespace BooksAndVideosShop.Core.Services
{
    public class ShippingSlipGenerator : IShippingSlipGenerator
    {
        public string Generate(long orderId, long customerId, PhysicalProduct products)
        {
            throw new NotImplementedException();
        }
    }
}
