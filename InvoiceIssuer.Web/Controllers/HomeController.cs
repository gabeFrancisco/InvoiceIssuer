using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InvoiceIssuer.Web.Models;
using InvoiceIssuer.Web.Sessions;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Web.ViewModels;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginStorage _loginStorage;
        private readonly IProviderRepository _providerRepository;

        public HomeController(LoginStorage loginStorage, IProviderRepository providerRepository)
        {
            _loginStorage = loginStorage;
            _providerRepository = providerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] LoginViewModel viewModel)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var provider = new Provider();
            provider = await _providerRepository.GetByCI(viewModel.CI);
            string hashPassword = HashEncrypt.GenerateHash(viewModel.Password);

            if(provider == null || hashPassword != provider.Password.ToLower())
                return Unauthorized("CI or password incorrect!");
            
            else
                return new ContentResult() { Content = provider.ToString() };
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
