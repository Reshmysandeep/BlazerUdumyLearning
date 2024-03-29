﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Shared.Domain
{
    public  class Vehicle : BaseDomain
    {
        [Required]
        public int Year { get; set; }
        [Required]
        public int ModelId { get; set; }
        public virtual VehicleModel Model { get; set; }
        [Required]
        public int BrandId { get; set; }
        public virtual Brand Brands { get; set; }
        public virtual VehicleColor Colour { get; set; }
        [Required]
        public int ColourId { get; set; }
        [Required]
        [Display(Name = "Vehicle Identification Number")]
        public string Vin { get; set; }
        [Required]
        [Display(Name = "License Plate Number")]
        public string LicensePlateNumber { get; set; }
        [Required]
        public double RentalRate { get; set; }
        public virtual List<Booking> Bookings { get; set; }
        [NotMapped]
        public byte[] image { get; set; }

        public string imageName { get; set; }
    }
}
