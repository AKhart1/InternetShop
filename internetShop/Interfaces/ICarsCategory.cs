using internetShop.Models;

namespace internetShop.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Categories> AllCategories { get; }
    }
}
