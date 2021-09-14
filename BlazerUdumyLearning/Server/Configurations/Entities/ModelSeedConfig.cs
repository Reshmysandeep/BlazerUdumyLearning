using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BlazerUdumyLearning.Shared.Domain;

namespace BlazerUdumyLearning.Server.Configurations.Entities
{
    public class ModelSeedConfig:IEntityTypeConfiguration<VehicleModel>
    {
        public void Configure(EntityTypeBuilder<VehicleModel> builder)
        {
            builder.HasData(

                new VehicleModel
                {
                    Id = 1,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    ModelName = "Prius",
                    UpdatedBy = "System",
                    Status = "A"
                },
                new VehicleModel
                {
                    Id = 2,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    ModelName = "Vitz",
                    UpdatedBy = "System",
                    Status = "A"
                },
                new VehicleModel
                {
                    Id = 3,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    ModelName = "3 Series",
                    UpdatedBy = "System",
                    Status = "A"
                },
                new VehicleModel
                {
                    Id = 4,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    ModelName = "X5",
                    UpdatedBy = "System"
                    ,Status="A"
                }
                );
           
        }
    }
}
