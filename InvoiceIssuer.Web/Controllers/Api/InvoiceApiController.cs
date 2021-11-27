using System.Threading.Tasks;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceIssuer.Web.Controllers.Api
{
    public class InvoiceApiController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceApiController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        [Route("/api/Invoices/GetProviderInvoiceHistory")]
        public async Task<IActionResult> GetProviderInvoiceHistory() => Json(await _invoiceService.GetInvoiceMonths());
    }
}