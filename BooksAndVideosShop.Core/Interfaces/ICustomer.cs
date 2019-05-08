using BooksAndVideosShop.Core.Model.Enum;
using System.Collections.Generic;

namespace BooksAndVideosShop.Core.Interfaces
{
    public interface ICustomer
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        IEnumerable<MembershipType> Memberships { get; set; }
    }
}
