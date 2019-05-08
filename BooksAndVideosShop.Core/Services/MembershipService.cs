using BooksAndVideosShop.Core.Interfaces;
using BooksAndVideosShop.Core.Model.Enum;
using System;

namespace BooksAndVideosShop.Core.Services
{
    public class MembershipService : IMembershipService
    {
        public void ActivateMembership(long customerId, MembershipType membershipType)
        {
            throw new NotImplementedException();
        }

        public void UpgradeMembership(long customerId, MembershipType membershipType)
        {
            throw new NotImplementedException();
        }

        public void DeactivateMembership(long customerId, MembershipType membershipType)
        {
            throw new NotImplementedException();
        }
    }
}
