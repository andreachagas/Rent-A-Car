using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentCar.ViewModels
{
    //View Models
    public class StoreCar
    {
        public Store store { get; set; }
        public List<Car> cars { get; set; }

    }
}