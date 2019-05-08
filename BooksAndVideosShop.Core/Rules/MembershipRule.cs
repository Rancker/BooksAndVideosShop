using BooksAndVideosShop.Core.Interfaces;
using BooksAndVideosShop.Core.Model;

namespace BooksAndVideosShop.Core.Rules
{
    public class MembershipRule : IBusinessRule
    {
        private readonly IMembershipService _membershipService;

        public MembershipRule(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        public void Apply(long orderId, long customerId, Product product)
        {
            if (product.GetType() == typeof(MemberShip))
            {

            }
        }
    }
}
