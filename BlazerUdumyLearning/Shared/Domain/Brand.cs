using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Shared.Domain
{
    public class Brand:BaseDomain
    {
        [Required]
        public string BrandName { get; set; }
    }
}
