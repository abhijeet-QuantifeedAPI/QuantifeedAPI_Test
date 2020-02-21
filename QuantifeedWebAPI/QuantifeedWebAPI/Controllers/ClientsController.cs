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
    public class ClientsController : ControllerBase
    {
        IClientRepository clientRepository;
        public ClientsController(IClientRepository _clientRepository)
        {
            clientRepository = _clientRepository;
        }


        // GET: api/Clients
        [HttpGet]
        [Route("GetClients")]
        public async Task<IActionResult> GetClients()
        {
            try
            {
                var clients = await clientRepository.GetClients();
                if (clients == null)
                {
                    return NotFound();
                }

                return Ok(clients);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //// GET: api/Clients/5
        //[HttpGet("{id}")]       
        //[Route("GetClients")]
        //public async Task<IActionResult> GetClient([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var client = await _context.Clients.FindAsync(id);

        //    if (client == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(client);
        //}

        //// PUT: api/Clients/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutClient([FromRoute] int id, [FromBody] Client client)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != client.ClientId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(client).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ClientExists(id))
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

        //// POST: api/Clients
        //[HttpPost]
        //public async Task<IActionResult> PostClient([FromBody] Client client)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Clients.Add(client);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetClient", new { id = client.ClientId }, client);
        //}

        //// DELETE: api/Clients/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteClient([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var client = await _context.Clients.FindAsync(id);
        //    if (client == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Clients.Remove(client);
        //    await _context.SaveChangesAsync();

        //    return Ok(client);
        //}

        //private bool ClientExists(int id)
        //{
        //    return _context.Clients.Any(e => e.ClientId == id);
        //}
    }
}