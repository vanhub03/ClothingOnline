#pragma checksum "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79e65388ce9a23e5d39142336beca62e86e4be16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Product), @"mvc.1.0.view", @"/Views/Admin/Product.cshtml")]
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
#line 1 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
using ClothingOnlineWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e65388ce9a23e5d39142336beca62e86e4be16", @"/Views/Admin/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6fe23a1b7680364ac854ed60d2b0058f93bfd73", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css1/sb-admin-2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery-easing/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js1/sb-admin-2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/datatables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js1/datatables-demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be169699", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 357, "\"", 367, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 393, "\"", 403, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\n    <title>SB Admin 2 - Tables</title>\n\n    <!-- Custom fonts for this template -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e65388ce9a23e5d39142336beca62e86e4be1610612", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <link href=\"https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i\"\n          rel=\"stylesheet\">\n\n    <!-- Custom styles for this template -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e65388ce9a23e5d39142336beca62e86e4be1612088", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Custom styles for this page -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "79e65388ce9a23e5d39142336beca62e86e4be1613310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1615194", async() => {
                WriteLiteral(@"

    <!-- Page Wrapper -->
    <div id=""wrapper"">

        <!-- Sidebar -->
        <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

            <!-- Sidebar - Brand -->
            <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
                <div class=""sidebar-brand-icon rotate-n-15"">
                    <i class=""fas fa-laugh-wink""></i>
                </div>
                <div class=""sidebar-brand-text mx-3"">SB Admin <sup>2</sup></div>
            </a>

            <!-- Divider -->
            <hr class=""sidebar-divider my-0"">

            <!-- Nav Item - Dashboard -->
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""index.html"">
                    <i class=""fas fa-fw fa-tachometer-alt""></i>
                    <span>Dashboard</span>
                </a>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
 ");
                WriteLiteral("           <div class=\"sidebar-heading\">\n                Manage\n            </div>\n\n            <!-- Nav Item - Pages Collapse Menu -->\n            <li class=\"nav-item\">\n\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1616735", async() => {
                    WriteLiteral("\n                    <i class=\"fas fa-fw fa-cog\"></i>\n                    <span>Accounts</span>\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n            </li>\n\n            <!-- Nav Item - Utilities Collapse Menu -->\n            <li class=\"nav-item\">\n                <a class=\"nav-link \"");
                BeginWriteAttribute("href", " href=\"", 2550, "\"", 2587, 1);
#nullable restore
#line 80 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
WriteAttributeValue("", 2557, Url.Action("Product","Admin"), 2557, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <i class=""fas fa-fw fa-cog""></i>
                    <span>Products</span>
                </a>

            </li>

            <li class=""nav-item"">
                <a class=""nav-link "" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo""
                   aria-expanded=""true"" aria-controls=""collapseTwo"">
                    <i class=""fas fa-fw fa-cog""></i>
                    <span>Orders</span>
                </a>

            </li>




        </ul>
        <!-- End of Sidebar -->
        <!-- Content Wrapper -->
        <div id=""content-wrapper"" class=""d-flex flex-column"">

            <!-- Main Content -->
            <div id=""content"">

                <!-- Topbar -->
                <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">



                </nav>
                <!-- End of Topbar -->
                <!-- Begin Page Content -->
                <div class=""container-fluid"">

                    <!-- Page Heading -->
         ");
                WriteLiteral(@"           <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
                        <h1 class=""h3 mb-0 text-gray-800"">Account</h1>

                    </div>


                    <!-- DataTales Example -->
                    <div class=""card shadow mb-4"">
                        <div class=""card-header py-3"" style=""display: flex; justify-content: space-between;"">
                            <h6 class=""m-0 font-weight-bold text-primary"">DataTables Example</h6>
                            <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"">
                                <i class=""fas fa-plus-circle fa-sm text-white-50""></i> Add New Account
                            </a>
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                    <the");
                WriteLiteral(@"ad>
                                        <tr>
                                            <th>ID</th>
                                            <th>UserName</th>
                                            <th>Password</th>
                                            <th>Address</th>
                                            <th>Phone</th>
                                            <th>Email</th>
                                            <th>Enable</th>
                                            <th>Category</th>
                                            <th></th>
                                        </tr>
                                    </thead>

                                    <tbody>
");
#nullable restore
#line 150 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                                         foreach (var p in Model)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 153 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                               Write(p.Productid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 154 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                               Write(p.Productname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 155 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                               Write(p.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 156 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                               Write(p.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 157 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                               Write(p.Unitinstock);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 158 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                               Write(p.Enable);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n");
#nullable restore
#line 159 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                                 if (p.Enable == true)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>Enable</td> ");
#nullable restore
#line 161 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>Disable</td>");
#nullable restore
#line 164 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>");
#nullable restore
#line 165 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
                               Write(p.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                <td>
                                    <button type=""button"" class=""btn btn-success"">Edit</button>
                                    <button type=""button"" class=""btn btn-danger"">Delete</button>
                                </td>
                            </tr>
");
#nullable restore
#line 171 "D:\PRN211\project\ClothingOnline\ClothingOnlineWeb\Views\Admin\Product.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

                </div>
                <!-- /.container-fluid -->

            </div>
            <!-- End of Main Content -->
            <!-- Footer -->
            <footer class=""sticky-footer bg-white"">
                <div class=""container my-auto"">
                    <div class=""copyright text-center my-auto"">
                        <span>Copyright &copy; Your Website 2020</span>
                    </div>
                </div>
            </footer>
            <!-- End of Footer -->

        </div>
        <!-- End of Content Wrapper -->

    </div>
    <!-- End of Page Wrapper -->
    <!-- Scroll to Top Button-->
    <a class=""scroll-to-top rounded"" href=""#page-top"">
        <i class=""fas fa-angle-up""></i>
    </a>

    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-lab");
                WriteLiteral(@"elledby=""exampleModalLabel""
         aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1627618", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1628716", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Core plugin JavaScript-->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1629852", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Custom scripts for all pages-->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1630995", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Page level plugins -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1632129", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1633228", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <!-- Page level custom scripts -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79e65388ce9a23e5d39142336beca62e86e4be1634369", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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