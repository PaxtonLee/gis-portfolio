#pragma checksum "C:\Users\ethan\Source\Repos\gis-portfolio\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "472f2efd9a5292b8c903169ca4a8971ed8b1e506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(gis_portfolio.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace gis_portfolio.Pages
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
#line 1 "C:\Users\ethan\Source\Repos\gis-portfolio\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ethan\Source\Repos\gis-portfolio\Pages\_ViewImports.cshtml"
using gis_portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ethan\Source\Repos\gis-portfolio\Pages\_ViewImports.cshtml"
using gis_portfolio.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"472f2efd9a5292b8c903169ca4a8971ed8b1e506", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6903497fae489faeccecfcc753e0f1da10c96acf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ethan\Source\Repos\gis-portfolio\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .text-left {\r\n        background-color: rgb(245,130,42);\r\n    }\r\n    \r\n    \r\n    \r\n</style>\r\n\r\n<div class=\"text-left\">\r\n    <h1 class=\"display-4\">Hendrix GIS Portfolio</h1>\r\n    <p> Connor, Paxton, Caleb, Ethan</p>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\ethan\Source\Repos\gis-portfolio\Pages\Index.cshtml"
Write(Html.DropDownList("Sort by",
                    new SelectList(Enum.GetValues(typeof(Sort))),
                    "Sort By",
                    new { @class = "form-control", style = "width: 190px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591