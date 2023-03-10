#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d22e30c3518bddad698e78e03738eaa0a6e2df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
using EntityLayer.conrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d22e30c3518bddad698e78e03738eaa0a6e2df7", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0"">
                <h3 class=""text-white mb-0"">Projelerim</h3>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">Proje</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Ücret</th>
                            <th scope=""col"" class=""sort"" data-sort=""status"">Durum</th>                    
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Tamamlanma Oranı</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"">Düzenle</th>
                        </tr>
                    </thead>
                    <tbody cl");
            WriteLiteral("ass=\"list\">\r\n");
#nullable restore
#line 27 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <tr>
                            <th scope=""row"">
                                <div class=""media align-items-center"">
                                    <a href=""#"" class=""avatar rounded-circle mr-3"">
                                        <img alt=""Image placeholder""");
            BeginWriteAttribute("src", " src=\"", 1571, "\"", 1591, 1);
#nullable restore
#line 35 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1577, item.Platform, 1577, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </a>\r\n                                    <div class=\"media-body\">\r\n                                        <span class=\"name mb-0 text-sm\">");
#nullable restore
#line 38 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </th>\r\n                            <td class=\"budget\">\r\n                                ");
#nullable restore
#line 43 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                            <td>
                                <span class=""badge badge-dot mr-4"">
                                    <i class=""bg-success""></i>
                                    <span class=""status"">Tamamlandı</span>
                                </span>
                            </td>
                            <td>
                                <div class=""d-flex align-items-center"">
                                    <span class=""completion mr-2"">");
#nullable restore
#line 53 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
                                                             Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                    <div>\r\n                                        <div class=\"progress\">\r\n                                            <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2757, "\"", 2784, 1);
#nullable restore
#line 56 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 2773, item.Value, 2773, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 2823, "\"", 2850, 3);
            WriteAttributeValue("", 2831, "width:", 2831, 6, true);
#nullable restore
#line 56 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
WriteAttributeValue(" ", 2837, item.Value, 2838, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2849, "%", 2849, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3061, "\"", 3110, 2);
            WriteAttributeValue("", 3068, "/Portfolio/DeletePortfolio/", 3068, 27, true);
#nullable restore
#line 61 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 3095, item.PortfliID, 3095, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Sil</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 3192, "\"", 3239, 2);
            WriteAttributeValue("", 3199, "/Portfolio/EditPortfolio/", 3199, 25, true);
#nullable restore
#line 62 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 3224, item.PortfliID, 3224, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Düzenle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Portfolio\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<a href=\"/Portfolio/AddPortfolio/\" class=\"btn btn-primary\"> Yeni Proje Girişi</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
