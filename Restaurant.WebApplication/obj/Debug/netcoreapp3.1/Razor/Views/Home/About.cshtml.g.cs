#pragma checksum "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3562f685c350b13369d58dd8fcb622083c9cf811"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3562f685c350b13369d58dd8fcb622083c9cf811", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed570ba15310d270426eaea5012f46e0041cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.WebApplication.ViewModels.DesignerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- End header-->
<div class=""ogami-breadcrumb"">
    <div class=""container"">
        <ul>
            <li> <a class=""breadcrumb-link"" href=""index.html""> <i class=""fas fa-home""></i>Главная</a></li>
            <li> <a class=""breadcrumb-link active"" href=""#"">О нас</a></li>
        </ul>
    </div>
</div>
<!-- End breadcrumb-->
");
#nullable restore
#line 12 "C:\Projects\Restaurant\Restaurant.WebApplication\Views\Home\About.cshtml"
Write(Html.Raw(Model.AboutUsContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- End about us-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.WebApplication.ViewModels.DesignerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
