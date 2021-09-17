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
    public class BrandsController : ControllerBase
    {
        private readonly IUnitOfWork _unitofWork;

        public BrandsController(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        // GET: api/Brands
        [HttpGet]
        public async Task<IActionResult> GetBrands()
        {
            

            var brands= await _unitofWork.Brands.GetAll();
            return Ok(brands);
        }

        // GET: api/Brands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
           
            var brand = await _unitofWork.Brands.Get(p=>p.Id==id);

            if (brand == null)
            {
                return NotFound();
            }

            return Ok(brand);
        }

        // PUT: api/Brands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(int id, Brand brand)
        {
            if (id != brand.Id)
            {
                return BadRequest();
            }

            _unitofWork.Brands.Update(brand);

            try
            {
                await _unitofWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BrandExists(id))
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

        // POST: api/Brands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            await _unitofWork.Brands.Insert(brand);
            await _unitofWork.Save(HttpContext);

            return CreatedAtAction("GetBrand", new { id = brand.Id }, brand);
        }

        // DELETE: api/Brands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            var brand = await _unitofWork.Brands.Get(p => p.Id == id);
            if (brand == null)
            {
                return NotFound();
            }

            await _unitofWork.Brands.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BrandExists(int id)
        {
            return await _unitofWork.Brands.IsExist(id);
        }
    }
}
