using EmployeeManagement.API.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        [HttpGet]
        public ActionResult Get()
        { var data = _context.Employees.ToList();
            return Ok(data);
        }

    }
}
