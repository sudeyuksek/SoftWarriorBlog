#pragma checksum "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f646ab2738ab49109e59156e83f13b38fe2a4e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Edit), @"mvc.1.0.view", @"/Views/Author/Edit.cshtml")]
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
#line 2 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\_ViewImports.cshtml"
using Blog.WebUI.Management.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\_ViewImports.cshtml"
using Blog.WebUI.Management.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\_ViewImports.cshtml"
using Blog.WebUI.Management.Singleton;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f646ab2738ab49109e59156e83f13b38fe2a4e8", @"/Views/Author/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"741d835886986bc88e550203c146bc95cc91c11c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Model.Author>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Author/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
  
    ViewBag.Title = "Yazar Düzenle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">Yazar Düzenle</h1>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 255, "\"", 291, 1);
#nullable restore
#line 10 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
WriteAttributeValue("", 262, Url.Action("Index","Author"), 262, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary shadow-sm\">Listeye Dön</a>\r\n    </div>\r\n    <p class=\"mb-4\">\r\n        Burada Yazar düzenlerim\r\n    </p>\r\n\r\n    ");
#nullable restore
#line 16 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
Write(Html.Raw(ViewResultExtension.ViewResult(ViewBag.Result)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"card shadow mb-4\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f646ab2738ab49109e59156e83f13b38fe2a4e85639", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Adı Soyadı\" name=\"Fullname\"");
                BeginWriteAttribute("value", " value=\"", 780, "\"", 803, 1);
#nullable restore
#line 22 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
WriteAttributeValue("", 788, Model.Fullname, 788, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Mail\" name=\"Mail\"");
                BeginWriteAttribute("value", " value=\"", 981, "\"", 1000, 1);
#nullable restore
#line 25 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
WriteAttributeValue("", 989, Model.Mail, 989, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Username\" name=\"Username\"");
                BeginWriteAttribute("value", " value=\"", 1186, "\"", 1209, 1);
#nullable restore
#line 28 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
WriteAttributeValue("", 1194, Model.Username, 1194, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <input type=\"text\" class=\"form-control form-control-user\" placeholder=\"Password\" name=\"Password\"");
                BeginWriteAttribute("value", " value=\"", 1395, "\"", 1418, 1);
#nullable restore
#line 31 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
WriteAttributeValue("", 1403, Model.Password, 1403, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"form-group row\">\r\n                    <label class=\"col-form-label col-lg-2 text-right\">Aktif Mi?</label>\r\n                    <div class=\"col-lg-10\">\r\n                        ");
#nullable restore
#line 37 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
                   Write(Html.CheckBoxFor(a => a.IsActive, new { @class = "checkbox" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <input type=\"hidden\" class=\"form-control\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1838, "\"", 1855, 1);
#nullable restore
#line 41 "C:\Users\baris\Source\Repos\Blog\Blog.WebUI.Management\Views\Author\Edit.cshtml"
WriteAttributeValue("", 1846, Model.Id, 1846, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Güncelle</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Blog.WebUI.Infrastructure.Cache.CacheHelper cache { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Model.Author> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
