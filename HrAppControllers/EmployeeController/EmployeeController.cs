using HrAppDataAcces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppControllers.EmployeeController
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public EmployeeController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployee()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            return Ok();
        }
    }
}
