#pragma checksum "C:\Users\elifk\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7169ee0508a4c3b1b770dc006229fdd8250c39c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Index), @"mvc.1.0.view", @"/Views/Member/Index.cshtml")]
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
#line 1 "C:\Users\elifk\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\_ViewImports.cshtml"
using YemekTarifleriApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elifk\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\_ViewImports.cshtml"
using YemekTarifleriApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elifk\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\_ViewImports.cshtml"
using YemekTarifleriApp.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7169ee0508a4c3b1b770dc006229fdd8250c39c0", @"/Views/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9636fb26f938fe2fefebde1675109dc3c8e02a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YemekTarifleriApp.Entity.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\elifk\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Member\Index.cshtml"
         foreach (var member in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 8 "C:\Users\elifk\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Member\Index.cshtml"
           Write(await Html.PartialAsync("_Member", member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 10 "C:\Users\elifk\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Member\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<YemekTarifleriApp.Entity.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
