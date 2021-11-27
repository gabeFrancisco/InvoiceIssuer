using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceIssuer.Web.Controllers.Api
{
    public class TakerApiController : Controller
    {
        private readonly ITakerService _takerService;
        public TakerApiController(ITakerService takerService)
        {
            _takerService = takerService;
        }

        [Route("/api/Taker/GetTakerData/{companyIndex}")]
        public async Task<IActionResult> GetTakerData([FromRoute] string companyIndex)
        {
            return Json(await _takerService.ReadTaker(companyIndex));
        }
    }
}