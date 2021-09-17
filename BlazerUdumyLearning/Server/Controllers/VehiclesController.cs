using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazerUdumyLearning.Server.Data;
using BlazerUdumyLearning.Shared.Domain;
using BlazerUdumyLearning.Server.IRepository;
using Microsoft.AspNetCore.Hosting;

namespace BlazerUdumyLearning.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public VehiclesController(IUnitOfWork context, IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._webHostEnvironment = webHostEnvironment;
            this._httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()

        {
            //var includes = new List<string> {"Brands", "Model", "Colour"};
            return Ok(await _context.Vehicles.GetAll(includes: q=>q.Include(b=>b.Brands).Include(m=>m.Model).Include(c=>c.Colour)));
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
           // var includes = new List<string> { "Brands", "Model", "Colour", "Bookings" };
            var vehicle = await _context.Vehicles.Get(v => v.Id == id);

            if (vehicle == null)
            {
                return NotFound();
            }

            return vehicle;
        }

        // GET: /Vehicles/5/details
        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetVehicleDetails(int id)
        {
            var Vehicle = await _context.Vehicles.Get(q => q.Id == id,
                includes: q => q.Include(x => x.Brands).Include(x => x.Model).Include(x => x.Colour));

            if (Vehicle == null)
            {
                return NotFound();
            }

            return Ok(Vehicle);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }
            if (vehicle.image != null)
            {
                vehicle.imageName = CreateFile(vehicle.image, vehicle.imageName);
            }
            _context.Vehicles.Update(vehicle);

            try
            {
                await _context.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            if (vehicle.image != null)
            {
                vehicle.imageName = CreateFile(vehicle.image, vehicle.imageName);
            }
            await _context.Vehicles.Insert(vehicle);
            await _context.Save(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        private string CreateFile(byte[] image, string name)
        {
           
                var url = _httpContextAccessor.HttpContext.Request.Host.Value;
                var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{name}";
                var fileStream = System.IO.File.Create(path);
                fileStream.Write(image, 0, image.Length);
                fileStream.Close();
                return $"https://{url}/uploads/{name}";


        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _context.Vehicles.Get(v => v.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            await _context.Vehicles.Delete(id);
            await _context.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            return await _context.Vehicles.IsExist(id);
        }
    }
}
