#pragma checksum "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0223053c7bf3fa18515d2d8deeec0782268ec91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_List), @"mvc.1.0.view", @"/Views/Recipe/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0223053c7bf3fa18515d2d8deeec0782268ec91", @"/Views/Recipe/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236b6392cdb9c95bb0c97198a799e58a3c3e633b", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YemekTarifleriApp.WebUI.Models.RecipeListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-9\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
             foreach (var recipe in Model.Recipes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 10 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
               Write(await Html.PartialAsync("_RecipeDetails", recipe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 12 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <nav>\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 18 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
                             if (string.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 758, "\"", 826, 2);
            WriteAttributeValue("", 766, "page-item", 766, 9, true);
#nullable restore
#line 22 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
WriteAttributeValue(" ", 775, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 776, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 868, "\"", 893, 2);
            WriteAttributeValue("", 875, "/foods?page=", 875, 12, true);
#nullable restore
#line 23 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
WriteAttributeValue("", 887, i+1, 887, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 23 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
                                                                               Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 25 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1095, "\"", 1163, 2);
            WriteAttributeValue("", 1103, "page-item", 1103, 9, true);
#nullable restore
#line 28 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
WriteAttributeValue(" ", 1112, Model.PageInfo.CurrentPage==i+1 ? "active" : "", 1113, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1205, "\"", 1262, 4);
            WriteAttributeValue("", 1212, "/foods/", 1212, 7, true);
#nullable restore
#line 29 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
WriteAttributeValue("", 1219, Model.PageInfo.CurrentCategory, 1219, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1250, "?page=", 1250, 6, true);
#nullable restore
#line 29 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
WriteAttributeValue("", 1256, i+1, 1256, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"page-link\">");
#nullable restore
#line 29 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
                                                                                                               Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 31 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week15\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Recipe\List.cshtml"
       Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YemekTarifleriApp.WebUI.Models.RecipeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
