using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentCar.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CarType { get; set; }
        public int CarPrice { get; set; }
    }

    public class CarRentalContext : DbContext //inbuilt class in entity work
    {
        //enables CRUD functionality
        public DbSet<Car> Cars { get; set; } //ignores all other class files and creates only files for this class
    }
}