#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49551e30a6aab6ff2da6b39958bd2ef7519c783a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Manage), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Manage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Order/Manage.cshtml", typeof(AspNetCore.Areas_Admin_Views_Order_Manage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49551e30a6aab6ff2da6b39958bd2ef7519c783a", @"/Areas/Admin/Views/Order/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30db6ebfca434413066c8b8aaf7608de0e4b14d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderManageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fa fa-arrow-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("orderForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\Manage.cshtml"
  
    ViewData["Title"] = ViewData["ContentHeader"] = "Manage order";

#line default
#line hidden
            BeginContext(101, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("menu", async() => {
                BeginContext(118, 300, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            var menuItem = $('#menu-sale');
            menuItem.addClass('active');
            var subMenuItem = menuItem.find('#menu-sale-orders').parent();
            subMenuItem.addClass('active');
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(421, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("headerLeftOptional", async() => {
                BeginContext(452, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(458, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1318a59582ef4cf7999e2e81d085e4cc", async() => {
                    BeginContext(511, 13, true);
                    WriteLiteral(" back to list");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(528, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(533, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("actionHeader", async() => {
                BeginContext(558, 332, true);
                WriteLiteral(@"
    <div class=""input-group"">
        <button type=""button"" class=""btn btn-primary input-stack-margin"" id=""save""><i class=""fa fa-save""></i>&nbsp; Save</button>
        <button type=""button"" class=""btn btn-primary input-stack-margin"" id=""continue""><i class=""fa fa-save""></i>&nbsp; Save and continue editing</button>
    </div>
");
                EndContext();
            }
            );
            BeginContext(893, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(895, 1275, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bae323a8884cff9443d77c85e3383c", async() => {
                BeginContext(973, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(979, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c29286d53ce2441b88f42ae75c992872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 29 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\Manage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ActiveTab);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1022, 746, true);
                WriteLiteral(@"
    <input type=""hidden"" id=""continueEditing"" name=""continueEditing"" value=""false"" />

    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""nav-tabs-custom"">
                <!-- Nav tabs -->
                <ul class=""nav nav-tabs"" role=""tablist"">
                    <li role=""presentation""><a href=""#infoContent"" class=""tabNav"" id=""info"" data-toggle=""tab"">Order Info</a></li>
                    <li role=""presentation""><a href=""#itemContent"" class=""tabNav"" id=""item"" data-toggle=""tab"">Item/s</a></li>
                </ul>

                <!-- Tab panes -->
                <div class=""tab-content"">
                    <div role=""tabpanel"" class=""tab-pane"" id=""infoContent"">
                        ");
                EndContext();
                BeginContext(1769, 44, false);
#line 44 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\Manage.cshtml"
                   Write(await Html.PartialAsync("_OrderInfo", Model));

#line default
#line hidden
                EndContext();
                BeginContext(1813, 131, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane\" id=\"itemContent\">\r\n                        ");
                EndContext();
                BeginContext(1945, 44, false);
#line 47 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\Manage.cshtml"
                   Write(await Html.PartialAsync("_OrderItem", Model));

#line default
#line hidden
                EndContext();
                BeginContext(1989, 174, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div> <!-- nav tabs custom end --> \r\n        </div> <!-- end col md 12 -->\r\n    </div> <!-- end row -->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2170, 870, true);
            WriteLiteral(@"


<script>
    // run validator on all tabs
    $.validator.setDefaults({
        ignore: []
    });

    // onready
    $(function () {
        initializeNav();
        $('#OrderStatus').kendoDropDownList();
    });

    // set hidden value of nav and content
    $('a[data-toggle=""tab""]').on('shown.bs.tab', function (e) {
        $('#ActiveTab').val(e.target.getAttribute('id'));
    })

    // submit form
    $('#save').on('click', function (e) {
        e.preventDefault();
        $('#continueEditing').val(false);
        $('#orderForm').submit();
    });

    // form save and continue editing
    $('#continue').on('click', function (e) {
        e.preventDefault();
        $('#continueEditing').val(true);
        $('#orderForm').submit();
    });

    // set active nav
    function initializeNav() {
        $('.tabNav#");
            EndContext();
            BeginContext(3041, 15, false);
#line 90 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\Manage.cshtml"
              Write(Model.ActiveTab);

#line default
#line hidden
            EndContext();
            BeginContext(3056, 54, true);
            WriteLiteral("\').parent().addClass(\'active\');\r\n        $(\'.tab-pane#");
            EndContext();
            BeginContext(3112, 27, false);
#line 91 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Order\Manage.cshtml"
                 Write(Model.ActiveTab + "Content");

#line default
#line hidden
            EndContext();
            BeginContext(3140, 43, true);
            WriteLiteral("\').addClass(\'active\');\r\n    };\r\n</script>\r\n");
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
