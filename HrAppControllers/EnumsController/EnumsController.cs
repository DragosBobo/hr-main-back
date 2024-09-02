using HrAppBusiness.FirmRepository;
using HrAppDataAcces.DTOs.Firm;
using HrAppDataAcces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrAppDataAcces.Entities.Revisal_entities.Enums;

namespace HrAppControllers.EnumsController
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnumsController : ControllerBase
    {

        [HttpGet("getTipActIdentitatePf")]
        public IActionResult GetTipActIdentitatePf()
        {
            var enumValues = Enum.GetValues(typeof(ActIdentitatePF)).Cast<ActIdentitatePF>();

            var result = enumValues.Select(e => new
            {
                Name = e.ToString(),
                Value = (int)e
            });

            return Ok(result);
        }
        [HttpGet("getActIdentitatePF")]
        public IActionResult GetActIdentitatePF()
        {
            return Ok(Enum.GetValues(typeof(ActIdentitatePF)).Cast<ActIdentitatePF>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getFormaJuridicaPF")]
        public IActionResult GetFormaJuridicaPF()
        {
            return Ok(Enum.GetValues(typeof(FormaJuridicaPF)).Cast<FormaJuridicaPF>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getFormaJuridicaPJ")]
        public IActionResult GetFormaJuridicaPJ()
        {
            return Ok(Enum.GetValues(typeof(FormaJuridicaPJ)).Cast<FormaJuridicaPJ>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getFormaOrganizarePF")]
        public IActionResult GetFormaOrganizarePF()
        {
            return Ok(Enum.GetValues(typeof(FormaOrganizarePF)).Cast<FormaOrganizarePF>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getFormaOrganizarePJ")]
        public IActionResult GetFormaOrganizarePJ()
        {
            return Ok(Enum.GetValues(typeof(FormaOrganizarePJ)).Cast<FormaOrganizarePJ>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getFormaProprietate")]
        public IActionResult GetFormaProprietate()
        {
            return Ok(Enum.GetValues(typeof(FormaProprietate)).Cast<FormaProprietate>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getNivelInflitrare")]
        public IActionResult GetNivelInflitrare()
        {
            return Ok(Enum.GetValues(typeof(NivelInfiintare)).Cast<NivelInfiintare>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getNormaTimpMunca")]
        public IActionResult GetNormaTimpMunca()
        {
            return Ok(Enum.GetValues(typeof(NormaTimpMunca)).Cast<NormaTimpMunca>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getRepartizareIntervalTimp")]
        public IActionResult GetRepartizareIntervalTimp()
        {
            return Ok(Enum.GetValues(typeof(RepartizareIntervalTimp)).Cast<RepartizareIntervalTimp>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getRepartizareTimpMunca")]
        public IActionResult GetRepartizareTimpMunca()
        {
            return Ok(Enum.GetValues(typeof(RepartizareTimpMunca)).Cast<RepartizareTimpMunca>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTemeiIncetare")]
        public IActionResult GetTemeiIncetare()
        {
            return Ok(Enum.GetValues(typeof(TemeiIncetare)).Cast<TemeiIncetare>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTemeiReactivare")]
        public IActionResult GetTemeiReactivare()
        {
            return Ok(Enum.GetValues(typeof(TemeiReactivare)).Cast<TemeiReactivare>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTemeiSuspendare")]
        public IActionResult GetTemeiSuspendare()
        {
            return Ok(Enum.GetValues(typeof(TemeiSuspendare)).Cast<TemeiSuspendare>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTipActIdentitate")]
        public IActionResult GetTipActIdentitate()
        {
            return Ok(Enum.GetValues(typeof(TipActIdentitate)).Cast<TipActIdentitate>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTipAutorizatie")]
        public IActionResult GetTipAutorizatie()
        {
            return Ok(Enum.GetValues(typeof(TipAutorizatie)).Cast<TipAutorizatie>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTipContract")]
        public IActionResult GetTipContract()
        {
            return Ok(Enum.GetValues(typeof(TipContract)).Cast<TipContract>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTipDurata")]
        public IActionResult GetTipDurata()
        {
            return Ok(Enum.GetValues(typeof(TipDurata)).Cast<TipDurata>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }

        [HttpGet("getTipNorma")]
        public IActionResult GetTipNorma()
        {
            return Ok(Enum.GetValues(typeof(TipNorma)).Cast<TipNorma>().Select(e => new { Name = e.ToString(), Value = (int)e }));
        }
    }
}
