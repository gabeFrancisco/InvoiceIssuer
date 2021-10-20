#pragma checksum "/mnt/76AAE8F7AAE8B531/ASP.Net Core/InvoiceIssuer/InvoiceIssuer.Web/Views/Shared/_Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffc76e8e54aba18e895b1983402f52ad3eb3da80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Chart), @"mvc.1.0.view", @"/Views/Shared/_Chart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffc76e8e54aba18e895b1983402f52ad3eb3da80", @"/Views/Shared/_Chart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3196c13ff04c980e18acda76123a14ac340407f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Chart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
	google.charts.load('current', { 'packages': ['corechart'] });
	google.charts.setOnLoadCallback(drawChart);

	function drawChart() {
		var data = google.visualization.arrayToDataTable([
			['Year', 'Sales', 'Expenses'],
			['2004', 1000, 400],
			['2005', 1170, 460],
			['2006', 660, 1120],
			['2007', 1030, 540]
		]);

		var options = {
			title: 'Company Performance',
			curveType: 'function',
			legend: { position: 'bottom' }
		};

		var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

		chart.draw(data, options);
	}
</script>

<div id=""curve_chart"" style=""width: 900px; height: 500px""></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591