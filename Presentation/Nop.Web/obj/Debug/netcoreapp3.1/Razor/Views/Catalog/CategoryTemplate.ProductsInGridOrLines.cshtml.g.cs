#pragma checksum "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86228d8c157b341ca6a6cbf68eec8ae309c9c3e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_CategoryTemplate_ProductsInGridOrLines), @"mvc.1.0.view", @"/Views/Catalog/CategoryTemplate.ProductsInGridOrLines.cshtml")]
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
#nullable restore
#line 2 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
using Nop.Core.Domain.Seo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86228d8c157b341ca6a6cbf68eec8ae309c9c3e7", @"/Views/Catalog/CategoryTemplate.ProductsInGridOrLines.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf99b9f327774c79cb47ae67e60399dd32f83f8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_CategoryTemplate_ProductsInGridOrLines : Nop.Web.Framework.Mvc.Razor.NopRazorPage<CategoryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
  
    Layout = "_ColumnsTwo";

    //title
    Html.AddTitleParts(!string.IsNullOrEmpty(Model.MetaTitle) ? Model.MetaTitle : Model.Name);
    //meta
    Html.AddMetaDescriptionParts(Model.MetaDescription);
    Html.AddMetaKeywordParts(Model.MetaKeywords);
    //page class
    Html.AppendPageCssClassParts("html-category-page");

    if (seoSettings.CanonicalUrlsEnabled)
    {
        var categoryUrl = Url.RouteUrl("Category", new { SeName = Model.SeName }, webHelper.CurrentRequestProtocol).ToLowerInvariant();
        Html.AddCanonicalUrlParts(categoryUrl, seoSettings.QueryStringInCanonicalUrlsEnabled);
    }

    var breadcrumbDelimiter = commonSettings.BreadcrumbDelimiter;

#line default
#line hidden
#nullable disable
            DefineSection("Breadcrumb", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
     if (Model.DisplayCategoryBreadcrumb)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"breadcrumb\">\r\n            <ul itemscope itemtype=\"http://schema.org/BreadcrumbList\">\r\n                <li>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1149, "\"", 1181, 1);
#nullable restore
#line 34 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 1156, Url.RouteUrl("Homepage"), 1156, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1182, "\"", 1221, 1);
#nullable restore
#line 34 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 1190, T("Categories.Breadcrumb.Top"), 1190, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                                                                           Write(T("Categories.Breadcrumb.Top"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    <span class=\"delimiter\">");
#nullable restore
#line 35 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                       Write(breadcrumbDelimiter);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </li>\r\n");
#nullable restore
#line 37 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                   int position = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                 foreach (var cat in Model.CategoryBreadcrumb)
                {
                    var isLastCategory = cat.Id == Model.Id;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li itemprop=\"itemListElement\" itemscope itemtype=\"http://schema.org/ListItem\">\r\n");
#nullable restore
#line 42 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                         if (isLastCategory)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <strong class=\"current-item\" itemprop=\"name\">");
#nullable restore
#line 44 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                                                    Write(cat.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            <span itemprop=\"item\" itemscope itemtype=\"http://schema.org/Thing\"");
                BeginWriteAttribute("id", "\r\n                                  id=\"", 1902, "\"", 1994, 1);
#nullable restore
#line 46 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 1942, Url.RouteUrl("Category", new {SeName = cat.SeName}), 1942, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </span>\r\n");
#nullable restore
#line 48 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 2149, "\"", 2210, 1);
#nullable restore
#line 51 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 2156, Url.RouteUrl("Category", new { SeName = cat.SeName }), 2156, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2211, "\"", 2228, 1);
#nullable restore
#line 51 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 2219, cat.Name, 2219, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" itemprop=\"item\">\r\n                                <span itemprop=\"name\">");
#nullable restore
#line 52 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                                 Write(cat.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </a>\r\n                            <span class=\"delimiter\">");
#nullable restore
#line 54 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                               Write(breadcrumbDelimiter);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <meta itemprop=\"position\"");
                BeginWriteAttribute("content", " content=\"", 2511, "\"", 2530, 1);
