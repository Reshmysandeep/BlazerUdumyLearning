using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Shared.Domain
{
    public class VehicleModel:BaseDomain
    {
        [Required]
        public string ModelName { get; set; }
    }
}
