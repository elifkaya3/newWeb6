#pragma checksum "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1328f899a5fcb73a6195c20e5ce2216a9bbd307"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1328f899a5fcb73a6195c20e5ce2216a9bbd307", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442965d8d34ced645b8ed9103ed55af0d8718c9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 10 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 15 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\Home\Index.cshtml"
             foreach (var product in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 19 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\Home\Index.cshtml"
           Write(await Html.PartialAsync("_Product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\MiniShopApp\MiniShopApp\MiniShopApp.WebUI\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591