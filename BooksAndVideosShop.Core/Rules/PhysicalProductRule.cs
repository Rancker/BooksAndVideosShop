using BooksAndVideosShop.Core.Interfaces;
using BooksAndVideosShop.Core.Model;

namespace BooksAndVideosShop.Core.Rules
{
    public class PhysicalProductRule : IBusinessRule
    {
        private readonly IShippingSlipGenerator _shippingSlipGenerator;

        public PhysicalProductRule(IShippingSlipGenerator shippingSlipGenerator)
        {
            _shippingSlipGenerator = shippingSlipGenerator;
        }

        public void Apply(long orderId, long customerId, Product product)
        {
            if (product.GetType() == typeof(PhysicalProduct))
            {
                _shippingSlipGenerator.Generate(orderId, customerId, (PhysicalProduct)product);
            }
        }
    }

}
