#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e4c20298cf167cbdbbe94aaff10a8a72a0cc2fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_OrderHistoryList), @"mvc.1.0.view", @"/Views/Manage/OrderHistoryList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/OrderHistoryList.cshtml", typeof(AspNetCore.Views_Manage_OrderHistoryList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4c20298cf167cbdbbe94aaff10a8a72a0cc2fb", @"/Views/Manage/OrderHistoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f36e0faaa247e5973a69634d2ee70ba678324f94", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_OrderHistoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrderModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fa fa-arrow-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
  
    ViewData["Title"] = "Order History List";

#line default
#line hidden
            BeginContext(86, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 7 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
            BeginContext(149, 33, true);
            WriteLiteral("        <h5>Order history <small>");
            EndContext();
            BeginContext(182, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08d8f7b907b84cb599f6b40040db2a71", async() => {
                BeginContext(260, 5, true);
                WriteLiteral(" back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(269, 132, true);
            WriteLiteral("</small></h5>\r\n        <hr />\r\n        <div class=\"card card order-history\">\r\n            <ul class=\"list-group list-group-flush\">\r\n");
            EndContext();
#line 13 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
            BeginContext(467, 86, true);
            WriteLiteral("                    <li class=\"list-group-item\">\r\n                        Order ID: # ");
            EndContext();
            BeginContext(553, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2da717a6a2be4a82afb54223ab9d8c8c", async() => {
                BeginContext(641, 17, false);
#line 16 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                                                                                                                      Write(order.OrderNumber);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                                                                                           WriteLiteral(order.OrderNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(662, 46, true);
            WriteLiteral("\r\n                        &nbsp;&nbsp;&nbsp;\r\n");
            EndContext();
#line 18 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                         if (order.Status.ToString() == "Pending")
                        {

#line default
#line hidden
            BeginContext(803, 69, true);
            WriteLiteral("                            <small><span class=\"alert alert-warning\">");
            EndContext();
            BeginContext(873, 12, false);
#line 20 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                                                                Write(order.Status);

#line default
#line hidden
            EndContext();
            BeginContext(885, 17, true);
            WriteLiteral("</span></small>\r\n");
            EndContext();
#line 21 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                        }
                        else if (order.Status.ToString() == "Processing")
                        {

#line default
#line hidden
            BeginContext(1031, 66, true);
            WriteLiteral("                            <small><span class=\"alert alert-info\">");
            EndContext();
            BeginContext(1098, 12, false);
#line 24 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                                                             Write(order.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1110, 17, true);
            WriteLiteral("</span></small>\r\n");
            EndContext();
#line 25 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                        }
                        else if (order.Status.ToString() == "Complete")
                        {

#line default
#line hidden
            BeginContext(1254, 69, true);
            WriteLiteral("                            <small><span class=\"alert alert-success\">");
            EndContext();
            BeginContext(1324, 12, false);
#line 28 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                                                                Write(order.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 17, true);
            WriteLiteral("</span></small>\r\n");
            EndContext();
#line 29 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                        }
                        else if (order.Status.ToString() == "Cancelled")
                        {

#line default
#line hidden
            BeginContext(1481, 68, true);
            WriteLiteral("                            <small><span class=\"alert alert-danger\">");
            EndContext();
            BeginContext(1550, 12, false);
#line 32 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                                                               Write(order.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 17, true);
            WriteLiteral("</span></small>\r\n");
            EndContext();
#line 33 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                        }

#line default
#line hidden
            BeginContext(1606, 27, true);
            WriteLiteral("                    </li>\r\n");
            EndContext();
#line 35 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
                }

#line default
#line hidden
            BeginContext(1652, 35, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n");
            EndContext();
#line 38 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1711, 36, true);
            WriteLiteral("        <h5>History is empty.</h5>\r\n");
            EndContext();
#line 42 "D:\AJEET\github.com\aspCart\testingCart\Views\Manage\OrderHistoryList.cshtml"
    }

#line default
#line hidden
            BeginContext(1754, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrderModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
