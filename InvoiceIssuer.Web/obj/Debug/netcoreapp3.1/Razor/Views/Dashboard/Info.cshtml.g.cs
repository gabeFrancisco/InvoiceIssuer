#pragma checksum "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e39bcc36ff1390fafe67c9a838b6f1ba2612600"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e39bcc36ff1390fafe67c9a838b6f1ba2612600", @"/Views/Dashboard/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3196c13ff04c980e18acda76123a14ac340407f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashInformationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Dashboard/Info.cshtml"
  
	Layout = "_Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"dashboard-menu mb-3\">\n\t<ul>\n\t\t<li>+ New Invoice</li>\n\t\t<li>Edit Invoice</li>\n\t\t<li>Delete Invoice</li>\n\t</ul>\n\t<div class=\"card m-2\">\n\n\t</div>\n</div>\n");
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
