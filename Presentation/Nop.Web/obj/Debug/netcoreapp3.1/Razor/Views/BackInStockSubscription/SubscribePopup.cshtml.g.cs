#pragma checksum "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1ab9b27f41594ad1ee9435477b97e3e04fc54bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BackInStockSubscription_SubscribePopup), @"mvc.1.0.view", @"/Views/BackInStockSubscription/SubscribePopup.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1ab9b27f41594ad1ee9435477b97e3e04fc54bd", @"/Views/BackInStockSubscription/SubscribePopup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf99b9f327774c79cb47ae67e60399dd32f83f8c", @"/Views/_ViewImports.cshtml")]
    public class Views_BackInStockSubscription_SubscribePopup : Nop.Web.Framework.Mvc.Razor.NopRazorPage<BackInStockSubscribeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"page back-in-stock-subscription-page\">\n    <div class=\"page-title\">\n        <h1>\n");
#nullable restore
#line 5 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
             if (Model.AlreadySubscribed)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
           Write(T("BackInStockSubscriptions.AlreadySubscribed"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
                                                                
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
           Write(T("BackInStockSubscriptions.PopupTitle"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
                                                         
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </h1>\n    </div>\n    <div class=\"page-body\">\n");
#nullable restore
#line 16 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
         if (!Model.SubscriptionAllowed)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                ");
#nullable restore
#line 19 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
           Write(T("BackInStockSubscriptions.NotAllowed"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 21 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
        }
        else if (!Model.IsCurrentCustomerRegistered)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                ");
#nullable restore
#line 25 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
           Write(T("BackInStockSubscriptions.OnlyRegistered"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 27 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
        }
        else if (!Model.AlreadySubscribed && Model.CurrentNumberOfBackInStockSubscriptions >= Model.MaximumBackInStockSubscriptions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                ");
#nullable restore
#line 31 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
           Write(string.Format(T("BackInStockSubscriptions.MaxSubscriptions").Text, Model.MaximumBackInStockSubscriptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 33 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
        }
        else
        {
            if (!Model.AlreadySubscribed)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"tooltip\">");
#nullable restore
#line 38 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
                                Write(T("BackInStockSubscriptions.Tooltip"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 39 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\" id=\"back-in-stock-notify-me\" class=\"button-1 notify-me-button\">\n                ");
#nullable restore
#line 41 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
            Write(Model.AlreadySubscribed ? @T("BackInStockSubscriptions.Unsubscribe").Text : @T("BackInStockSubscriptions.NotifyMe").Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </button>
            <script>
                $(document).ready(function () {
                    $(""#back-in-stock-notify-me"").on('click', function () {
                        var subscribeButton = this;
                        $.ajax({
                            cache: false,
                            type: ""POST"",
                            url: """);
#nullable restore
#line 50 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
                              Write(Url.RouteUrl("BackInStockSubscribeSend", new { productId = Model.ProductId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                            success: function (data, textStatus, jqXHR) {
                                $(subscribeButton).closest('.ui-dialog-content').dialog('destroy').remove();
                                location.reload();
                            },
                            error: function (jqXHR, textStatus, errorThrown) {
                                alert('Failed to change subscription.');
                            }
                        });

                    });
                });
            </script>
");
#nullable restore
#line 63 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\BackInStockSubscription\SubscribePopup.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BackInStockSubscribeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
