#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718445849aa8f939c64effd1ef5f46f6fc3958a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Category/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Category_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"718445849aa8f939c64effd1ef5f46f6fc3958a1", @"/Areas/Admin/Views/Category/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30db6ebfca434413066c8b8aaf7608de0e4b14d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryCreateOrUpdateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fa fa-arrow-circle-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("aspValidation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("categoryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml"
  
    ViewData["Title"] = ViewData["ContentHeader"] = "Edit category";

#line default
#line hidden
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("menu", async() => {
                BeginContext(130, 308, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            var menuItem = $('#menu-catalog');
            menuItem.addClass('active');
            var subMenuItem = menuItem.find('#menu-catalog-category').parent();
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
            DefineSection("headerLeftOptional", async() => {
                BeginContext(472, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(478, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65492e74667140f0ad7dd5d9b3627851", async() => {
                    BeginContext(531, 13, true);
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
                BeginContext(548, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(553, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("actionHeader", async() => {
                BeginContext(578, 332, true);
                WriteLiteral(@"
    <div class=""input-group"">
        <button type=""button"" class=""btn btn-primary input-stack-margin"" id=""save""><i class=""fa fa-save""></i>&nbsp; Save</button>
        <button type=""button"" class=""btn btn-primary input-stack-margin"" id=""continue""><i class=""fa fa-save""></i>&nbsp; Save and continue editing</button>
    </div>
");
                EndContext();
            }
            );
            BeginContext(913, 60, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            EndContext();
            BeginContext(973, 1335, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c794e403784e66ba98e4b32a6348a5", async() => {
                BeginContext(1055, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1069, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e117173e1ef648648fa4eb447ff0c3e4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 32 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml"
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
                BeginContext(1112, 152, true);
                WriteLiteral("\r\n            <input type=\"hidden\" id=\"continueEditing\" name=\"continueEditing\" value=\"false\" />\r\n\r\n            <div id=\"validation\"></div>\r\n            ");
                EndContext();
                BeginContext(1264, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4742cee93040aaba261cb7fdb54629", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 36 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                BeginContext(1349, 600, true);
                WriteLiteral(@"

            <div class=""nav-tabs-custom"">
                <!-- Nav tabs -->
                <ul class=""nav nav-tabs"" role=""tablist"">
                    <li role=""presentation""><a href=""#infoContent"" class=""tabNav"" id=""info"" data-toggle=""tab"">General Info</a></li>
                    <li role=""presentation""><a href=""#seoContent"" class=""tabNav"" id=""seo"" data-toggle=""tab"">SEO</a></li>
                </ul>

                <!-- Tab panes -->
                <div class=""tab-content"">
                    <div role=""tabpanel"" class=""tab-pane"" id=""infoContent"">
                        ");
                EndContext();
                BeginContext(1950, 54, false);
#line 48 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml"
                   Write(await Html.PartialAsync("_CreateOrUpdate_Info", Model));

#line default
#line hidden
                EndContext();
                BeginContext(2004, 130, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div role=\"tabpanel\" class=\"tab-pane\" id=\"seoContent\">\r\n                        ");
                EndContext();
                BeginContext(2135, 53, false);
#line 51 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml"
                   Write(await Html.PartialAsync("_CreateOrUpdate_Seo", Model));

#line default
#line hidden
                EndContext();
                BeginContext(2188, 113, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div> <!-- nav tabs custom end -->\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
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
            BeginContext(2308, 64, true);
            WriteLiteral("\r\n    </div> <!-- col md 12 end -->\r\n</div> <!-- row end -->\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2390, 1782, true);
                WriteLiteral(@"
    <script>
        // run validator on all tabs
        $.validator.setDefaults({
            ignore: []
        });

        // onready calls
        $(function () {
            initializeNav();
            initializeICheck();
        });

        // set hidden value of nav and content
        $('a[data-toggle=""tab""]').on('shown.bs.tab', function (e) {
            $('#ActiveTab').val(e.target.getAttribute('id'));
        })

        // form save
        $('#save').on('click', function (e) {
            e.preventDefault();

            // check if form is valid
            var result = $('#categoryForm').valid();

            if (result != 0) {
                $('#continueEditing').val(false);
                $('#categoryForm').submit();
            } else {
                $('#validation').empty();
                $('#aspValidation').empty();
                $('#validation').append('<div class=""validation-summary-errors text-danger""><ul><li>Something went wrong! Recheck all ");
                WriteLiteral(@"inputs</li></ul></div>');
            }
        });

        // form save and continue editing
        $('#continue').on('click', function (e) {
            e.preventDefault();

            // check if form is valid
            var result = $('#categoryForm').valid();

            if (result != 0) {
                $('#continueEditing').val(true);
                $('#categoryForm').submit();
            } else {
                $('#validation').empty();
                $('#validation').append('<div class=""validation-summary-errors alert alert-danger""><ul><li>Something went wrong! Recheck all inputs</li></ul></div>');
            }
        });

        // set active nav
        function initializeNav() {
            $('.tabNav#");
                EndContext();
                BeginContext(4173, 15, false);
#line 113 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml"
                  Write(Model.ActiveTab);

#line default
#line hidden
                EndContext();
                BeginContext(4188, 58, true);
                WriteLiteral("\').parent().addClass(\'active\');\r\n            $(\'.tab-pane#");
                EndContext();
                BeginContext(4248, 27, false);
#line 114 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\Category\Edit.cshtml"
                     Write(Model.ActiveTab + "Content");

#line default
#line hidden
                EndContext();
                BeginContext(4276, 364, true);
                WriteLiteral(@"').addClass('active');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryCreateOrUpdateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
