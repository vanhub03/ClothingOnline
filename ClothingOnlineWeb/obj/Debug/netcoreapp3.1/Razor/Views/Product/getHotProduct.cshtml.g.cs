#pragma checksum "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5551765cf1c885106541bb7f425bfe28fe2300f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_getHotProduct), @"mvc.1.0.view", @"/Views/Product/getHotProduct.cshtml")]
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
#nullable restore
#line 1 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\_ViewImports.cshtml"
using ClothingOnlineWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\_ViewImports.cshtml"
using ClothingOnlineWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5551765cf1c885106541bb7f425bfe28fe2300f2", @"/Views/Product/getHotProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6fe23a1b7680364ac854ed60d2b0058f93bfd73", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_getHotProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("loi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#f1f2f7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5551765cf1c885106541bb7f425bfe28fe2300f24455", async() => {
                WriteLiteral(@"
    <link id=""u-theme-google-font"" rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i|Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"">
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5551765cf1c885106541bb7f425bfe28fe2300f25985", async() => {
                WriteLiteral("\r\n    <div class=\"container bootdey row\">\r\n        <div class=\"col-md-3\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n                <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 12 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
                       ProjectPRN211Context context = new ProjectPRN211Context();
                                    var categories = context.Categories.ToList();
                                    foreach (var item in categories)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li class=\"list-group-item\"><a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 1163, "\"", 1219, 2);
                WriteAttributeValue("", 1170, "/product/getProductByCategory?id=", 1170, 33, true);
#nullable restore
#line 16 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
WriteAttributeValue("", 1203, item.Categoryid, 1203, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 16 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
                                                                                                                                 Write(item.Categoryname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li> ");
#nullable restore
#line 16 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
                                                                                                                                                                  } 

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-9 px-4 px-lg-5 mt-5 row gx-4 gx-lg-5 row-cols-xl-3 justify-content-center\">\r\n");
#nullable restore
#line 21 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
               foreach (var p in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col mb-5\">\r\n                        <div class=\"card h-100\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5551765cf1c885106541bb7f425bfe28fe2300f28791", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1630, "~/Images/", 1630, 9, true);
#nullable restore
#line 25 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
AddHtmlAttributeValue("", 1639, p.Images.First().Imagelink, 1639, 27, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"card-body p-4\">\r\n                                <div class=\"text-center\">\r\n                                    <h5 class=\"fw-bolder\">\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 1900, "\"", 1948, 2);
                WriteAttributeValue("", 1907, "/product/getproductdetail?id=", 1907, 29, true);
#nullable restore
#line 29 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
WriteAttributeValue("", 1936, p.Productid, 1936, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pro-title\">\r\n                                            ");
#nullable restore
#line 30 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
                                       Write(p.Productname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </a>\r\n                                    </h5>\r\n                                    <p class=\"price\">$");
#nullable restore
#line 33 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
                                                 Write(p.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                                <div class=""text-center""><a class=""btn btn-outline-dark mt-auto""");
                BeginWriteAttribute("href", " href=\"", 2451, "\"", 2499, 2);
                WriteAttributeValue("", 2458, "/product/addtocart?productId=", 2458, 29, true);
#nullable restore
#line 37 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
WriteAttributeValue("", 2487, p.Productid, 2487, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Add to cart</a></div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 41 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Product\getHotProduct.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<style type=\"text/css\">\r\n    .pro-title {\r\n        color: #5A5A5A;\r\n        display: inline-block;\r\n        margin-top: 20px;\r\n        font-size: 16px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591