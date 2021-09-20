#pragma checksum "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2213e123548bf46f4799ac9f3e013aa4873990f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Info), @"mvc.1.0.view", @"/Views/Dashboard/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2213e123548bf46f4799ac9f3e013aa4873990f", @"/Views/Dashboard/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3196c13ff04c980e18acda76123a14ac340407f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashInformationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/company.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Company Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
  
	Layout = "_Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"m-4 p-4\">\n\n\t<div class=\"company-info\">\n\t\t<div>\n\t\t\t<h2>");
#nullable restore
#line 10 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
           Write(Model.Provider.ComercialName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\t\t\t<h5>CI nº ");
#nullable restore
#line 11 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                 Write(Model.Provider.CI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\t\t\t<h6>Company Type: ");
#nullable restore
#line 12 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                         Write(Model.Provider.CompanyType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\t\t\t<div>E-mail: ");
#nullable restore
#line 13 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                    Write(Model.Provider.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t\t<div>Comercial Phone: ");
#nullable restore
#line 14 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                             Write(Model.Provider.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t</div>\n\t\t<div>\n\t\t\t<div>");
#nullable restore
#line 17 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
            Write(Model.Provider.Address.Road);

#line default
#line hidden
#nullable disable
            WriteLiteral(", n° ");
#nullable restore
#line 17 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                                             Write(Model.Provider.Address.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 17 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                                                                             Write(Model.Provider.Address.Complement);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n\t\t\t\t");
#nullable restore
#line 18 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
           Write(Model.Provider.Address.Block);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t\t<div>");
#nullable restore
#line 19 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
            Write(Model.Provider.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t\t<div>State of ");
#nullable restore
#line 20 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                     Write(Model.Provider.Address.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t\t<div>Postal code: ");
#nullable restore
#line 21 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
                         Write(Model.Provider.Address.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t</div>\n\t\t<div class=\"company-logo\">\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c2213e123548bf46f4799ac9f3e013aa4873990f7752", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t</div>\n\t</div>\n\t<hr>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
