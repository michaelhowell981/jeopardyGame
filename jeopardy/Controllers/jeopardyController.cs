using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jeopardy.Models;
using jeopardy.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jeopardy.Controllers
{
    [Route("api/[controller]")]
    public class jeopardyController : Controller
    {
        private readonly jeopardyContext _context;
        [HttpGet]
        public IEnumerable<question> GetAll()
        {
            return _context.CategoryName.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long id)
        {
            var item = _context.CategoryName.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        public jeopardyController(jeopardyContext context)
        {
            _context = context;

            if (_context.CategoryName.Count() == 0)
            {
 
                _context.CategoryName.Add(new question { categoryName = "Swords" });
                _context.SaveChanges();
            }
        }

    }
}
