#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97bb35764556f3674ed9b4b1082ea36582c91092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ProductSpecification), @"mvc.1.0.view", @"/Views/Home/_ProductSpecification.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_ProductSpecification.cshtml", typeof(AspNetCore.Views_Home__ProductSpecification))]
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
#line 1 "D:\AJEET\github.com\aspCart\testingCart\Views\_ViewImports.cshtml"
using aspCart.Web;

#line default
#line hidden
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Views\_ViewImports.cshtml"
using aspCart.Web.Models;

#line default
#line hidden
#line 3 "D:\AJEET\github.com\aspCart\testingCart\Views\_ViewImports.cshtml"
using aspCart.Web.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\AJEET\github.com\aspCart\testingCart\Views\_ViewImports.cshtml"
using aspCart.Web.Models.ContactUsViewModels;

#line default
#line hidden
#line 5 "D:\AJEET\github.com\aspCart\testingCart\Views\_ViewImports.cshtml"
using aspCart.Web.Models.ManageViewModels;

#line default
#line hidden
#line 6 "D:\AJEET\github.com\aspCart\testingCart\Views\_ViewImports.cshtml"
using aspCart.Infrastructure.EFModels;

#line default
#line hidden
#line 7 "D:\AJEET\github.com\aspCart\testingCart\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97bb35764556f3674ed9b4b1082ea36582c91092", @"/Views/Home/_ProductSpecification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f36e0faaa247e5973a69634d2ee70ba678324f94", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ProductSpecification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 56, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"col-md-12\">\r\n");
            EndContext();
#line 5 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml"
         if (Model.Specifications.Count > 0)
        {

#line default
#line hidden
            BeginContext(134, 94, true);
            WriteLiteral("            <table class=\"table table-striped table-specification\">\r\n                <tbody>\r\n");
            EndContext();
#line 9 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml"
                     foreach (var specification in Model.Specifications)
                    {

#line default
#line hidden
            BeginContext(325, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"table-specification-title\">");
            EndContext();
            BeginContext(422, 17, false);
#line 12 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml"
                                                             Write(specification.Key);

#line default
#line hidden
            EndContext();
            BeginContext(439, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(479, 29, false);
#line 13 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml"
                           Write(Html.Raw(specification.Value));

#line default
#line hidden
            EndContext();
            BeginContext(508, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 15 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml"
                    }

#line default
#line hidden
            BeginContext(569, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 18 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(653, 45, true);
            WriteLiteral("            <div>No specification yet</div>\r\n");
            EndContext();
#line 22 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductSpecification.cshtml"
        }

#line default
#line hidden
            BeginContext(709, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
