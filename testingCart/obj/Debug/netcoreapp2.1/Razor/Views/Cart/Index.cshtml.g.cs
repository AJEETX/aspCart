#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94a498716bc93b40af9983f12f598c8d51683e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94a498716bc93b40af9983f12f598c8d51683e1", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f36e0faaa247e5973a69634d2ee70ba678324f94", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CartItemModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/system/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-item-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cartForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
            BeginContext(75, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 7 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
     if (Model != null && Model.Count() > 0)
    {

#line default
#line hidden
            BeginContext(155, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(163, 4153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bf81e88e70d44e78c3f6c53863bfefb", async() => {
                BeginContext(237, 364, true);
                WriteLiteral(@"
            <table class=""table"">
                <thead>
                    <tr>
                        <td></td>
                        <td>Name</td>
                        <td>Quantity</td>
                        <td>Price</td>
                        <td>Remove</td>
                    </tr>
                </thead>
                <tbody>
");
                EndContext();
#line 21 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                      
                        decimal totalPrice = 0.0m;
                    

#line default
#line hidden
                BeginContext(700, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 24 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                     foreach (var cartItem in Model)
                    {
                        totalPrice += (cartItem.Price * cartItem.Quantity);

#line default
#line hidden
                BeginContext(854, 145, true);
                WriteLiteral("                        <tr>\r\n                            <td style=\"width: 15%\">\r\n                                <div class=\"text-sm-center\">\r\n");
                EndContext();
#line 30 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                     if (cartItem.MainImage != null)
                                    {

#line default
#line hidden
                BeginContext(1108, 44, true);
                WriteLiteral("                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1152, "\"", 1177, 1);
#line 32 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1158, cartItem.MainImage, 1158, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1178, 24, true);
                WriteLiteral(" class=\"cart-item-image\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 1202, "\"", 1222, 1);
#line 32 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1208, cartItem.Name, 1208, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1223, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 33 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(1348, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1388, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b2b5a12632c47bf9cae64a60b04e9d4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 36 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1457, cartItem.Name, 1457, 14, false);

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
                BeginContext(1475, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
                BeginContext(1516, 162, true);
                WriteLiteral("                                </div>\r\n                            </td>\r\n                            <td style=\"width: 40%\">\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1678, "\"", 1710, 2);
                WriteAttributeValue("", 1685, "/Product/", 1685, 9, true);
#line 41 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1694, cartItem.SeoUrl, 1694, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1711, 19, true);
                WriteLiteral(" class=\"text-muted\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 1730, "\"", 1752, 1);
#line 41 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1738, cartItem.Name, 1738, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1753, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1755, 13, false);
#line 41 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                                                                                         Write(cartItem.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1768, 157, true);
                WriteLiteral("</a>\r\n                            </td>\r\n                            <td style=\"width: 17%\">\r\n                                <input type=\"hidden\" name=\"ids\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1925, "\"", 1945, 1);
#line 44 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1933, cartItem.Id, 1933, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1946, 55, true);
                WriteLiteral(" />\r\n                                <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", "\r\n                                       name=\"", 2001, "\"", 2069, 2);
                WriteAttributeValue("", 2048, "quantity-", 2048, 9, true);
#line 46 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2057, cartItem.Id, 2057, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2070, 280, true);
                WriteLiteral(@"
                                       class=""form-control cart-quantity-input""
                                       data-val=""true""
                                       data-val-required=""Quantity is required.""
                                       data-val-range=""0 - ");
                EndContext();
                BeginContext(2351, 24, false);
#line 50 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                                      Write(cartItem.MaxCartQuantity);

#line default
#line hidden
                EndContext();
                BeginContext(2375, 155, true);
                WriteLiteral(" are allowed for this product.\"\r\n                                       data-val-range-min=\"0\"\r\n                                       data-val-range-max=\"");
                EndContext();
                BeginContext(2531, 24, false);
#line 52 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                                      Write(cartItem.MaxCartQuantity);

#line default
#line hidden
                EndContext();
                BeginContext(2555, 1, true);
                WriteLiteral("\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                       value=\"", 2556, "\"", 2622, 1);
#line 53 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2604, cartItem.Quantity, 2604, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2623, 112, true);
                WriteLiteral(" />\r\n                                <span class=\"field-validation-valid text-danger\" data-valmsg-for=\"quantity-");
                EndContext();
                BeginContext(2736, 11, false);
#line 54 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                                                                                      Write(cartItem.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2747, 127, true);
                WriteLiteral("\" data-valmsg-replace=\"true\"></span>\r\n                            </td>\r\n                            <td style=\"width: 18%;\">\r\n");
                EndContext();
#line 57 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                 if(cartItem.OldPrice > 0)
                                { 

#line default
#line hidden
                BeginContext(2970, 63, true);
                WriteLiteral("                                    <strike class=\"text-muted\">");
                EndContext();
                BeginContext(3034, 32, false);
#line 59 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                                          Write(cartItem.OldPrice.ToString("C2"));

#line default
#line hidden
                EndContext();
                BeginContext(3066, 15, true);
                WriteLiteral(" ea.</strike>\r\n");
                EndContext();
#line 60 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(3116, 46, true);
                WriteLiteral("                                <div class=\"\">");
                EndContext();
                BeginContext(3163, 29, false);
#line 61 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                         Write(cartItem.Price.ToString("C2"));

#line default
#line hidden
                EndContext();
                BeginContext(3192, 288, true);
                WriteLiteral(@" ea.</div>
                            </td>
                            <td style=""width: 10%"">
                                <button type=""button"" class=""btn btn-danger remove""><i class=""fa fa-close""></i></button>
                            </td>
                        </tr>
");
                EndContext();
#line 67 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3503, 298, true);
                WriteLiteral(@"                    <tr>
                        <td></td>
                        <td></td>
                        <td style=""width: 15%"" class=""text-sm-right"">
                            <div></div>Total Price:
                        </td>
                        <td style=""width: 15%"">");
                EndContext();
                BeginContext(3802, 25, false);
#line 74 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
                                          Write(totalPrice.ToString("C2"));

#line default
#line hidden
                EndContext();
                BeginContext(3827, 283, true);
                WriteLiteral(@"</td>
                        <td style=""width: 10%""></td>
                    </tr>
                    <tr>
                        <td colspan=""5"">
                            <button type=""button"" id=""save"" class=""btn btn-success"">Save</button>
                            ");
                EndContext();
                BeginContext(4110, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c2295e068924c8da9ae0b5e6d3d79ac", async() => {
                    BeginContext(4181, 8, true);
                    WriteLiteral("Checkout");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4193, 116, true);
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(4342, 33, true);
            WriteLiteral("        <h5>Cart is empty.</h5>\r\n");
            EndContext();
#line 90 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4382, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4406, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 93 "D:\AJEET\github.com\aspCart\testingCart\Views\Cart\Index.cshtml"
           await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
                BeginContext(4482, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            BeginContext(4489, 675, true);
            WriteLiteral(@"
    <script>
        $(function () {
            $('#save').on('click', function (e) {
                e.preventDefault();

                var result = $('#cartForm').valid();

                if (result != 0) {
                    $('input.cart-quantity-input').each(function () {
                        var input = $(this);
                        input.attr('name', ""quantity"");
                    });

                    $('#cartForm').submit();
                }
            });

            $('.remove').on('click', function () {
                var tr = $(this).parent().parent().remove();
            });
        });
    </script>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CartItemModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
