using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceIssuer.Web.Controllers.Api
{
    public class TakerController : Controller
    {
        private readonly ITakerService _takerService;
        public TakerController(ITakerService takerService)
        {
            _takerService = takerService;
        }

        [Route("/Taker/GetTakerData/{companyIndex}")]
        public async Task<IActionResult> GetTakerData([FromRoute] string companyIndex)
        {
            return Json(await _takerService.ReadTaker(companyIndex));
        }
    }
}