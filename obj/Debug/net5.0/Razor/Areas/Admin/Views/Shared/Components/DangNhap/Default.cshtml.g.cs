#pragma checksum "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a21e95000285fc5f2e8dcd287c3c4e2302d5cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_DangNhap_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/DangNhap/Default.cshtml")]
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
#line 1 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\_ViewImports.cshtml"
using WebBanHangOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a21e95000285fc5f2e8dcd287c3c4e2302d5cc", @"/Areas/Admin/Views/Shared/Components/DangNhap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94eae2351e8790c971705f00a24b6b8474140bd8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_DangNhap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebBanHangOnline.Models.TaiKhoan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/cuahango.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("login form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 1rem 0 0 1rem; height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
   ViewBag.Title = "Đăng nhập";
                string thongbao = ViewBag.ThongBao; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""vh-100"" style=""background-color: #b3d1b3; "">
    <div class=""container py-5 h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col col-xl-10"">
                <div class=""card"" style=""border-radius: 1rem;"">
                    <div class=""row g-0"">
                        <div class=""col-md-6 col-lg-5 d-none d-md-block"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e8a21e95000285fc5f2e8dcd287c3c4e2302d5cc5450", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                        <div class=\"col-md-6 col-lg-7 d-flex align-items-center\">\n                            <div class=\"card-body p-4 p-lg-5 text-black\">\n");
#nullable restore
#line 15 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
                                 using (Html.BeginForm("DangNhap", "DangNhap"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""d-flex align-items-center mb-3 pb-1"">
                        <i class=""fas fa-cubes fa-2x me-3"" style=""color: #ff6219;""></i>
                        <span class=""h1 fw-bold mb-0""> </span>
                    </div>
                                    <h5 class=""fw-normal mb-3 pb-3"" style=""letter-spacing: 1px;"">Đăng nhập bằng tài khoản</h5> ");
#nullable restore
#line 21 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
                                                                                                                               if (!string.IsNullOrEmpty(thongbao))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div style=\"color: red;\">");
#nullable restore
#line 23 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
                                                        Write(thongbao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> ");
#nullable restore
#line 23 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
                                                                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"form-outline mb-4\">\n                                        ");
#nullable restore
#line 25 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
                                   Write(Html.TextBoxFor(m => m.TaiKhoan1, new { @class = "form-control form-control-lg" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <label class=""form-label"" for=""TaiKhoan"">Tài khoản</label>
                                    </div>
                                                    <div class=""form-outline mb-4"">
                                                        ");
#nullable restore
#line 29 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
                                                   Write(Html.TextBoxFor(m => m.MatKhau, new { @class = "form-control form-control-lg", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        <label class=\"form-label\" for=\"MatKhau\">Mật khẩu</label>\n                                                    </div>\n");
            WriteLiteral(@"                                                                    <div class=""pt-1 mb-4"">
                                                                        <input class=""btn btn-dark btn-lg btn-block"" type=""submit"" value=""Đăng nhập"" />
                                                                    </div>
");
            WriteLiteral(@"                                                                                    <a class=""small text-muted"" href=""#!"">Quên mật khẩu</a>
                                                                                                    <p class=""mb-5 pb-lg-2"" style=""color: #393f81;"">
                                                                                                        Don't have an account? <a href=""#!""
                                                                                                                                  style=""color: #393f81;"">Register here</a>
                                                                                                    </p>
                                                                                                                    <a href=""#!"" class=""small text-muted"">Terms of use.</a>
                                                                                                                                    <a href=""#!"" c");
            WriteLiteral("lass=\"small text-muted\">Privacy policy</a>");
#nullable restore
#line 43 "D:\Xây dựng Website\Git\WebBanHangOnline\Areas\Admin\Views\Shared\Components\DangNhap\Default.cshtml"
                                                                                                                                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanHangOnline.Models.TaiKhoan> Html { get; private set; }
    }
}
#pragma warning restore 1591