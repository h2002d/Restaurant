#pragma checksum "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72fb9f44b0503e57c2f557016186ee80ca9c721b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\_ViewImports.cshtml"
using Restaurant.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\_ViewImports.cshtml"
using Restaurant.WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72fb9f44b0503e57c2f557016186ee80ca9c721b", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed570ba15310d270426eaea5012f46e0041cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.WebApplication.ViewModels.BlogMainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""ogami-breadcrumb"">
    <div class=""container"">
        <ul>
            <li> <a class=""breadcrumb-link"" href=""/""> <i class=""fas fa-home""></i>Главная</a></li>
            <li> <a class=""breadcrumb-link active"" href=""/Blog"">Блог</a></li>
        </ul>
    </div>
</div>
<!-- End breadcrumb-->
<div class=""blog-layout"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""blog-grid"">
                    <div class=""row"">
");
#nullable restore
#line 17 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
                         foreach (var blog in Model.Blogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-6\">\r\n                                <div class=\"blog-block\">\r\n                                    <div class=\"blog-img\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 871, "\"", 901, 2);
            WriteAttributeValue("", 878, "/Blog/Index?Id=", 878, 15, true);
#nullable restore
#line 22 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
WriteAttributeValue("", 893, blog.Id, 893, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 953, "\"", 1097, 1);
#nullable restore
#line 23 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
WriteAttributeValue("", 959, blog.BlogImages==null||blog.BlogImages.FirstOrDefault()==null?"~/images/blog/list_img_1.png":blog.BlogImages.FirstOrDefault().ImagePath, 959, 138, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                                 alt=""blog image"">
                                        </a>
                                    </div>
                                    <div class=""blog-text"">
                                        <a class=""blog-title""");
            BeginWriteAttribute("href", " href=\"", 1380, "\"", 1410, 2);
            WriteAttributeValue("", 1387, "/Blog/Index?Id=", 1387, 15, true);
#nullable restore
#line 28 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1402, blog.Id, 1402, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
                                                                                        Write(blog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <div class=\"blog-credit\">\r\n                                            <p class=\"credit date\">");
#nullable restore
#line 30 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
                                                              Write(blog.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 35 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"blog-pagination\">\r\n                    <ul>\r\n");
#nullable restore
#line 40 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
                         for (int item = 1; item <= Model.PageCount; item++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <button class=\"no-round-btn smooth active\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2137, "\"", 2188, 5);
            WriteAttributeValue("", 2147, "location.href", 2147, 13, true);
            WriteAttributeValue(" ", 2160, "=", 2161, 2, true);
            WriteAttributeValue(" ", 2162, "\'/Blog/Index?page=", 2163, 19, true);
#nullable restore
#line 43 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2181, item, 2181, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2186, "\';", 2186, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
                                                                                                                          Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                            </li>\r\n");
#nullable restore
#line 45 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Blog\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- End blog layout-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.WebApplication.ViewModels.BlogMainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
