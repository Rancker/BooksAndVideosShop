using BooksAndVideosShop.Core.Interfaces;
using BooksAndVideosShop.Core.Model.Enum;

namespace BooksAndVideosShop.Core.Model
{
    public class MemberShip : Product
    {
        public MembershipType Type { get; set; }

    }
}