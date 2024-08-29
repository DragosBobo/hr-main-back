using HrAppBusiness.UserRepository;
using HrAppDataAcces.DTOs;
using HrAppDataAcces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppControllers.FirmController
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirmController : ControllerBase
    {
        private readonly DataBaseContext _context;

        public FirmController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> CreateFirm()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult> GetFirms()
        {
            return Ok();
        }
    }
}
