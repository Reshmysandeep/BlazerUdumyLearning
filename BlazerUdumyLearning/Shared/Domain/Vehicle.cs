using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Shared.Domain
{
    public  class Vehicle : BaseDomain
    {
        public int Year { get; set; }
        public int ModelId { get; set; }
        public virtual VehicleModel Model { get; set; }
        public int MakeId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual VehicleColor Colour { get; set; }
        public int ColourId { get; set; }
        public string Vin { get; set; }
        public string LicensePlateNumber { get; set; }
        public double RentalRate { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
