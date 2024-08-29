using HrAppBusiness.EmployeeRepository;
using HrAppDataAcces;
using HrAppDataAcces.DTOs.Employees;
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
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(DataBaseContext context,IEmployeeRepository employeeRepository)
        {
            _context = context;
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployee([FromBody] SalariatPostDto employee)
        {
            var result = _employeeRepository.CreateEmployee(employee);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            var result = await _employeeRepository.GetEmployees();
            return Ok(result);
        }
    }
}
