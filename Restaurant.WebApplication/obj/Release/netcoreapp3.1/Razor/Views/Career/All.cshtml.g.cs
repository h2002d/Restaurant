#pragma checksum "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec4219f865880d308a90476ea248398a9711c1a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Career_All), @"mvc.1.0.view", @"/Views/Career/All.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4219f865880d308a90476ea248398a9711c1a6", @"/Views/Career/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed570ba15310d270426eaea5012f46e0041cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Career_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.WebApplication.ViewModels.CareerMainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml"
  
    ViewData["Title"] = "Careers";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table id=\"listingTable\">\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Created on</th>\r\n        <th><a href=\"/Career/Create\"><span class=\"glyphicon glyphicon-plus\" title=\"Add\"></span></a></th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml"
     foreach (var item in Model.Careers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml"
           Write(item.CreateDate.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 590, "\"", 618, 2);
            WriteAttributeValue("", 597, "/Career/Edit/", 597, 13, true);
#nullable restore
#line 18 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml"
WriteAttributeValue("", 610, item.Id, 610, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-edit\" title=\"Edit\"></span></a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 708, "\"", 738, 2);
            WriteAttributeValue("", 715, "/Career/Delete/", 715, 15, true);
#nullable restore
#line 19 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml"
WriteAttributeValue("", 730, item.Id, 730, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-trash\" style=\"color:red\" title=\"Delete\"></span></a></td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Career\All.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.WebApplication.ViewModels.CareerMainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
