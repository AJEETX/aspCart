#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8501539ba60a0a92a1cdb0326e897099aa524bed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Footer), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Footer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_Footer.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__Footer))]
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
#line 1 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Web;

#line default
#line hidden
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Web.Models;

#line default
#line hidden
#line 3 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Web.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Web.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#line 6 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Web.Areas.Admin.Models.Sale;

#line default
#line hidden
#line 7 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Web.Areas.Admin.Models.Support;

#line default
#line hidden
#line 8 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using aspCart.Infrastructure.EFModels;

#line default
#line hidden
#line 9 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8501539ba60a0a92a1cdb0326e897099aa524bed", @"/Areas/Admin/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30db6ebfca434413066c8b8aaf7608de0e4b14d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 272, true);
            WriteLiteral(@"<footer class=""main-footer"">
    <!-- To the right -->
    <div class=""pull-right hidden-xs"">
        Template by <a href=""https://almsaeedstudio.com/"" target=""_blank"">Almsaeed Studio</a>
    </div>
    <!-- Default to the left -->
    <strong>Copyright &copy; 2017 ");
            EndContext();
            BeginContext(272, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47d0c83b8e8745b58f76ff2125f4e752", async() => {
                BeginContext(321, 7, true);
                WriteLiteral("aspCart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(332, 22, true);
            WriteLiteral("</strong>\r\n</footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
