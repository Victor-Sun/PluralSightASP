#pragma checksum "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3242117b06dc82468123b524460a42613413cc0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Shop), @"mvc.1.0.view", @"/Views/App/Shop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Shop.cshtml", typeof(AspNetCore.Views_App_Shop))]
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
#line 1 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#line 2 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#line 3 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3242117b06dc82468123b524460a42613413cc0f", @"/Views/App/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402ff29ed5304f90d7247425045b59e26db665d3", @"/Views/_ViewImports.cshtml")]
    public class Views_App_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(29, 25, true);
            WriteLiteral("<h1>Shop</h1>\r\n<p>Count: ");
            EndContext();
            BeginContext(55, 13, false);
#line 3 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(68, 25, true);
            WriteLiteral("</p>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 5 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
     foreach (var p in Model)
	{

#line default
#line hidden
            BeginContext(125, 76, true);
            WriteLiteral("\t\t<div class=\"col-md-3\">\r\n\t\t\t<div class=\"border bg-light rounded p-1\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(201, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "401174ae653048baa54617d3a4b35691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 211, "~/img/", 211, 6, true);
#line 9 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 217, p.ArtId, 217, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 227, ".jpg", 227, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
AddHtmlAttributeValue("", 256, p.Title, 256, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(267, 10, true);
            WriteLiteral("\r\n\t\t\t\t<h3>");
            EndContext();
            BeginContext(278, 10, false);
#line 10 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
               Write(p.Category);

#line default
#line hidden
            EndContext();
            BeginContext(288, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(292, 6, false);
#line 10 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                             Write(p.Size);

#line default
#line hidden
            EndContext();
            BeginContext(298, 34, true);
            WriteLiteral("</h3>\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li>Price: $");
            EndContext();
            BeginContext(333, 7, false);
#line 12 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                           Write(p.Price);

#line default
#line hidden
            EndContext();
            BeginContext(340, 24, true);
            WriteLiteral("</li>\r\n\t\t\t\t\t<li>Artist: ");
            EndContext();
            BeginContext(365, 8, false);
#line 13 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                           Write(p.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(373, 23, true);
            WriteLiteral("</li>\r\n\t\t\t\t\t<li>Title: ");
            EndContext();
            BeginContext(397, 7, false);
#line 14 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                          Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(404, 29, true);
            WriteLiteral("</li>\r\n\t\t\t\t\t<li>Description: ");
            EndContext();
            BeginContext(434, 16, false);
#line 15 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
                                Write(p.ArtDescription);

#line default
#line hidden
            EndContext();
            BeginContext(450, 104, true);
            WriteLiteral("</li>\r\n\t\t\t\t</ul>\r\n\t\t\t\t<button id=\"buyButton\" class=\"btn btn-success\">Buy</button>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 20 "I:\Projects\PluralSightASP\DutchTreat\DutchTreat\Views\App\Shop.cshtml"
	}

#line default
#line hidden
            BeginContext(558, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
