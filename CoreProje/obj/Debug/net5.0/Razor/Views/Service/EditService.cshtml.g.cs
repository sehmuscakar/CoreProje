#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f939b9074baab2924b185d60d0b77f27cc2ee2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_EditService), @"mvc.1.0.view", @"/Views/Service/EditService.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f939b9074baab2924b185d60d0b77f27cc2ee2e", @"/Views/Service/EditService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_EditService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.conrete.Service>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
  
    ViewData["Title"] = "EditService";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Hizmet Düzenleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 10 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
 using (Html.BeginForm("EditService", "Service", FormMethod.Post))

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\">Hizmet Düzenleme Paneli</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f939b9074baab2924b185d60d0b77f27cc2ee2e4587", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
               Write(Html.HiddenFor(x => x.ServiceID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 20 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
               Write(Html.Label("Hizmet Başlığı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
               Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("     \r\n                    <br />\r\n                    ");
#nullable restore
#line 23 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
               Write(Html.Label("Resim Yolu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <button class=\"btn btn-info\">Kaydet</button>\r\n\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\Service\EditService.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.conrete.Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
