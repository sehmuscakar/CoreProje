#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e310f94428ee34166b6852448ad7b79bf597092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactDetails_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
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
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml"
using EntityLayer.conrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e310f94428ee34166b6852448ad7b79bf597092", @"/Views/Shared/Components/ContactDetails/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ContactDetails_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-6\" data-aos=\"fade-left\" data-aos-delay=\"300\">\r\n");
#nullable restore
#line 5 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml"
     foreach(var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-3 px-1\">\r\n\r\n        <div class=\"h5\">");
#nullable restore
#line 8 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml"
      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <p>Aşahıdaki adresler üzerinden bana mail gönderebilir veya sorularınızı iletebilirsiniz.</p>
        <p>Görüşmek Üzere</p>
    </div>
    <div class=""mt-53 px-1"">
        <div class=""row"">
            <div class=""col-sm-2"">
                <div class=""pb-1"">Mail</div>
            </div>
            <div class=""col-sm-10"">
                <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 19 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml"
                                       Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
            <div class=""col-sm-2"">
                <div class=""pb-1"">Youtube</div>
            </div>
     

            <div class=""col-sm-10"">
                <div class=""pb-1 fw-bolder"">Şehmus çakar</div>
            </div>
            <div class=""col-sm-2"">
                <div class=""pb-1"">Telefon</div>
            </div>
            <div class=""col-sm-10"">
                <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 33 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Shared\Components\ContactDetails\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
