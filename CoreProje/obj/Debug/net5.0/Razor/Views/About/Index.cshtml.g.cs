#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38af6d4a2d9e0551ca4e4c2589c8bedd2d7120ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38af6d4a2d9e0551ca4e4c2589c8bedd2d7120ef", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a9968a2b79939a38765cc478adf3d5ef0f418", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.conrete.About>
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
#line 2 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
 using (Html.BeginForm("Index", "About", FormMethod.Post))

{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <!--üç tane paremtre alır 1cisi :actionun simi ,2cisi controller ismi,3cüsü form methodun türü   -->
    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">

                <p class=""card-description"">Hakkımda Düzenleme Paneli</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38af6d4a2d9e0551ca4e4c2589c8bedd2d7120ef4515", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label>ID</label>\r\n                        ");
#nullable restore
#line 20 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.AboutID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Başlık</label>\r\n                        ");
#nullable restore
#line 24 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Yaş</label>\r\n                        ");
#nullable restore
#line 28 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Age, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Mail</label>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Adres</label>\r\n                        ");
#nullable restore
#line 36 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Telefon</label>\r\n                        ");
#nullable restore
#line 40 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Görsel URL</label>\r\n                        ");
#nullable restore
#line 44 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.ImagUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Açıklama</label>\r\n                        ");
#nullable restore
#line 48 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"
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
#line 56 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\CoreProje\CoreProje\Views\About\Index.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.conrete.About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
