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
    public class VehicleColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleColorsController(IUnitOfWork context)
        {
            _unitOfWork = context;
        }

        // GET: api/VehicleColors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleColor>>> GetVehicleColors()
        {
            return Ok(await _unitOfWork.Colours.GetAll());
        }

        // GET: api/VehicleColors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleColor>> GetVehicleColor(int id)
        {
            var vehicleColor = await _unitOfWork.Colours.Get(c=>c.Id==id);

            if (vehicleColor == null)
            {
                return NotFound();
            }

            return vehicleColor;
        }

        // PUT: api/VehicleColors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleColor(int id, VehicleColor vehicleColor)
        {
            if (id != vehicleColor.Id)
            {
                return BadRequest();
            }

           
            _unitOfWork.Colours.Update(vehicleColor);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleColorExists(id))
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

        // POST: api/VehicleColors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleColor>> PostVehicleColor(VehicleColor vehicleColor)
        {
            await _unitOfWork.Colours.Insert(vehicleColor);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicleColor", new { id = vehicleColor.Id }, vehicleColor);
        }

        // DELETE: api/VehicleColors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicleColor(int id)
        {
            var vehicleColor = await _unitOfWork.Colours.Get(C=>C.Id==id);
            if (vehicleColor == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colours.Delete(id);
            await  _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleColorExists(int id)
        {
            
            return await _unitOfWork.Colours.IsExist(id);
        }
    }
}
