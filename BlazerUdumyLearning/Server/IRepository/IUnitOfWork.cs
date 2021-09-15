using BlazerUdumyLearning.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Server.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        Task Save(HttpContext httpcontext);
        IGenericRepository<Brand> Brands { get;}
        IGenericRepository<VehicleModel> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<VehicleColor> Colours { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
