#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d21e15ad890d9ead29ea8c39d496e4d1087006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/List.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d21e15ad890d9ead29ea8c39d496e4d1087006", @"/Areas/Admin/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30db6ebfca434413066c8b8aaf7608de0e4b14d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary input-stack-margin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/system/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-img-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("listForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
  
    ViewData["Title"] = ViewData["ContentHeader"] = "Product List";

#line default
#line hidden
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("menu", async() => {
                BeginContext(131, 307, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            var menuItem = $('#menu-catalog');
            menuItem.addClass('active');
            var subMenuItem = menuItem.find('#menu-catalog-product').parent();
            subMenuItem.addClass('active');
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(441, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("actionHeader", async() => {
                BeginContext(466, 41, true);
                WriteLiteral("\r\n    <div class=\"input-group\">\r\n        ");
                EndContext();
                BeginContext(507, 142, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c776107ee9c4219b2bc4e5e7421f610", async() => {
                    BeginContext(598, 47, true);
                    WriteLiteral("<i class=\"fa fa-plus-square\"></i>&nbsp; Add new");
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
                BeginContext(649, 162, true);
                WriteLiteral("\r\n        <button type=\"button\" id=\"delete\" class=\"btn btn-danger input-stack-margin\"><i class=\"fa fa-trash-o\"></i>&nbsp; Delete (selected)</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(814, 141, true);
            WriteLiteral("\r\n<div class=\"box box-primary\">\r\n    <div class=\"box-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                ");
            EndContext();
            BeginContext(955, 3092, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f83f9905c3d4818bff6f4e3532e55e6", async() => {
                BeginContext(1034, 547, true);
                WriteLiteral(@"
                    <table id=""dataTbl"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th></th>
                                <th>Image</th>
                                <th>Name</th>
                                <th>Stock Qty.</th>
                                <th>Published</th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 41 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                             foreach (var product in Model)
                            {

#line default
#line hidden
                BeginContext(1673, 142, true);
                WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1815, "\"", 1831, 1);
#line 45 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
WriteAttributeValue("", 1820, product.Id, 1820, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1832, 11, true);
                WriteLiteral(" name=\"ids\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1843, "\"", 1862, 1);
#line 45 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
WriteAttributeValue("", 1851, product.Id, 1851, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1863, 90, true);
                WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n");
                EndContext();
#line 48 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                         if (product.MainImage != null)
                                        {

#line default
#line hidden
                BeginContext(2069, 48, true);
                WriteLiteral("                                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2117, "\"", 2141, 1);
#line 50 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
WriteAttributeValue("", 2123, product.MainImage, 2123, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2142, 28, true);
                WriteLiteral(" class=\"product-img-sm\" />\r\n");
                EndContext();
#line 51 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(2302, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(2346, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1479a8438b5040ddb238f73fcc74a0fb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2411, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 55 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2456, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2584, 12, false);
#line 59 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                   Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2596, 127, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2724, 21, false);
#line 62 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                   Write(product.StockQuantity);

#line default
#line hidden
                EndContext();
                BeginContext(2745, 87, true);
                WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
                EndContext();
#line 65 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                         if (product.Published)
                                        {

#line default
#line hidden
                BeginContext(2940, 102, true);
                WriteLiteral("                                            <i class=\"fa fa-check true-icon\" aria-hidden=\"true\"></i>\r\n");
                EndContext();
#line 68 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
                BeginContext(3174, 103, true);
                WriteLiteral("                                            <i class=\"fa fa-close false-icon\" aria-hidden=\"true\"></i>\r\n");
                EndContext();
#line 72 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                        }

#line default
#line hidden
                BeginContext(3320, 196, true);
                WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <div class=\"input-group\">\r\n                                            ");
                EndContext();
                BeginContext(3516, 281, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4083bcf9e6e046f593490f152a874614", async() => {
                    BeginContext(3649, 144, true);
                    WriteLiteral("\r\n                                                <i class=\"fa fa-pencil-square-o\">&nbsp; Edit</i>\r\n                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 76 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                                                                                            WriteLiteral(product.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 76 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
AddHtmlAttributeValue("", 3593, product.Id, 3593, 11, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3797, 132, true);
                WriteLiteral("\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 82 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Product\List.cshtml"
                            }

#line default
#line hidden
                BeginContext(3960, 80, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4047, 139, true);
            WriteLiteral("\r\n            </div> <!-- col md 12 end -->\r\n        </div> <!-- row end -->\r\n    </div> <!-- box body end -->\r\n</div> <!-- box end -->\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4204, 2896, true);
                WriteLiteral(@"
    <script>
        // onready
        $(function () {
            initializeDataTable();
            initializeICheck();
        });

        // delete
        $('#delete').on('click', function (event) {
            var ids = [];
            var form = $('#listForm');
            var checkboxArray = document.getElementsByName('ids');

            // check if checkbox is checked
            for (var i = 0; i < checkboxArray.length; i++) {
                if (checkboxArray[i].checked)
                    ids.push(checkboxArray[i].value);
            }

            // submit form
            if (ids.length > 0) {
                if (confirm(""Are you sure you want to delete this item(s)?"")) {
                    form.submit();
                }
            }
        });

        // datatable highlight selected
        $('#dataTbl tbody').on('click', 'tr', function (event) {
            var nodeName = event.target.nodeName;

            if (nodeName != ""BUTTON"" &&
              ");
                WriteLiteral(@"  nodeName != ""A"" &&
                nodeName != ""IMG"" &&
                nodeName != ""I"") {
                $(this).toggleClass('selected');
                var id = $(this).closest('tr').find('input').attr('id');
                $('#' + id).iCheck('toggle');
            }
        });

        // icheck highlight selected
        $('input').on('ifChecked', function (event) {
            var row = $(this).closest('tr');
            if (!row.hasClass('selected'))
                row.toggleClass('selected');
        });

        $('input').on('ifUnchecked', function (event) {
            var row = $(this).closest('tr');
            if (row.hasClass('selected'))
                row.toggleClass('selected');
        });

        // initialize DataTable
        function initializeDataTable() {
            $('#dataTbl').DataTable({
                paging: true,
                lengthChange: false,
                searching: false,
                ordering: true,
                info: tru");
                WriteLiteral(@"e,
                autoWidth: false,
                order: [2, 'asc'],
                columnDefs: [
                    { ""width"": ""5%"", ""targets"": 0, ""orderable"": false },
                    { ""targets"": 1, ""orderable"": false },
                    { ""targets"": 2, ""orderable"": true },
                    { ""targets"": 3, ""orderable"": true },
                    { ""targets"": 4, ""orderable"": false },
                    { ""targets"": 5, ""orderable"": false }
                ]
            });
        };

        // initialize ICheck
        function initializeICheck() {
            // iCheck
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        };
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
