#pragma checksum "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74f38cecc5e78de715ed3374cf0b15bf58f3dcb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\_ViewImports.cshtml"
using CoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.conrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f38cecc5e78de715ed3374cf0b15bf58f3dcb3", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    #
                                </th>
                                <th>Ana Görsel</th>
                                <th>Proje Adı</th>
                                <th>URL</th>
                                <th>Fiyat</th>                         
                                <th>Tamamlanma</th>
                                <th>Durum</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 24 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 28 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.PortfliID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1265, "\"", 1285, 1);
#nullable restore
#line 31 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1271, item.ImageUrl, 1271, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 33 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 34 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>%");
#nullable restore
#line 36 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1633, "\"", 1680, 2);
            WriteAttributeValue("", 1640, "/Portfolio/EditPortfolio/", 1640, 25, true);
#nullable restore
#line 40 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1665, item.PortfliID, 1665, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"badge badge-outline-success\">Detayları Gör</div>\r\n                                    </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\scaka\OneDrive\Masaüstü\.Net (WEP)\CoreProje\CoreProje\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
