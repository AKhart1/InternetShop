using internetShop.Interfaces;
using internetShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace internetShop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars IallCars, ICarsCategory IcarsCategories)
        {
            _allCars = IallCars;
            _allCategories = IcarsCategories;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Car's Page";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Auto";
            return View(obj);
        }
    }
}
