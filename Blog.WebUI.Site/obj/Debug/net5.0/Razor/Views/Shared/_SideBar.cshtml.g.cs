#pragma checksum "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83354cc8229696b2d4c9b853bd6dabadf414f2f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideBar), @"mvc.1.0.view", @"/Views/Shared/_SideBar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83354cc8229696b2d4c9b853bd6dabadf414f2f6", @"/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"233ee906ec78307582e5202fac8a645a3b12ac5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"col-md-3 animate-box\" data-animate-effect=\"fadeInRight\">\r\n    <div>\r\n        <div class=\"fh5co_heading fh5co_heading_border_bottom py-2 mb-4\">Tags</div>\r\n    </div>\r\n    <div class=\"clearfix\"></div>\r\n    <div class=\"fh5co_tags_all\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Shared\_SideBar.cshtml"
         foreach (var item in cache.GetTags)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <a");
            BeginWriteAttribute("href", " href=\"", 321, "\"", 381, 1);
#nullable restore
#line 12 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Shared\_SideBar.cshtml"
WriteAttributeValue("", 328, Url.Action("Index", "Tag", new { slug = item.Slug }), 328, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fh5co_tagg\">");
#nullable restore
#line 12 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Shared\_SideBar.cshtml"
                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 13 "C:\Users\baris\source\repos\Blog\Blog.WebUI.Site\Views\Shared\_SideBar.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
