#pragma checksum "C:\Users\Lenovo\source\repos\ShopASPNETCORE\ShopASPNETCORE\Views\Cars\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d77118007ca598d9308d42f1a4b3805be5d50329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_List), @"mvc.1.0.view", @"/Views/Cars/List.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\ShopASPNETCORE\ShopASPNETCORE\Views\_ViewImports.cshtml"
using ShopASPNETCORE.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d77118007ca598d9308d42f1a4b3805be5d50329", @"/Views/Cars/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1704b0d1527b722c3e201fcbb555392ed631ba59", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>All Cars</h2>\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\ShopASPNETCORE\ShopASPNETCORE\Views\Cars\List.cshtml"
   
    foreach(var car in Model.GetCars)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <hr />\r\n            <h3>");
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\ShopASPNETCORE\ShopASPNETCORE\Views\Cars\List.cshtml"
           Write(Model.CarCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <h2>Model: ");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\ShopASPNETCORE\ShopASPNETCORE\Views\Cars\List.cshtml"
                  Write(car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>Price: ");
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\ShopASPNETCORE\ShopASPNETCORE\Views\Cars\List.cshtml"
                 Write(car.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 11 "C:\Users\Lenovo\source\repos\ShopASPNETCORE\ShopASPNETCORE\Views\Cars\List.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
