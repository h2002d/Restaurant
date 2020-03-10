#pragma checksum "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad783f890d62ff80df6ece079879a48151d265ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_All), @"mvc.1.0.view", @"/Views/Blog/All.cshtml")]
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
#line 1 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\_ViewImports.cshtml"
using Restaurant.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\_ViewImports.cshtml"
using Restaurant.WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad783f890d62ff80df6ece079879a48151d265ab", @"/Views/Blog/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed570ba15310d270426eaea5012f46e0041cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.WebApplication.ViewModels.BlogMainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
  
    ViewData["Title"] = "Blogs";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table id=\"listingTable\">\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Created on</th>\r\n        <th><a href=\"/Blog/Create\"><span class=\"glyphicon glyphicon-plus\" title=\"Add\"></span></a></th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
     foreach (var item in Model.Blogs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
           Write(item.CreateDate.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 582, "\"", 613, 2);
            WriteAttributeValue("", 589, "/Blog/Create?Id=", 589, 16, true);
#nullable restore
#line 18 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
WriteAttributeValue("", 605, item.Id, 605, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-edit\" title=\"Edit\"></span></a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 703, "\"", 731, 2);
            WriteAttributeValue("", 710, "/Blog/Delete/", 710, 13, true);
#nullable restore
#line 19 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
WriteAttributeValue("", 723, item.Id, 723, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-trash\" style=\"color:red\" title=\"Delete\"></span></a></td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
            WriteLiteral("<div class=\"blog-pagination\">\r\n    <ul>\r\n");
#nullable restore
#line 26 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
         for (int item = 1; item <= Model.PageCount; item++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li style=\"float: left;\">\r\n                <button class=\"no-round-btn smooth active\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1095, "\"", 1144, 5);
            WriteAttributeValue("", 1105, "location.href", 1105, 13, true);
            WriteAttributeValue(" ", 1118, "=", 1119, 2, true);
            WriteAttributeValue(" ", 1120, "\'/Blog/All?page=", 1121, 17, true);
#nullable restore
#line 29 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
WriteAttributeValue("", 1137, item, 1137, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1142, "\';", 1142, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
                                                                                                        Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n            </li>\r\n");
#nullable restore
#line 31 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Blog\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
