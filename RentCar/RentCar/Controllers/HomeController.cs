using RentCar.Models;
using RentCar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {
        private CarRentalContext db = new CarRentalContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Cars()
        {
            var cars = db.Cars.ToList();
            return View(cars);
        }

       
    }
}