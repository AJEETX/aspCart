#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7af1139f9bf11c6f721e3e851ab23793eeb4b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactUsMessage_Message), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUsMessage/Message.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ContactUsMessage/Message.cshtml", typeof(AspNetCore.Areas_Admin_Views_ContactUsMessage_Message))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7af1139f9bf11c6f721e3e851ab23793eeb4b5", @"/Areas/Admin/Views/ContactUsMessage/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30db6ebfca434413066c8b8aaf7608de0e4b14d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ContactUsMessage_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactUsMessageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ContactUsMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reply-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
  
    ViewData["Title"] = ViewData["ContentHeader"] = "Read message";

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("menu", async() => {
                BeginContext(123, 309, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            var menuItem = $('#menu-support');
            menuItem.addClass('active');
            var subMenuItem = menuItem.find('#menu-support-contactus').parent();
            subMenuItem.addClass('active');
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(435, 210, true);
            WriteLiteral("\r\n<div class=\"box box-primary\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"box-body no-padding\">\r\n                <div class=\"box-header with-border\">\r\n                    ");
            EndContext();
            BeginContext(645, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5d9738ae7f141158a6a6bbcff952b17", async() => {
                BeginContext(741, 127, true);
                WriteLiteral("\r\n                        <i class=\"fa fa-level-up\" style=\"transform: rotate(-90deg);\"></i> back to inbox\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(872, 200, true);
            WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-danger\" id=\"delete-message\">\r\n                        <i class=\"fa fa-trash\"></i> Delete\r\n                    </button>\r\n                    ");
            EndContext();
            BeginContext(1072, 200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19790ff7ea76469d9c5afd4233b0d1a6", async() => {
                BeginContext(1165, 57, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"ids\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1222, "\"", 1239, 1);
#line 29 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
WriteAttributeValue("", 1230, Model.Id, 1230, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1240, 25, true);
                WriteLiteral(" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1272, 99, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"mailbox-read-info\">\r\n                    <h3>");
            EndContext();
            BeginContext(1372, 11, false);
#line 33 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
                   Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1383, 63, true);
            WriteLiteral("</h3>\r\n                    <h5>\r\n                        From: ");
            EndContext();
            BeginContext(1447, 11, false);
#line 35 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
                         Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 69, true);
            WriteLiteral("\r\n                        <span class=\"mailbox-read-time pull-right\">");
            EndContext();
            BeginContext(1528, 14, false);
#line 36 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
                                                              Write(Model.SendDate);

#line default
#line hidden
            EndContext();
            BeginContext(1542, 132, true);
            WriteLiteral("</span>\r\n                    </h5>\r\n                </div>\r\n                <div class=\"mailbox-read-message\">\r\n                    ");
            EndContext();
            BeginContext(1675, 13, false);
#line 40 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
               Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 66, true);
            WriteLiteral("\r\n                </div>\r\n                <hr />\r\n                ");
            EndContext();
            BeginContext(1754, 477, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f6df640545f4d5d81bbf601b025cbd4", async() => {
                BeginContext(1845, 52, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"To\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1897, "\"", 1917, 1);
#line 44 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
WriteAttributeValue("", 1905, Model.Email, 1905, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1918, 60, true);
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"Subject\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1978, "\"", 1998, 1);
#line 45 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
WriteAttributeValue("", 1986, Model.Title, 1986, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1999, 225, true);
                WriteLiteral(" />\r\n                    <div class=\"reply-content\">\r\n                        <div class=\"text-muted\">click <span id=\"show-reply\" class=\"clickable-text\">here</span> to reply</div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2231, 833, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        $('#reply-form').on('click', '#sendReply', function () {
            let txtArea = $('#replyMessage');
            let msgLength = txtArea.val().length;

            if(msgLength === 0) {
                if (confirm('Send this message without text in the body?')) {
                    $('#reply-form').submit();
                } else {
                    return;
                }
            } else {
                $('#reply-form').submit();
            }
        });

        $('#reply-form').on('click', '#show-reply', function () {
            let container = $(this).parent().parent();
            container.empty();

            let template = `
                <div>
                    <h5>Reply to: ");
            EndContext();
            BeginContext(3065, 11, false);
#line 78 "D:\AJEET\github.com\aspCart\testingCart\Areas\Admin\Views\ContactUsMessage\Message.cshtml"
                             Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3076, 828, true);
            WriteLiteral(@"</h5>
                    <textarea id=""replyMessage"" name=""Reply"" style=""width: 100%;"" rows=""7""></textarea>
                    <button type=""button"" id=""sendReply"" class =""btn btn-primary"">Send</button>
                    <button type=""button"" id=""cancelReply"" class =""btn btn-danger"">Cancel</button>
                </div>`;

            container.append(template);
        });

        $('#reply-form').on('click', '#cancelReply', function () {
            let container = $(this).parent().parent();
            container.empty();
            container.append('<div class=""text-muted"">click <span id=""show-reply"" class=""clickable-text"">here</span> to reply</div>');
        });

        $('#delete-message').on('click', function () {
            $('#deleteForm').submit();
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactUsMessageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
