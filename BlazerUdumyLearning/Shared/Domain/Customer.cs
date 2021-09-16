using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Shared.Domain
{
    public class Customer:BaseDomain
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter Tax Id")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Tax Id does not meet length requirements")]
        public string TaxId { get; set; }
        public string Address { get; set; }
        [Required]
        [Phone]
        public string ContactNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}
