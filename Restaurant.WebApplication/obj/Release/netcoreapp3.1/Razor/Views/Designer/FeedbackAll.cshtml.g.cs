#pragma checksum "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Designer\FeedbackAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001a37662cb8c72baad9e0469244ea314d843109"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Designer_FeedbackAll), @"mvc.1.0.view", @"/Views/Designer/FeedbackAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001a37662cb8c72baad9e0469244ea314d843109", @"/Views/Designer/FeedbackAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed570ba15310d270426eaea5012f46e0041cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Designer_FeedbackAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.WebApplication.ViewModels.FeedbackMainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Designer\FeedbackAll.cshtml"
  
    ViewData["Title"] = "Feedbacks";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table id=\"listingTable\">\r\n    <tr>\r\n        <th>Author</th>\r\n        <th><a href=\"/Designer/FeedbackCreate\"><span class=\"glyphicon glyphicon-plus\" title=\"Add\"></span></a></th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 12 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Designer\FeedbackAll.cshtml"
     foreach (var item in Model.Feedbacks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Designer\FeedbackAll.cshtml"
           Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 512, "\"", 555, 2);
            WriteAttributeValue("", 519, "/Designer/FeedbackCreate?Id=", 519, 28, true);
#nullable restore
#line 16 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Designer\FeedbackAll.cshtml"
WriteAttributeValue("", 547, item.Id, 547, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-edit\" title=\"Edit\"></span></a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 645, "\"", 685, 2);
            WriteAttributeValue("", 652, "/Designer/FeedbackDelete/", 652, 25, true);
#nullable restore
#line 17 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Designer\FeedbackAll.cshtml"
WriteAttributeValue("", 677, item.Id, 677, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-trash\" style=\"color:red\" title=\"Delete\"></span></a></td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Designer\FeedbackAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.WebApplication.ViewModels.FeedbackMainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
