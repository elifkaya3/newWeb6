#pragma checksum "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Shared\_Food.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52a1323f55f9d1ea4681e24d3919cfac9f1ed006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Food), @"mvc.1.0.view", @"/Views/Shared/_Food.cshtml")]
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
#line 1 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using DurkayaRecipe.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a1323f55f9d1ea4681e24d3919cfac9f1ed006", @"/Views/Shared/_Food.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13187107c5e847ee11a72442c794dd3553fa9ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Food : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Food>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card mb-2\">\n    <div class=\"card-img p-2 text-md-center\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52a1323f55f9d1ea4681e24d3919cfac9f1ed0064803", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 101, "~/img/", 101, 6, true);
#nullable restore
#line 5 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Shared\_Food.cshtml"
AddHtmlAttributeValue("", 107, Model.ImageUrl, 107, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n    <div class=\"card-body\">\n        <h5 class=\"card-title text-center\">");
#nullable restore
#line 9 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Shared\_Food.cshtml"
                                      Write(Model.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <div class=\"card-footer bg-white text-center d-flex justify-content-around p-1\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 376, "\"", 421, 2);
            WriteAttributeValue("", 383, "/DurkayaRecipe/Details/?url=", 383, 28, true);
#nullable restore
#line 11 "C:\Users\PATRON\Desktop\Visual Studio\Projeler\Yemek Tarifi\DurkayaRecipe\DurkayaRecipe.WebUI\Views\Shared\_Food.cshtml"
WriteAttributeValue("", 411, Model.Url, 411, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n               class=\"btn btn-sm btn-primary\">Detail</a>\n            <a href=\"#\" class=\"btn btn-sm btn-success\">Add to Card</a>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Food> Html { get; private set; }
    }
}
#pragma warning restore 1591