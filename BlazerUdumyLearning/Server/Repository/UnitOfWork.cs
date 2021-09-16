using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazerUdumyLearning.Server.Data;
using BlazerUdumyLearning.Server.IRepository;
using BlazerUdumyLearning.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using BlazerUdumyLearning.Server.Models;

namespace BlazerUdumyLearning.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private  IGenericRepository<Brand> _Brands;
        private IGenericRepository<VehicleModel> _models;
        private IGenericRepository<VehicleColor> _colours;
        private IGenericRepository<Booking> _bookings;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Vehicle> _vehicles;
        private UserManager<ApplicationUser> _userManager;
        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Brand> Brands => _Brands ??= new GenericRepository<Brand>(_context);

        public IGenericRepository<VehicleModel> Models => _models ??= new GenericRepository<VehicleModel>(_context);

        public IGenericRepository<Vehicle> Vehicles => _vehicles ??= new GenericRepository<Vehicle>(_context);

        public IGenericRepository<VehicleColor> Colours => _colours ??= new GenericRepository<VehicleColor>(_context);

        public IGenericRepository<Booking> Bookings => _bookings ??= new GenericRepository<Booking>(_context);

        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }


        public async Task Save(HttpContext httpcontext)
        {
            //var user = httpcontext.User.Identity.Name;

            var userid = httpcontext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userid);

            var enteries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified || q.State == EntityState.Added);
            foreach (var entry in enteries)
            {
                ((BaseDomain)entry.Entity).UpdatedDate = DateTime.Now.Date;
                ((BaseDomain)entry.Entity).UpdatedBy = user.UserName;
                if (entry.State==EntityState.Added)
                {
                    ((BaseDomain)entry.Entity).CreatedDate = DateTime.Now.Date;
                    ((BaseDomain)entry.Entity).CreatedBy = user.UserName;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
