/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagmentSystem.Models;

namespace StudentManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationDetailsController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public EducationDetailsController(StudentDbContext context)
        {
            _context = context;
        }

        // GET: api/EducationDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EducationDetails>>> GetEducationDetail()
        {
            if (_context.EducationDetail == null)
            {
                return NotFound();
            }
            return await _context.EducationDetail.ToListAsync();
        }

        // GET: api/EducationDetails/5
        [HttpGet("{StudentId}")]
        public async Task<ActionResult<EducationDetails>> GetEducationDetails(int StudentId)
        {
            if (_context.EducationDetail == null)
            {
                return NotFound();
            }
            var educationDetails = await _context.EducationDetail.FindAsync(StudentId);

            if (educationDetails == null)
            {
                return NotFound();
            }

            return educationDetails;
        }

        // PUT: api/EducationDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducationDetails(int id, EducationDetails educationDetails)
        {
            if (id != educationDetails.Id)
            {
                return BadRequest();
            }

            _context.Entry(educationDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationDetailsExists(id))
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

        // POST: api/EducationDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EducationDetails>> PostEducationDetails(EducationDetails educationDetails)
        {
            if (_context.EducationDetail == null)
            {
                return Problem("Entity set 'StudentDbContext.EducationDetail'  is null.");
            }
            _context.EducationDetail.Add(educationDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEducationDetails", new { id = educationDetails.Id }, educationDetails);
        }

        // DELETE: api/EducationDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducationDetails(int id)
        {
            if (_context.EducationDetail == null)
            {
                return NotFound();
            }
            var educationDetails = await _context.EducationDetail.FindAsync(id);
            if (educationDetails == null)
            {
                return NotFound();
            }

            _context.EducationDetail.Remove(educationDetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EducationDetailsExists(int id)
        {
            return (_context.EducationDetail?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
*/