using BooksAndVideosShop.Core.Model.Enum;

namespace BooksAndVideosShop.Core.Interfaces
{
    public interface IMembershipService
    {
        void ActivateMembership(long customerId, MembershipType membershipType);
        void UpgradeMembership(long customerId, MembershipType membershipType);
        void DeactivateMembership(long customerId, MembershipType membershipType);
    }
}
