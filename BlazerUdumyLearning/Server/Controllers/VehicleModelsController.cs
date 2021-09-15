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

namespace BlazerUdumyLearning.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelsController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public VehicleModelsController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/VehicleModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleModel>>> GetModels()
        {
            return Ok(await _context.Models.GetAll());
        }

        // GET: api/VehicleModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleModel>> GetVehicleModel(int id)
        {
            var vehicleModel = await _context.Models.Get(m=>m.Id==id);

            if (vehicleModel == null)
            {
                return NotFound();
            }

            return vehicleModel;
        }

        // PUT: api/VehicleModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleModel(int id, VehicleModel vehicleModel)
        {
            if (id != vehicleModel.Id)
            {
                return BadRequest();
            }

            _context.Models.Update(vehicleModel);// = EntityState.Modified;

            try
            {
                await _context.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleModelExists(id))
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

        // POST: api/VehicleModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleModel>> PostVehicleModel(VehicleModel vehicleModel)
        {
            await _context.Models.Insert(vehicleModel);
            await _context.Save(HttpContext);

            return CreatedAtAction("GetVehicleModel", new { id = vehicleModel.Id }, vehicleModel);
        }

        // DELETE: api/VehicleModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleModel(int id)
        {
            var vehicleModel = await _context.Models.Get(m=>m.Id==id);
            if (vehicleModel == null)
            {
                return NotFound();
            }

            await _context.Models.Delete(id);
            await _context.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleModelExists(int id)
        {
            return await _context.Models.IsExist(id);
        }
    }
}