#nullable restore
#line 56 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 2521, position, 2521, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n");
#nullable restore
#line 58 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                    position++;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n        </div>\r\n");
#nullable restore
#line 62 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsAfterBreadcrumb, additionalData = Model }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                                                                                                                             
    }

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("<div class=\"page category-page\">\r\n    <div class=\"page-title\">\r\n        <h1>");
#nullable restore
#line 67 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"page-body\">\r\n        ");
#nullable restore
#line 70 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsTop, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.Description))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"category-description\">\r\n                ");
#nullable restore
#line 75 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
           Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 77 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 78 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsBeforeSubcategories, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 80 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
         if (Model.SubCategories.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"category-grid sub-category-grid\">\r\n                <div class=\"item-grid\">\r\n");
#nullable restore
#line 84 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                     foreach (var item in Model.SubCategories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item-box\">\r\n                            <div class=\"sub-category-item\">\r\n                                <h2 class=\"title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3907, "\"", 3969, 1);
#nullable restore
#line 89 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 3914, Url.RouteUrl("Category", new { SeName = item.SeName }), 3914, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3970, "\"", 4002, 1);
#nullable restore
#line 89 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 3978, item.PictureModel.Title, 3978, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 90 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </h2>\r\n                                <div class=\"picture\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4232, "\"", 4294, 1);
#nullable restore
#line 94 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 4239, Url.RouteUrl("Category", new { SeName = item.SeName }), 4239, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4295, "\"", 4327, 1);
#nullable restore
#line 94 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 4303, item.PictureModel.Title, 4303, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img");
            BeginWriteAttribute("alt", " alt=\"", 4375, "\"", 4413, 1);
#nullable restore
#line 95 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 4381, item.PictureModel.AlternateText, 4381, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 4414, "\"", 4447, 1);
#nullable restore
#line 95 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 4420, item.PictureModel.ImageUrl, 4420, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4448, "\"", 4480, 1);
#nullable restore
#line 95 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 4456, item.PictureModel.Title, 4456, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 100 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 103 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 104 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsBeforeFeaturedProducts, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 106 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
         if (Model.FeaturedProducts.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"product-grid featured-product-grid\">\r\n                <div class=\"title\">\r\n                    <strong>");
#nullable restore
#line 110 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                       Write(T("Products.FeaturedProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </div>\r\n                <div class=\"item-grid\">\r\n");
#nullable restore
#line 113 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                     foreach (var item in Model.FeaturedProducts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item-box\">\r\n                            ");
#nullable restore
#line 116 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                       Write(await Html.PartialAsync("_ProductBox", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 118 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 121 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 122 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsAfterFeaturedProducts, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 123 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
         if (Model.Products.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
       Write(await Html.PartialAsync("_CatalogSelectors", Model.PagingFilteringContext));

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                                                                       
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 127 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsBeforeFilters, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"product-filters\">\r\n");
#nullable restore
#line 130 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
             if (Model.PagingFilteringContext.PriceRangeFilter.Enabled)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
           Write(await Html.PartialAsync("_FilterPriceBox", Model.PagingFilteringContext.PriceRangeFilter));

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                                                                                          
            }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
             if (Model.PagingFilteringContext.SpecificationFilter.Enabled)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
           Write(await Html.PartialAsync("_FilterSpecsBox", Model.PagingFilteringContext.SpecificationFilter));

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                                                                                                             
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        ");
#nullable restore
#line 140 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsBeforeProductList, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 142 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
         if (Model.Products.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 6703, "\"", 6795, 1);
#nullable restore
#line 144 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
WriteAttributeValue("", 6711, Model.PagingFilteringContext.ViewMode == "list" ? "product-list" : "product-grid", 6711, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"item-grid\">\r\n");
#nullable restore
#line 146 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                     foreach (var product in Model.Products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item-box\">\r\n                            ");
#nullable restore
#line 149 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                       Write(await Html.PartialAsync("_ProductBox", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 151 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 154 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
          
            var pager = Html.Pager(Model.PagingFilteringContext).QueryParam("pagenumber");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
         if (!pager.IsEmpty())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pager\">\r\n                ");
#nullable restore
#line 161 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
           Write(pager);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 163 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 164 "D:\PERSONAL PROJECTS\nopCommerce-release-4.30\ecommerce\nopCommerce-release-4.30\src\Presentation\Nop.Web\Views\Catalog\CategoryTemplate.ProductsInGridOrLines.cshtml"
   Write(await Component.InvokeAsync("Widget", new { widgetZone = PublicWidgetZones.CategoryDetailsBottom, additionalData = Model }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CommonSettings commonSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SeoSettings seoSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Core.IWebHelper webHelper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
