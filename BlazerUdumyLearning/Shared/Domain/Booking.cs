using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Shared.Domain
{
    public class Booking:BaseDomain,IValidatableObject
    {
        [Required]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicles { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }

        public virtual Customer Customers { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn != null)
            {
                if (DateIn <= DateOut)
                {
                    yield return new ValidationResult("Date In must be greater than Date Out", new[] { nameof(DateIn) });
                }
            }
        }
    }
}
