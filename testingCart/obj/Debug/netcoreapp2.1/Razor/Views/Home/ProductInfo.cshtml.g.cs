#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77ec9e551a711c3404d33ed7b2e6d2eb3e0f635f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductInfo), @"mvc.1.0.view", @"/Views/Home/ProductInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ProductInfo.cshtml", typeof(AspNetCore.Views_Home_ProductInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77ec9e551a711c3404d33ed7b2e6d2eb3e0f635f", @"/Views/Home/ProductInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f36e0faaa247e5973a69634d2ee70ba678324f94", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CreateReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
  
    ViewData["Title"] = @Model.MetaTitle ?? Model.Name;
    var description = false;
    var imgIndex = 0;

#line default
#line hidden
            BeginContext(138, 104, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <center>\r\n");
            EndContext();
#line 12 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                   
                    var mainImageSrc = "/images/system/no-image.png";
                    if (Model.MainImage != null)
                    {
                        mainImageSrc = Model.MainImage;
                    }
                

#line default
#line hidden
            BeginContext(506, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 526, "\"", 545, 1);
#line 19 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
WriteAttributeValue("", 532, mainImageSrc, 532, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(546, 59, true);
            WriteLiteral("\r\n                     class=\"product-main-image img-fluid\"");
            EndContext();
            BeginWriteAttribute("alt", "\r\n                     alt=\"", 605, "\"", 644, 1);
#line 21 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
WriteAttributeValue("", 633, Model.Name, 633, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(645, 163, true);
            WriteLiteral("\r\n                     data-toggle=\"modal\"\r\n                     data-target=\"#lightbox-modal\"\r\n                     data-img-index=\"0\" />\r\n            </center>\r\n");
            EndContext();
#line 26 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
             if (Model.ProductImages.Count > 0)
            {

#line default
#line hidden
            BeginContext(872, 104, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-12 product-image-container\">\r\n");
            EndContext();
#line 30 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                         foreach (var img in Model.ProductImages)
                        {

#line default
#line hidden
            BeginContext(1070, 113, true);
            WriteLiteral("                            <div class=\"product-image-thumbnail-container\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1183, "\"", 1193, 1);
#line 33 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
WriteAttributeValue("", 1189, img, 1189, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1194, 251, true);
            WriteLiteral("\r\n                                     class=\"product-image-thumbnail\"\r\n                                     data-toggle=\"modal\"\r\n                                     data-target=\"#lightbox-modal\"\r\n                                     data-img-index=\"");
            EndContext();
            BeginContext(1446, 8, false);
#line 37 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                                                Write(imgIndex);

#line default
#line hidden
            EndContext();
            BeginContext(1454, 42, true);
            WriteLiteral("\" />\r\n                            </div>\r\n");
            EndContext();
#line 39 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"

                            imgIndex++;
                        }

#line default
#line hidden
            BeginContext(1566, 52, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n");
            EndContext();
#line 44 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(1633, 64, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-8\">\r\n            <h4>");
            EndContext();
            BeginContext(1698, 10, false);
#line 47 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1708, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 48 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
             if (Model.Rating > 0)
            {

#line default
#line hidden
            BeginContext(1766, 39, true);
            WriteLiteral("                <span title=\"rating\">\r\n");
            EndContext();
#line 51 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                      
                        int activeStar = 0;
                        int roundedRating = Convert.ToInt32(Math.Round(Model.Rating, 0, MidpointRounding.AwayFromZero));
                    

#line default
#line hidden
            BeginContext(2019, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 55 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                     for (int i = 0; i < roundedRating; i++)
                    {

#line default
#line hidden
            BeginContext(2104, 64, true);
            WriteLiteral("                        <i class=\"fa fa-star star-active\"></i>\r\n");
            EndContext();
#line 58 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                        activeStar++;
                    }

#line default
#line hidden
            BeginContext(2230, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 60 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                     for (int i = 0; i < 5 - activeStar; i++)
                    {

#line default
#line hidden
            BeginContext(2316, 66, true);
            WriteLiteral("                        <i class=\"fa fa-star star-inactive\"></i>\r\n");
            EndContext();
#line 63 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                    }

#line default
#line hidden
            BeginContext(2405, 117, true);
            WriteLiteral("                </span>\r\n                <h6 class=\"text-muted\" style=\"display: inline-block;\">\r\n                    ");
            EndContext();
            BeginContext(2523, 27, false);
#line 66 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
               Write(Model.Rating.ToString("N2"));

#line default
#line hidden
            EndContext();
            BeginContext(2550, 119, true);
            WriteLiteral("\r\n                </h6>\r\n                <span id=\"reviewCount\" class=\"text-muted review-count\" title=\"review counts\">(");
            EndContext();
            BeginContext(2670, 17, false);
#line 68 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                                                                                         Write(Model.ReviewCount);

#line default
#line hidden
            EndContext();
            BeginContext(2687, 33, true);
            WriteLiteral(")</span>\r\n                <small>");
            EndContext();
            BeginContext(2720, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74252826e0ae49e99c39c61753adc649", async() => {
                BeginContext(2776, 14, true);
                WriteLiteral("write a review");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 69 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                                                        WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2794, 10, true);
            WriteLiteral("</small>\r\n");
            EndContext();
#line 70 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
            }            

#line default
#line hidden
            BeginContext(2831, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 71 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
              
                var mLink = new List<string>();
                foreach (var manufacturer in Model.Manufacturers)
                {
                    mLink.Add($"<a href=\"/Manufacturer/{manufacturer.Name}\">{ @manufacturer.Name}</a>");
                }
            

#line default
#line hidden
            BeginContext(3124, 16, true);
            WriteLiteral("            <h6>");
            EndContext();
            BeginContext(3141, 34, false);
#line 78 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
           Write(Html.Raw(string.Join(", ", mLink)));

#line default
#line hidden
            EndContext();
            BeginContext(3175, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 79 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
             if (Model.OldPrice > 0)
            {

#line default
#line hidden
            BeginContext(3235, 69, true);
            WriteLiteral("                <h6>\r\n                    <strike class=\"text-muted\">");
            EndContext();
            BeginContext(3305, 29, false);
#line 82 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                                          Write(Model.OldPrice.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(3334, 10, true);
            WriteLiteral("</strike> ");
            EndContext();
            BeginContext(3345, 36, false);
#line 82 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                                                                                  Write(Html.Raw(Model.Price.ToString("C2")));

#line default
#line hidden
            EndContext();
            BeginContext(3381, 25, true);
            WriteLiteral("\r\n                </h6>\r\n");
            EndContext();
#line 84 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3454, 20, true);
            WriteLiteral("                <h6>");
            EndContext();
            BeginContext(3475, 26, false);
#line 87 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
               Write(Model.Price.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(3501, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 88 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
            }

#line default
#line hidden
            BeginContext(3523, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3535, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc3395fb794743e6873c09c56e2b5bb6", async() => {
                BeginContext(3606, 38, true);
                WriteLiteral("\r\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3644, "\"", 3661, 1);
#line 90 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
WriteAttributeValue("", 3652, Model.Id, 3652, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3662, 133, true);
                WriteLiteral(" name=\"id\" />\r\n                <button type=\"submit\" id=\"addToCart\" class=\"btn btn-primary btn-sm\">Add to cart</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3802, 223, true);
            WriteLiteral("\r\n        </div>\r\n    </div> <!-- row end -->\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <!-- Nav tabs -->\r\n            <ul class=\"nav nav-tabs\" role=\"tablist\" id=\"product-info-tabs\">\r\n");
            EndContext();
#line 100 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                 if ((Model.Description != null && Model.Description.Length > 0) || Model.Specifications.Count == 0)
                {

#line default
#line hidden
            BeginContext(4162, 207, true);
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link active\" id=\"description\" data-toggle=\"tab\" href=\"#descriptionTab\" role=\"tab\">Description</a>\r\n                    </li>\r\n");
            EndContext();
#line 105 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"

                    description = true;
                }

#line default
#line hidden
            BeginContext(4431, 61, true);
            WriteLiteral("                <li class=\"nav-item\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4492, "\"", 4548, 2);
            WriteAttributeValue("", 4500, "nav-link", 4500, 8, true);
#line 109 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
WriteAttributeValue(" ", 4508, description == false ? "active" : "", 4509, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4549, 384, true);
            WriteLiteral(@" id=""specification"" data-toggle=""tab"" href=""#specificationTab"" role=""tab"">Specification</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""reviews"" data-toggle=""tab"" href=""#reviewsTab"" role=""tab"">Reviews</a>
                </li>
            </ul>

            <!-- Tab panes -->
            <div class=""tab-content"">
");
            EndContext();
#line 118 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                 if ((Model.Description != null && Model.Description.Length > 0) || Model.Specifications.Count == 0)
                {

#line default
#line hidden
            BeginContext(5070, 143, true);
            WriteLiteral("                    <div class=\"tab-pane active\" id=\"descriptionTab\" role=\"tabpanel\">\r\n                        <br />\r\n                        ");
            EndContext();
            BeginContext(5214, 53, false);
#line 122 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                   Write(await Html.PartialAsync("_ProductDescription", Model));

#line default
#line hidden
            EndContext();
            BeginContext(5267, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 124 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(5316, 20, true);
            WriteLiteral("                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5336, "\"", 5392, 2);
            WriteAttributeValue("", 5344, "tab-pane", 5344, 8, true);
#line 125 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
WriteAttributeValue(" ", 5352, description == false ? "active" : "", 5353, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5393, 89, true);
            WriteLiteral(" id=\"specificationTab\" role=\"tabpanel\">\r\n                    <br />\r\n                    ");
            EndContext();
            BeginContext(5483, 55, false);
#line 127 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
               Write(await Html.PartialAsync("_ProductSpecification", Model));

#line default
#line hidden
            EndContext();
            BeginContext(5538, 146, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"tab-pane\" id=\"reviewsTab\" role=\"tabpanel\">\r\n                    <br />\r\n                    ");
            EndContext();
            BeginContext(5685, 48, false);
#line 131 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
               Write(await Html.PartialAsync("_ProductReview", Model));

#line default
#line hidden
            EndContext();
            BeginContext(5733, 768, true);
            WriteLiteral(@"
                </div>
            </div>
        </div> 
    </div> <!-- row end -->
</div> <!-- container end -->

<!-- lightbox modal -->
<div class=""modal fade"" id=""lightbox-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"" style=""border-bottom: none;"">
                <h5 class=""modal-title text-muted""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" style=""width: 100%; height: 100%;"">

");
            EndContext();
#line 150 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                 foreach (var img in Model.ProductImages)
                {

#line default
#line hidden
            BeginContext(6579, 24, true);
            WriteLiteral("                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6603, "\"", 6613, 1);
#line 152 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
WriteAttributeValue("", 6609, img, 6609, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6614, 47, true);
            WriteLiteral(" id=\"modal-img-src\" class=\"lightbox-slide\" />\r\n");
            EndContext();
#line 153 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(6680, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 155 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                 if (Model.ProductImages.Count > 1)
                {

#line default
#line hidden
            BeginContext(6754, 122, true);
            WriteLiteral("                    <a class=\"prev text-muted\">&#10094;</a>\r\n                    <a class=\"next text-muted\">&#10095;</a>\r\n");
            EndContext();
#line 159 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\ProductInfo.cshtml"
                }

#line default
#line hidden
            BeginContext(6895, 2281, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
    // lightbox
    $(function () {
        var currentSlide = 0;
        var imgSlides = document.getElementsByClassName('lightbox-slide');

        $('#lightbox-modal').on('show.bs.modal', function (event) {
            let imgIndex = $(event.relatedTarget).data('img-index');

            imgSlides[imgIndex].style.display = 'block';
            currentSlide = imgIndex;
            updateText(currentSlide);
        });

        $('#lightbox-modal').on('hide.bs.modal', function (event) {
            imgSlides[currentSlide].style.display = 'none'; // hide the current image
        });

        $('.next').on('click', function () {
            imgSlides[currentSlide].style.display = 'none';

            if (currentSlide == imgSlides.length - 1) {
                currentSlide = 0; // set the currentSlide to the start of slides
            } else {
                currentSlide++;
            }

            imgSlides[curre");
            WriteLiteral(@"ntSlide].style.display = 'block';
            updateText(currentSlide);
        });

        $('.prev').on('click', function () {
            imgSlides[currentSlide].style.display = 'none';

            if (currentSlide == 0) {
                currentSlide = imgSlides.length - 1; // set the currentSlide to the end of slides
            } else {
                currentSlide--;
            }

            imgSlides[currentSlide].style.display = 'block';
            updateText(currentSlide);
        });

        function updateText(n) {
            $('#lightbox-modal').find('.modal-title').text(n + 1 + ' / ' + imgSlides.length)
        }
    });

    $(function () {
        $('#product-info-tabs li a').on('click', function (e) {
            window.location.hash = '#!#' + e.target.id.toLowerCase();
        });

        $(function () {
            if(window.location.hash.length > 0){
                let id = window.location.hash.replace('#!', '');
                $(id).tab('show');
  ");
            WriteLiteral("          }\r\n        })\r\n    });\r\n\r\n    $(function () {\r\n        $(\'#reviewCount\').on(\'click\', function () {\r\n            window.location.hash = \'#!#reviews\';\r\n            $(\'#reviews\').tab(\'show\');\r\n        });\r\n    });\r\n</script>\r\n");
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
