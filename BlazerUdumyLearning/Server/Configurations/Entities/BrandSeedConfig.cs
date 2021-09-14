

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BlazerUdumyLearning.Shared.Domain;

namespace BlazerUdumyLearning.Server.Configurations.Entities
{
    public class BrandSeedConfig: IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand
                {
                   Id=1,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandName = "Toyota",
                    UpdatedBy = "System",
                    Status="A"
                    
                },
                new Brand
                {
                    Id = 2,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandName = "BMW",
                    UpdatedBy = "System",
                    Status = "A"

                },
                new Brand
                {
                    Id = 3,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandName = "Nissan",
                    UpdatedBy = "System",
                    Status = "A"

                },
                new Brand
                {
                    Id =4,
                    CreatedBy = "System",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    BrandName = "Honda",
                    UpdatedBy = "System",
                    Status = "A"

                }
            );
            
        }
    }
}
