#pragma checksum "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Home\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09fdd6eb594352a481dd9c381ba72c548865f094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Footer), @"mvc.1.0.view", @"/Views/Home/Footer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09fdd6eb594352a481dd9c381ba72c548865f094", @"/Views/Home/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6ed570ba15310d270426eaea5012f46e0041cbe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.WebApplication.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("payment-method"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/payment.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-sm-12 col-md-6 text-sm-center text-md-left\">\r\n                <div class=\"footer-logo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09fdd6eb594352a481dd9c381ba72c548865f0944810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                <div class=\"footer-contact\">\r\n                    <p>Address: ");
#nullable restore
#line 8 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Home\Footer.cshtml"
                           Write(Model.DesignerModel.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Phone: ");
#nullable restore
#line 9 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Home\Footer.cshtml"
                         Write(Model.DesignerModel.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Email: ");
#nullable restore
#line 10 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Home\Footer.cshtml"
                         Write(Model.DesignerModel.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"footer-social\">\r\n                    <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 641, "\"", 681, 1);
#nullable restore
#line 13 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Home\Footer.cshtml"
WriteAttributeValue("", 648, Model.DesignerModel.FacebookLink, 648, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"> </i></a>\r\n");
            WriteLiteral("                    <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 866, "\"", 907, 1);
#nullable restore
#line 15 "C:\Users\davitha\source\repos\Restaurant\Restaurant.WebApplication\Views\Home\Footer.cshtml"
WriteAttributeValue("", 873, Model.DesignerModel.InstagramLink, 873, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"> </i></a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <div class=\"row\">\r\n");
            WriteLiteral(@"                    <div class=""col-12 col-sm-4 text-sm-center text-md-left"">
                        <div class=""footer-quicklink"">
                            <h5>Разделы</h5>
                            <a href=""/"">Главная</a>
                            <a href=""/Designer"">Панель</a>
                            <a href=""/Blog/Index"">Блог</a>
                            <a href=""/Career/Index"">Карьера</a>
                            <a href=""/Home/Contact"">Контакты</a>
                            <a href=""/Home/About"">О Нас</a>
                        </div>
                    </div>
                    <div class=""col-12 col-sm-4 text-sm-center text-md-left"">
                        <div class=""footer-quicklink"">
                            <h5>Меню</h5>
                            <a href=""#"">СТОЛОВАЯ</a>
                            <a href=""#"">ВЫПЕЧКА</a>
                            <a href=""#"">ОПТОВАЯ ПРОДАЖА</a>
                        </div>
                    </div>
            ");
            WriteLiteral(@"    </div>
            </div>
        </div>
    </div>
    <div class=""footer-credit"">
        <div class=""container"">
            <div class=""footer-creadit_block d-flex flex-column flex-md-row justify-content-start justify-content-md-between align-items-baseline align-items-md-center"">
                <p class=""author"">Copyright © 2020 KAR-FOOD, Developed by <a href=""https://www.facebook.com/novirarm"">Novir</a> All Rights Reserved.</p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09fdd6eb594352a481dd9c381ba72c548865f0949656", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.WebApplication.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
