#pragma checksum "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66cd38197dc2bce989f73aed29e73d9309ef6ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Designer_SlidersAll), @"mvc.1.0.view", @"/Views/Designer/SlidersAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66cd38197dc2bce989f73aed29e73d9309ef6ea", @"/Views/Designer/SlidersAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed570ba15310d270426eaea5012f46e0041cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Designer_SlidersAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.WebApplication.ViewModels.SliderMainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml"
  
    ViewData["Title"] = "Blogs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table id=""listingTable"">
    <tr>
        <th>Title</th>
        <th>Description</th>
        <th>Created on</th>
        <th><a href=""/Designer/CreateSlider""><span class=""glyphicon glyphicon-plus"" title=""Add""></span></a></th>
        <th></th>
    </tr>
");
#nullable restore
#line 14 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml"
     foreach (var item in Model.Sliders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 598, "\"", 639, 2);
            WriteAttributeValue("", 605, "/Designer/CreateSlider?id=", 605, 26, true);
#nullable restore
#line 19 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml"
WriteAttributeValue("", 631, item.Id, 631, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-edit\" title=\"Edit\"></span></a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 729, "\"", 770, 2);
            WriteAttributeValue("", 736, "/Designer/DeleteSlider?id=", 736, 26, true);
#nullable restore
#line 20 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml"
WriteAttributeValue("", 762, item.Id, 762, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"glyphicon glyphicon-trash\" style=\"color:red\" title=\"Delete\"></span></a></td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Designer\SlidersAll.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.WebApplication.ViewModels.SliderMainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
