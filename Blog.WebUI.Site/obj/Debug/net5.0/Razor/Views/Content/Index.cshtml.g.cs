#pragma checksum "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Content\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2beac8066bfcdf7a39b9710ca5fc905ec457ffb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Content_Index), @"mvc.1.0.view", @"/Views/Content/Index.cshtml")]
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
#line 2 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\_ViewImports.cshtml"
using Blog.WebUI.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2beac8066bfcdf7a39b9710ca5fc905ec457ffb2", @"/Views/Content/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233ee906ec78307582e5202fac8a645a3b12ac5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Content_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Content\Index.cshtml"
  
    ViewBag.Title = Model.Content.MetaTitle;
    var media = Model.Content.Media;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n\r\n    <style>\r\n        #fh5co-title-box {\r\n            position: relative;\r\n            height: 700px;\r\n            width: 100%;\r\n        }\r\n        .description img{\r\n            max-width : 100%;\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n<div id=\"fh5co-title-box\"");
            BeginWriteAttribute("style", " style=\"", 393, "\"", 521, 4);
            WriteAttributeValue("", 401, "background-image:", 401, 17, true);
            WriteAttributeValue(" ", 418, "url(", 419, 5, true);
#nullable restore
#line 22 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Content\Index.cshtml"
WriteAttributeValue("", 423, Html.Raw(media != null ? "'"+media.MediaUrl+"'" : "/_assets/images/camila-cordeiro-114636.jpg"), 423, 96, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 519, ");", 519, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"overlay\"></div>\r\n    <div class=\"page-title\">\r\n        <span>");
#nullable restore
#line 25 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Content\Index.cshtml"
         Write(Model.Content.PublishDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <h2>");
#nullable restore
#line 26 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Content\Index.cshtml"
       Write(Model.Content.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    </div>
</div>
<div id=""fh5co-single-content"" class=""container-fluid pb-4 pt-4 paddding"">
    <div class=""container paddding"">
        <div class=""row mx-0"">
            <div class=""col-md-8 animate-box description"" data-animate-effect=""fadeInLeft"">
                ");
#nullable restore
#line 33 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Content\Index.cshtml"
           Write(Html.Raw(Model.Content.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            ");
#nullable restore
#line 35 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Content\Index.cshtml"
       Write(await Html.PartialAsync("_SideBar"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
