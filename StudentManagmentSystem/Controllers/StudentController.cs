using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagmentSystem.Filter;
using StudentManagmentSystem.Models;
using StudentManagmentSystem.Wrappers;

namespace StudentManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext _context;


        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<IActionResult> GetStudents([FromQuery]PaginationStudentFilter filter)
        {
            var validateFilter = new PaginationStudentFilter(filter.PageNumber, filter.PageSize);
            var pageData = await _context.Students.Include(e => e.educationDetails).Skip((validateFilter
                .PageNumber - 1)*validateFilter.PageSize)
                .Take(validateFilter.PageSize).ToListAsync();
            var totalRecords = await _context.Students.CountAsync();
            return Ok(new PagedStudentResponse<List<Student>>(pageData, validateFilter.PageNumber, validateFilter.PageSize));
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {

            var student = await _context.Students.Where(a => a.StudentId == id).Include(e => e.educationDetails).FirstOrDefaultAsync();
                        
            return Ok(new StudentResponse <Student>(student));
        }

        // PUT: api/Student/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
          /*  _context.Entry(student).State = EntityState.Modified;*/

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
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

        // POST: api/Student
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
          if (_context.Students == null)
          {
              return Problem("Entity set 'StudentDbContext.Students'  is null.");
          }
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }
            var student = await _context.Students.Where(a => a.StudentId == id).Include(e => e.educationDetails).FirstOrDefaultAsync();
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int id)
        {
            return (_context.Students?.Any(e => e.StudentId == id)).GetValueOrDefault();
        }
    }
}
