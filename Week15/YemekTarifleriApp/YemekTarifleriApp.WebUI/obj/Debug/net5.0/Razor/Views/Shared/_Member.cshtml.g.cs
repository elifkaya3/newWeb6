#pragma checksum "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Shared\_Member.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad74afd4c663f3af8299af53e65f659f166092fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Member), @"mvc.1.0.view", @"/Views/Shared/_Member.cshtml")]
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
#line 1 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\_ViewImports.cshtml"
using YemekTarifleriApp.WebUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad74afd4c663f3af8299af53e65f659f166092fa", @"/Views/Shared/_Member.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236b6392cdb9c95bb0c97198a799e58a3c3e633b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Member : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YemekTarifleriApp.Entity.Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card mr-5 mb-2\" style=\"height: 22rem;\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 5 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Shared\_Member.cshtml"
                          Write(Model.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">");
#nullable restore
#line 6 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Shared\_Member.cshtml"
                        Write(Model.MemberUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p class=\" card-text\">");
#nullable restore
#line 7 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Shared\_Member.cshtml"
                         Write(Model.RecipeMembers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YemekTarifleriApp.Entity.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
