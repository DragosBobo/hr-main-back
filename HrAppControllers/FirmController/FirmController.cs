using HrAppBusiness.UserRepository;
using HrAppDataAcces.DTOs;
using HrAppDataAcces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrAppDataAcces.DTOs.Firm;
using HrAppBusiness.FirmRepository;

namespace HrAppControllers.FirmController
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirmController : ControllerBase
    {
        private readonly DataBaseContext _context;
        private readonly IFirmRepository _firmRepository;

        public FirmController(DataBaseContext context,IFirmRepository firmRepository)
        {
            _context = context;
            _firmRepository = firmRepository;
        }

        [HttpPost("/create-firm")]
        public async Task<ActionResult> CreateFirm([FromBody] FirmPostDto firm)
        {
            var result = _firmRepository.CreateFirm(firm);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult> GetFirms()
        {
            var result = await _firmRepository.GetFirms();
            return Ok(result);
        }
    }
}
