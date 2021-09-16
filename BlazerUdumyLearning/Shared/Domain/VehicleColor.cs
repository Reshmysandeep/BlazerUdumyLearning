using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Shared.Domain
{
    public class VehicleColor:BaseDomain
    {
        [Required]
        public string Color { get; set; }
    }
}
