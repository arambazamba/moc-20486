#pragma checksum "G:\Classes\20486D\Allfiles\Mod05\Labfiles\01_CitiesWebsite_end\CitiesWebsite\Views\Shared\_CityPopulation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e993a0b0f58a1c3f554d2014a23f1cbd50ef764c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CityPopulation), @"mvc.1.0.view", @"/Views/Shared/_CityPopulation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_CityPopulation.cshtml", typeof(AspNetCore.Views_Shared__CityPopulation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e993a0b0f58a1c3f554d2014a23f1cbd50ef764c", @"/Views/Shared/_CityPopulation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CityPopulation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "G:\Classes\20486D\Allfiles\Mod05\Labfiles\01_CitiesWebsite_end\CitiesWebsite\Views\Shared\_CityPopulation.cshtml"
  
    CitiesWebsite.Models.CityPopulation population = ViewBag.City.Population;

#line default
#line hidden
            BeginContext(144, 22, true);
            WriteLiteral("\n<h3>City Population (");
            EndContext();
            BeginContext(167, 15, false);
#line 7 "G:\Classes\20486D\Allfiles\Mod05\Labfiles\01_CitiesWebsite_end\CitiesWebsite\Views\Shared\_CityPopulation.cshtml"
                Write(population.Year);

#line default
#line hidden
            EndContext();
            BeginContext(182, 16, true);
            WriteLiteral(")</h3>\n<p>City: ");
            EndContext();
            BeginContext(199, 53, false);
#line 8 "G:\Classes\20486D\Allfiles\Mod05\Labfiles\01_CitiesWebsite_end\CitiesWebsite\Views\Shared\_CityPopulation.cshtml"
    Write(cityFormatter.GetFormattedPopulation(population.City));

#line default
#line hidden
            EndContext();
            BeginContext(252, 15, true);
            WriteLiteral("</p>\n<p>Urban: ");
            EndContext();
            BeginContext(268, 54, false);
#line 9 "G:\Classes\20486D\Allfiles\Mod05\Labfiles\01_CitiesWebsite_end\CitiesWebsite\Views\Shared\_CityPopulation.cshtml"
     Write(cityFormatter.GetFormattedPopulation(population.Urban));

#line default
#line hidden
            EndContext();
            BeginContext(322, 15, true);
            WriteLiteral("</p>\n<p>Metro: ");
            EndContext();
            BeginContext(338, 54, false);
#line 10 "G:\Classes\20486D\Allfiles\Mod05\Labfiles\01_CitiesWebsite_end\CitiesWebsite\Views\Shared\_CityPopulation.cshtml"
     Write(cityFormatter.GetFormattedPopulation(population.Metro));

#line default
#line hidden
            EndContext();
            BeginContext(392, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CitiesWebsite.Services.ICityFormatter cityFormatter { get; private set; }
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
