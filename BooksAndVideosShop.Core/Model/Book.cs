using BooksAndVideosShop.Core.Interfaces;

namespace BooksAndVideosShop.Core.Model
{
    public class Book : PhysicalProduct
    {
        public string Author { get; set; }
    }
}