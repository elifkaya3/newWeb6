#pragma checksum "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1308543567204d78460b77a26f83547b68598d9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitap_Details), @"mvc.1.0.view", @"/Views/Kitap/Details.cshtml")]
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
#line 1 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\_ViewImports.cshtml"
using EF_Core_Mvc_Code;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\_ViewImports.cshtml"
using EF_Core_Mvc_Code.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1308543567204d78460b77a26f83547b68598d9b", @"/Views/Kitap/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f3724761d73bf168172232dc368e61765374feb", @"/Views/_ViewImports.cshtml")]
    public class Views_Kitap_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kitaplar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  
    ViewData["Title"] = @Model.Ad + "adlı kitabın detayları";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 5 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" adlı kitabın detayları</h3>\r\n<hr>\r\n<div>\r\n    <h6>Kitabın ISBN</h6>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h6>Kitabın Adı</h6>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h6>Sayfa Sayısı</h6>\r\n    <p>");
#nullable restore
#line 13 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.SayfaSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h6>Stok</h6>\r\n    <p>");
#nullable restore
#line 15 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Stok);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <h6>Kitabın Türü</h6>\r\n    <p>");
#nullable restore
#line 18 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Tur.TurAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <h6>Kitabın Yazarı</h6>\r\n    <p>");
#nullable restore
#line 21 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.Yazar.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <h6>Kitabın Yayın Evi</h6>\r\n    <p>");
#nullable restore
#line 24 "C:\Users\Web ve Mobil Prog\Desktop\web6sabahyeni\Web6SabahYeni\week11\EF_Core_Mvc_Code\Views\Kitap\Details.cshtml"
  Write(Model.YayinEvi.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kitaplar> Html { get; private set; }
    }
}
#pragma warning restore 1591
