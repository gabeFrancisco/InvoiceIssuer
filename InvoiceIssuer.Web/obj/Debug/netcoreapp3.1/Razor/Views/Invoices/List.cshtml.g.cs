#pragma checksum "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2dfa95f24a8baa922a9f61f0a5d53f23551376f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoices_List), @"mvc.1.0.view", @"/Views/Invoices/List.cshtml")]
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
#line 1 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/_ViewImports.cshtml"
using InvoiceIssuer.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/_ViewImports.cshtml"
using InvoiceIssuer.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/_ViewImports.cshtml"
using InvoiceIssuer.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2dfa95f24a8baa922a9f61f0a5d53f23551376f", @"/Views/Invoices/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50761c83400641523529d5d21bd3e2e5e6a81aec", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoices_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoicesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Invoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
  
	Layout = "_Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"dashboard-menu pt-1 bg-light\">\n\t<ul>\n\t\t<li>\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2dfa95f24a8baa922a9f61f0a5d53f23551376f5496", async() => {
                WriteLiteral("\n\t\t\t\t<i class=\"fas fa-plus\"></i> New Invoice!\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t</li>\n\t</ul>\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2dfa95f24a8baa922a9f61f0a5d53f23551376f7077", async() => {
                WriteLiteral("\n\t\t<input class=\"form-control form-control-sm mr-2\" type=\"input\" placeholder=\"Search invoice...\">\n\t\t<button class=\"btn btn-primary btn-sm\" type=\"submit\"><i class=\"fas fa-search\"></i></button>\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n<table class=\"table table-sm table-hover\">\n\t<thead class=\"bg-light\">\n\t\t<tr>\n\t\t\t<th scope=\"col\">");
#nullable restore
#line 22 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
                       Write(Html.DisplayNameFor(model => model.Invoice.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\t\t\t<th scope=\"col\">");
#nullable restore
#line 23 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
                       Write(Html.DisplayNameFor(model => model.Invoice.Taker));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\t\t\t<th scope=\"col\">");
#nullable restore
#line 24 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
                       Write(Html.DisplayNameFor(model => model.Invoice.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\t\t\t<th scope=\"col\">");
#nullable restore
#line 25 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
                       Write(Html.DisplayNameFor(model => model.Invoice.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\t\t\t<th scope=\"col\">Invoice Value</th>\n\t\t</tr>\n\t</thead>\n\t<tbody>\n");
#nullable restore
#line 30 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
         foreach (var invoice in Model.Invoices.OrderBy(model => model.Number))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr");
            BeginWriteAttribute("onclick", " onclick=\"", 1029, "\"", 1127, 5);
            WriteAttributeValue("", 1039, "location.href", 1039, 13, true);
            WriteAttributeValue(" ", 1052, "=", 1053, 2, true);
            WriteAttributeValue(" ", 1054, "\'", 1055, 2, true);
#nullable restore
#line 32 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
WriteAttributeValue("", 1056, Url.Action("Invoice", "Invoices", new { invoiceGuid = invoice.Id }), 1056, 70, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1126, "\'", 1126, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t<td scope=\"row\">");
#nullable restore
#line 33 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
                           Write(Html.DisplayFor(model => invoice.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 33 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
                                                                       Write(Html.DisplayFor(model => invoice.Date.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t</td>\n\t\t\t\t<td>");
#nullable restore
#line 35 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
               Write(Html.DisplayFor(model => invoice.Taker.ComercialName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t<td>");
#nullable restore
#line 36 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
               Write(Html.DisplayFor(model => invoice.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t<td>");
#nullable restore
#line 37 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
               Write(Html.DisplayFor(model => invoice.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t\t<td>$");
#nullable restore
#line 38 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
                Write(Html.DisplayFor(model => invoice.TotalValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\t\t\t</tr>\n");
#nullable restore
#line 40 "/media/gabefrank/GENESIS/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Invoices/List.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\n\n\n</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public InvoiceIssuer.Services.Sessions.LoginStorage session { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoicesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
