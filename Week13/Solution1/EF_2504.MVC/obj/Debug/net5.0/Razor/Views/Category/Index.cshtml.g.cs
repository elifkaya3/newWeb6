#pragma checksum "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d1fafb232e490d1847a1e0848140f5cbd33fc6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\_ViewImports.cshtml"
using EF_2504.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\_ViewImports.cshtml"
using EF_2504.DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d1fafb232e490d1847a1e0848140f5cbd33fc6f", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a16471e9520dd052b261e64a568202c60aa2cda", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Categories";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Category List</h1>\r\n<hr />\r\n\r\n<table>\r\n    <tr>\r\n        <td>Category Id</td>\r\n        <td>Category Name</td>\r\n        <td>Category Description</td>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\Category\Index.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\Category\Index.cshtml"
           Write(item.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Web ve Mobil Prog\Desktop\Projects_ElifKaya\newWeb6\Week13\Solution1\EF_2504.MVC\Views\Category\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
