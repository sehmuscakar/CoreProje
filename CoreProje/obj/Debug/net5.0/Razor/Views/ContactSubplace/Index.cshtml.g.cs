#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac0f4b27a954f082025a45d3b8d19261548edd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactSubplace_Index), @"mvc.1.0.view", @"/Views/ContactSubplace/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac0f4b27a954f082025a45d3b8d19261548edd1", @"/Views/ContactSubplace/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ContactSubplace_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.conrete.Contact>
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
#line 2 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"
 using (Html.BeginForm("Index", "ContactSubplace", FormMethod.Post))

{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!--üç tane paremtre alır 1cisi :actionun simi ,2cisi controller ismi,3cüsü form methodun türü   -->
    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">

                <p class=""card-description"">Alt İletişim Bilgileri Düzenleme Paneli</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac0f4b27a954f082025a45d3b8d19261548edd14624", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label>ID</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.ContactID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Başlık</label>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Telefon</label>\r\n                        ");
#nullable restore
#line 31 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Mail</label>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Açıklama</label>\r\n                        ");
#nullable restore
#line 39 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, 6, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary mr-2\">Kaydet</button>\r\n                    <button class=\"btn btn-dark\">İptal</button>\r\n                ");
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
#line 47 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\ContactSubplace\Index.cshtml"


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.conrete.Contact> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
