#pragma checksum "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86d3cf83986ba9c931f7bac4a72b7f6533e3909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CategoryPartial), @"mvc.1.0.view", @"/Views/Shared/_CategoryPartial.cshtml")]
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
#nullable restore
#line 1 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86d3cf83986ba9c931f7bac4a72b7f6533e3909", @"/Views/Shared/_CategoryPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6fe23a1b7680364ac854ed60d2b0058f93bfd73", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CategoryPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml"
  
    ProjectPRN211Context context = new ProjectPRN211Context();
    var categories = context.Categories.ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"nav-item dropdown\">\r\n    <span class=\"nav-link dropdown-toggle\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n        Thể loại\r\n    </span>\r\n    <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">\r\n");
#nullable restore
#line 13 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml"
          
            foreach (var item in categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 602, "\"", 658, 2);
            WriteAttributeValue("", 609, "/product/getProductByCategory?id=", 609, 33, true);
#nullable restore
#line 16 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml"
WriteAttributeValue("", 642, item.Categoryid, 642, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml"
                                                                                                 Write(item.Categoryname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 17 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Shared\_CategoryPartial.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</li>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591