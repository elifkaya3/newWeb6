#pragma checksum "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c965f11b6f327470144295b2c4b45925c305f6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
#line 1 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\_ViewImports.cshtml"
using YemekTarifleriApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\_ViewImports.cshtml"
using YemekTarifleriApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\_ViewImports.cshtml"
using YemekTarifleriApp.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c965f11b6f327470144295b2c4b45925c305f6b", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9636fb26f938fe2fefebde1675109dc3c8e02a12", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YemekTarifleriApp.Entity.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/CategoryDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-9"">
        <h6 class=""display-4 text-light"">Admin Kategori İşlemleri</h6>
        <hr />
        <a href=""/admin/categorycreate/create"" class=""btn btn-sm btn-success mb-1"">Yeni Kategori Ekle</a>

        <table class=""table"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Kategori Türü</th>
                    <th>Yapılacak İşlemler</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
                 if (Model.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
                     foreach (var category in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 23 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
                           Write(category.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 24 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
                           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 888, "\"", 935, 2);
            WriteAttributeValue("", 895, "/admin/categoryedit/", 895, 20, true);
#nullable restore
#line 26 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 915, category.CategoryId, 915, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary mr-1\">Kategori Düzenle</a>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c965f11b6f327470144295b2c4b45925c305f6b7268", async() => {
                WriteLiteral("\n                                    <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 1169, "\"", 1197, 1);
#nullable restore
#line 28 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1177, category.CategoryId, 1177, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">Kategori Sil</button>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 33 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week14\YemekTarifleriApp\YemekTarifleriApp.WebUI\Views\Admin\CategoryList.cshtml"
                     
                }
                else
                {
                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<YemekTarifleriApp.Entity.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
