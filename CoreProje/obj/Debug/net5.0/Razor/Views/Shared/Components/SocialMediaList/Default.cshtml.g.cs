#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518d4b410f1e6fadde9a0eca8dbf4db0b11cc53f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SocialMediaList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
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
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml"
using EntityLayer.conrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518d4b410f1e6fadde9a0eca8dbf4db0b11cc53f", @"/Views/Shared/Components/SocialMediaList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SocialMediaList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"social-nav\" data-aos=\"fade-up\" data-aos-delay=\"200\">\r\n    <nav role=\"navigation\">\r\n        <ul class=\"nav justify-content-left\">   \r\n");
#nullable restore
#line 7 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml"
             foreach(var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\"><a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 296, "\"", 312, 1);
#nullable restore
#line 8 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 303, item.Url, 303, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 313, "\"", 331, 1);
#nullable restore
#line 8 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 321, item.Name, 321, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 335, "\"", 353, 1);
#nullable restore
#line 8 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml"
WriteAttributeValue("", 343, item.Icon, 343, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i><span class=\"menu-title sr-only\">");
#nullable restore
#line 8 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml"
                                                                                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a></li>\r\n");
#nullable restore
#line 9 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\SocialMediaList\Default.cshtml"
            }       

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
