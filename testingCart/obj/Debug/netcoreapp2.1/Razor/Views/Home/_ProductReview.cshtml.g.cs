#pragma checksum "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2a2ea0d74a6dadd8af382598ac42ae64bc3a48e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ProductReview), @"mvc.1.0.view", @"/Views/Home/_ProductReview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_ProductReview.cshtml", typeof(AspNetCore.Views_Home__ProductReview))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2a2ea0d74a6dadd8af382598ac42ae64bc3a48e", @"/Views/Home/_ProductReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f36e0faaa247e5973a69634d2ee70ba678324f94", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ProductReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CreateReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(21, 279, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""col-md-12"">
        <table class=""review-table table-bordered table-striped"">
            <thead>
                <tr>
                    <td colspan=""2"" class=""review-rating-result"">
                        <h6>Customer reviews of ");
            EndContext();
            BeginContext(301, 10, false);
#line 8 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductReview.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(311, 3004, true);
            WriteLiteral(@"</h6>
                        <div class=""row"">
                            <div class=""col-md-3"">
                                <div>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <small id=""five-star""> (0)</small>
                                </div>
                                <div>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa");
            WriteLiteral(@" fa-star star-inactive""></i>
                                    <small id=""four-star""> (0)</small>
                                </div>
                                <div>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-inactive""></i>
                                    <i class=""fa fa-star star-inactive""></i>
                                    <small id=""three-star""> (0)</small>
                                </div>
                                <div>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-inactive""></i>
                                    <i class=""fa fa-star star-inactive""></i>");
            WriteLiteral(@"
                                    <i class=""fa fa-star star-inactive""></i>
                                    <small id=""two-star""> (0)</small>
                                </div>
                                <div>
                                    <i class=""fa fa-star star-active""></i>
                                    <i class=""fa fa-star star-inactive""></i>
                                    <i class=""fa fa-star star-inactive""></i>
                                    <i class=""fa fa-star star-inactive""></i>
                                    <i class=""fa fa-star star-inactive""></i>
                                    <small id=""one-star""> (0)</small>
                                </div>
                            </div>
                            <div class=""col-md-9"" style=""padding-top: 25px;"">
                                <div style=""margin-bottom: 3px;"">Share your thoughts with other customers</div>
");
            EndContext();
#line 54 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductReview.cshtml"
                                   
                                    var reviewText = "Write a review";
                                    if (ViewData["ProductReviewer"] != null && (bool)ViewData["ProductReviewer"])
                                    {
                                        reviewText = "Edit your review";
                                    }
                                

#line default
#line hidden
            BeginContext(3726, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3758, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0846fe4013ab4be2bc29c062983e5a02", async() => {
                BeginContext(3853, 10, false);
#line 61 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductReview.cshtml"
                                                                                                                         Write(reviewText);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 61 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductReview.cshtml"
                                                                             WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3867, 1724, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </td>
                </tr>
            </thead>
            <tbody id=""review-container""></tbody>
        </table>
    </div>
</div>

<script>
    $(function () {
        var template = `
            <tr>
                <th>
                    <ul>
                        <li class =""r-user"">_user_placeholder</li>
                        <li class =""r-date"">_date_placeholder</li>
                        <li class =""r-verified"">_verified_placeholder</li>
                    </ul>
                </th>
                <td>
                    <div>
                        _star_placeholder
                        <span class =""review-title"">_title_placeholder</span>
                    </div>

                    <div class =""review-message"">
                        <p>_message_placeholder</p>
                        <span class =""date-edited text-muted"">_date_modified_placeholder</span>
    ");
            WriteLiteral(@"                </div>
                    <p class =""helpful text-muted"">
                        Did you find this review helpful?
                        <button class =""btn btn-sm btn-secondary"">Yes</button>
                        <button class =""btn btn-sm btn-secondary"">No</button>
                    </p>
                </td>
            </tr>
        `

        // get product review
        $('a[data-toggle=""tab""').on('shown.bs.tab', function (e) {
            if (e.target.id === 'reviews') {
                $('#review-container').append(""<div>Loading...</div>"");
                $.ajax({
                    type: 'GET',
                    url: '/home/productreview/");
            EndContext();
            BeginContext(5592, 8, false);
#line 108 "D:\AJEET\github.com\aspCart\testingCart\Views\Home\_ProductReview.cshtml"
                                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5600, 3643, true);
            WriteLiteral(@"',
                    dataType: 'Json',
                    success: function (data) {
                        $('#review-container').empty(); // remove existing dom

                        let one = 0, two = 0, three = 0, four = 0, five = 0;

                        if (data.length > 0) {
                            $.each(data, function (i, item) {

                                let review = template;
                                review = review.replace('_user_placeholder', item.username);
                                review = review.replace('_date_placeholder', item.createdOn);
                                review = review.replace('_star_placeholder', createStar(item.rating));
                                review = review.replace('_title_placeholder', item.title);
                                review = review.replace('_message_placeholder', item.message);

                                if (item.dateModified !== '1/1/0001 12:00:00 AM')
                                    ");
            WriteLiteral(@"review = review.replace('_date_modified_placeholder', 'Last edited: ' + item.dateModified);
                                else
                                    review = review.replace('_date_modified_placeholder', '');

                                if (item.isVerifiedOwner)
                                    review = review.replace('_verified_placeholder', '<i class =""fa fa-check verified-check""></i> Verified Purchase');
                                else
                                    review = review.replace('_verified_placeholder', '<i class =""fa fa-close verified-x""></i> Verified Purchase');

                                switch (item.rating) {
                                    case 1: one++; break;
                                    case 2: two++; break;
                                    case 3: three++; break;
                                    case 4: four++; break;
                                    case 5: five++; break;
                                }

    ");
            WriteLiteral(@"                            $('#review-container').append(review);
                            });
                        } else {
                            $('#review-container').append('<h5 style=""text-align: center; padding: 20px;"">There are no reviews yet...</div>');
                        }   

                        // set review count and percentage
                        $('#one-star').empty();
                        $('#one-star').append(one / data.length * 100 + '% (' + one + ')');

                        $('#two-star').empty();
                        $('#two-star').append(two / data.length * 100 + '% (' + two + ')');

                        $('#three-star').empty();
                        $('#three-star').append(three / data.length * 100 + '% (' + three + ')');

                        $('#four-star').empty();
                        $('#four-star').append(four / data.length * 100 + '% (' + four + ')');

                        $('#five-star').empty();
               ");
            WriteLiteral(@"         $('#five-star').append(five / data.length * 100 + '% (' + five + ')');
                    }
                });
            }
        });

        function createStar(count) {
            let starTemplate = '';
            for (i = 0; i < count; i++) {
                starTemplate += '<i class=""fa fa-star star-active""></i>';
            }

            for (i = 0; i < 5 - count; i++) {
                starTemplate += '<i class=""fa fa-star star-inactive""></i>';
            }

            return starTemplate;
        };
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
