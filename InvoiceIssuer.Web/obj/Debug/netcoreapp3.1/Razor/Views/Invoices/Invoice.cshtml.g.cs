#pragma checksum "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f19266a165428b53ced73a3305d2363fdfef8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoices_Invoice), @"mvc.1.0.view", @"/Views/Invoices/Invoice.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/_ViewImports.cshtml"
using InvoiceIssuer.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/_ViewImports.cshtml"
using InvoiceIssuer.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/_ViewImports.cshtml"
using InvoiceIssuer.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f19266a165428b53ced73a3305d2363fdfef8a", @"/Views/Invoices/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3196c13ff04c980e18acda76123a14ac340407f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoices_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceIssuer.Web.ViewModels.InvoicesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
  
    Layout = "_InvoicePreview";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"m-4 p-4\">\n    <div class=\"invoice-content\">\n        <div class=\"invoice-preview-title\">Service Invoice</div>\n        <div class=\"invoice-id\">\n            <div class=\"blue-text\"><b>Invoice Number: ");
#nullable restore
#line 10 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                                 Write(Model.Invoice.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 10 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                                                         Write(Model.Invoice.Date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n            <div>Date: ");
#nullable restore
#line 11 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                  Write(Model.Invoice.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div>GUID: ");
#nullable restore
#line 12 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                  Write(Model.Invoice.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>
        <div class=""content-row"">
            <div class=""wrap-content"">
                <div class=""blue-title"">
                    <span>PROVIDER</span>
                </div>
                <div class=""company-data"">
                    <div class=""m-2"">
                        <div><b>");
#nullable restore
#line 21 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                           Write(Model.Provider.ComercialName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n                        <div>CI: ");
#nullable restore
#line 22 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                            Write(Model.Provider.CI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>Comp. Type: ");
#nullable restore
#line 23 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                    Write(Model.Provider.CompanyType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 24 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Provider.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>Phone: ");
#nullable restore
#line 25 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                               Write(Model.Provider.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div>\n                    <div class=\"m-2\">\n                        <div>");
#nullable restore
#line 28 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Provider.Address.Road);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 28 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                                      Write(Model.Provider.Address.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                            ");
#nullable restore
#line 29 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                       Write(Model.Provider.Address.Complement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 30 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Provider.Address.Block);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 31 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Provider.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 32 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Provider.Address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>Postal Code: ");
#nullable restore
#line 33 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                     Write(Model.Provider.Address.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div>
            <div class=""wrap-content"">
                <div class=""blue-title"">
                    <span>TAKER</span>
                </div>
                <div class=""taker-data"">
                    <div class=""m-2"">
                        <div><b>");
#nullable restore
#line 43 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                           Write(Model.Taker.ComercialName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n                        <div>CI: ");
#nullable restore
#line 44 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                            Write(Model.Taker.CI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>Comp. Type: ");
#nullable restore
#line 45 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                    Write(Model.Taker.CompanyType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 46 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Taker.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>Phone: ");
#nullable restore
#line 47 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                               Write(Model.Taker.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div>\n                    <div class=\"m-2\">\n                        <div>");
#nullable restore
#line 50 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Taker.Address.Road);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 50 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                                   Write(Model.Taker.Address.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n                            ");
#nullable restore
#line 51 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                       Write(Model.Taker.Address.Complement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 52 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Taker.Address.Block);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 53 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Taker.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>");
#nullable restore
#line 54 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Taker.Address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        <div>Postal Code: ");
#nullable restore
#line 55 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                     Write(Model.Taker.Address.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""blue-title"">
            <h4>Description</h4>
        </div>
        <div class=""service-content"">
            <div class=""content-row mt-4 mb-3"">
                <h5>Title: ");
#nullable restore
#line 65 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                      Write(Model.Invoice.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <h5>Service Type: ");
#nullable restore
#line 66 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                             Write(Model.Invoice.ServiceType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            </div>\n            <div class=\"service-description\">\n                <p>");
#nullable restore
#line 69 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
              Write(Model.Invoice.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""blue-title"">
            <h4>Pricing</h4>
        </div>

        <div class=""pricing-content"">

            <div class=""pricing-content mt-4"">
                <div class=""content-row"">
                    <div>
                        <div>Service price: </div>
                    </div>
                    <div>
                        <div>");
#nullable restore
#line 84 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                        Write(Model.Invoice.TotalValue.ToString("c2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                    </div>\n                </div>\n                <div class=\"content-row\">\n                    <div>\n                        <div>Tax Rate: </div>\n                    </div>\n                    <div>\n                        <div>%");
#nullable restore
#line 92 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                         Write(Model.Invoice.TaxValue.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>
                <hr />
                <div class=""content-row"">
                    <div>
                        <h5 class=""blue-text""><b>Total:</b></h5>
                    </div>
                    <div>
                        <h5 class=""blue-text""><b>");
#nullable restore
#line 101 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/Invoice.cshtml"
                                            Write(Model.Invoice.TotalValue.ToString("c2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\n                    </div>\n                </div>\n            </div>\n        </div>\n        <div class=\"m-4\"></div>\n    </div>\n</div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public InvoiceIssuer.Web.Sessions.LoginStorage session { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceIssuer.Web.ViewModels.InvoicesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591