using Mihaiu_Ionut_Lab2.Models;

namespace Mihaiu_Ionut_Lab2.Pages.Categories
{
    public class CategoryIndexData
    {
        public List<Category> Categories { get; internal set; }
        public ICollection<BookCategory>? BookCategories { get; internal set; }
    }
}