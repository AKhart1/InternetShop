using internetShop.Models;

namespace internetShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            //content == null
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(

                    new Car
                    {
                        name = "Porsche 911",
                        shortDesc = "Comfortable and Fashion car",
                        longDesc = "The 2023 Porsche 911 blends world-class performance," +
                        "iconic styling and daily driver versatility into an elegant and refined package.",
                        img = "/img/porche911.jpg",
                        price = 6660,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Sports car"]
                    },

                    new Car
                    {
                        name = "Mercedes-AMG",
                        shortDesc = "Strong car",
                        longDesc = " it’s the performance versions of the E-Class family",
                        img = "/img/m-amg.jpg",
                        price = 9990,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Sedan"]
                    },

                    new Car
                    {
                        name = "BMW M4",
                        shortDesc = "Powerfull and sexy car",
                        longDesc = "Car 4 guys with big balls and pocket",
                        img = "/img/bmw-m4.jpg",
                        price = 1300,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Sedan"]
                    },
                    
                    new Car
                    {
                        name = "Tesla Roadster",
                        shortDesc = "The first supercar to set every performance record and still fit seating for four.",
                        longDesc = "The Roadster will be a new addition to the Tesla lineup when it eventually enters production," +
                        " resurrecting the nameplate worn by the company's first model back in 2008. ",
                        img = "/img/tesla.webp",
                        price = 35000,
                        isFavourite = true,
                        available = true,
                        Category = category["Sports car"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Sports car", desc = "Sports cars are two-seater.."},
                        new Category{categoryName = "Sedan", desc = "Conventional example of a four-door passenger car"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                }
                return category;
            }
        }
    }
}
