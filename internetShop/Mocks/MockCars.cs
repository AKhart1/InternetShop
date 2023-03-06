using internetShop.Interfaces;
using internetShop.Models;

namespace internetShop.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Porsche 911",
                        shortDesc = "Comfortable and Fashion car",
                        longDesc = "The 2023 Porsche 911 blends world-class performance," +
                        "iconic styling and daily driver versatility into an elegant and refined package.",
                        img = "https://cars.usnews.com/pics/size/350x262/images/Auto/izmo/i159615409/2023_porsche_911_0_angularfront.jpg",
                        price = 6660,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                    new Car
                    {
                        name = "Mercedes-AMG",
                        shortDesc = "Strong car",
                        longDesc = " it’s the performance versions of the E-Class family",
                        img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgRWoUsoRl6JesQwfqfIJHCoVdPbSrTax5JwdY1JqMxL4Zl1T__yk7JZaKvTUxJeMfiF4&usqp=CAU",
                        price = 9990,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    
                    new Car
                    {
                        name = "BMW M4",
                        shortDesc = "Powerfull and sexy car",
                        longDesc = "Car 4 guys with big balls and pocket",
                        img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT2HY5B4dRnKzyyv0NkbcNX3sw1dE9nEKkjNQ&usqp=CAU",
                        price = 1300,
                        isFavourite = true,
                        available = false,
                        Category = _categoryCars.AllCategories.First()
                    }
                };

            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
