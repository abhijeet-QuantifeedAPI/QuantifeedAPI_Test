using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuantifeedWebAPI.Data;
using QuantifeedWebAPI.Models;
using QuantifeedWebAPI.Repository;

namespace QuantifeedWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        IManagerRepository managerRepository;
        public ManagersController(IManagerRepository _managerRepository)
        {
            managerRepository = _managerRepository;
        }


        // GET: api/Clients
        [HttpGet]
        [Route("GetManagers")]
        public async Task<IActionResult> GetManagers()
        {
            try
            {
                var managers = await managerRepository.GetManagers();
                if (managers == null)
                {
                    return NotFound();
                }

                return Ok(managers);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // GET: api/Managers/5
        [HttpGet("{UserName}")]
        [Route("GetManager")]
        public async Task<IActionResult> GetManager([FromRoute] string UserName)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var managers = await managerRepository.GetManager(UserName);

            if (managers == null)
            {
                return NotFound();
            }

            return Ok(managers);
        }

        //// PUT: api/Managers/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutManager([FromRoute] int id, [FromBody] Manager manager)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != manager.ManagerId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(manager).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ManagerExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Managers
        //[HttpPost]
        //public async Task<IActionResult> PostManager([FromBody] Manager manager)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Managers.Add(manager);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetManager", new { id = manager.ManagerId }, manager);
        //}

        //// DELETE: api/Managers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteManager([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var manager = await _context.Managers.FindAsync(id);
        //    if (manager == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Managers.Remove(manager);
        //    await _context.SaveChangesAsync();

        //    return Ok(manager);
        //}

        //private bool ManagerExists(int id)
        //{
        //    return _context.Managers.Any(e => e.ManagerId == id);
        //}
    }
}