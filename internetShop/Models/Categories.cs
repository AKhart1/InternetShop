namespace internetShop.Models
{
    public class Categories
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }

        public List<Car> cars { get; set; }
    }
}
