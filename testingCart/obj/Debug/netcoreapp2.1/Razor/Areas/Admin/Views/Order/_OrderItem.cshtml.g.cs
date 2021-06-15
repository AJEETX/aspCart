#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7a28479ad98e7eae3ab25ceb2d18672bee6d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order__OrderItem), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/_OrderItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Order/_OrderItem.cshtml", typeof(AspNetCore.Areas_Admin_Views_Order__OrderItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7a28479ad98e7eae3ab25ceb2d18672bee6d00", @"/Areas/Admin/Views/Order/_OrderItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30db6ebfca434413066c8b8aaf7608de0e4b14d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order__OrderItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderManageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 330, true);
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <td style=""border-top: none;"">Name</td>
            <td style=""border-top: none;"">Price</td>
            <td style=""border-top: none;"">Quantity</td>
            <td style=""border-top: none;"">Sub total</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 13 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
          
            decimal totalPrice = 0.0m;
        

#line default
#line hidden
            BeginContext(418, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 16 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
         foreach (var item in Model.OrderItems)
        {
            totalPrice += (item.Price * item.Quantity);

#line default
#line hidden
            BeginContext(535, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(574, 9, false);
#line 20 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(583, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(611, 25, false);
#line 21 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
               Write(item.Price.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(636, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(664, 13, false);
#line 22 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
               Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(677, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(706, 43, false);
#line 23 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
                Write((item.Price * item.Quantity).ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(750, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
        }

#line default
#line hidden
            BeginContext(787, 173, true);
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td class=\"text-right\">\r\n                <div>Total Price:</div>\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(961, 25, false);
#line 32 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\_OrderItem.cshtml"
           Write(totalPrice.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(986, 46, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderManageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
