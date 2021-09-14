using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazerUdumyLearning.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazerUdumyLearning.Server.Configurations.Entities
{
    public class ColorSeedConfig : IEntityTypeConfiguration<VehicleColor>
    {
        public void Configure(EntityTypeBuilder<VehicleColor> builder)
        {
            builder.HasData(new VehicleColor
            {
                Id = 1,
                CreatedBy = "system",
                CreatedDate = DateTime.Now.Date,
                UpdatedBy = "System",
                UpdatedDate = DateTime.Now.Date,
                Color = "Black",
                Status = "A"
            }, new VehicleColor
            {
                Id = 2,
                CreatedBy = "system",
                CreatedDate = DateTime.Now.Date,
                UpdatedBy = "System",
                UpdatedDate = DateTime.Now.Date,
                Color = "Green",
                Status = "A"
            }, new VehicleColor
            {
                Id = 3,
                CreatedBy = "system",
                CreatedDate = DateTime.Now.Date,
                UpdatedBy = "System",
                UpdatedDate = DateTime.Now.Date,
                Color = "Red",
                Status = "A"
            }

           );
        }
    }
}
