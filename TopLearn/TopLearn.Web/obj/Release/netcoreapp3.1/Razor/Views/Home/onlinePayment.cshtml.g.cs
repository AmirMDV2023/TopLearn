#pragma checksum "F:\Project.Net Core\Test\TopLearn\TopLearn.Web\Views\Home\onlinePayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ecf0274f8ed3c03dbc86837c06491f8fedbf35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_onlinePayment), @"mvc.1.0.view", @"/Views/Home/onlinePayment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/onlinePayment.cshtml", typeof(AspNetCore.Views_Home_onlinePayment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ecf0274f8ed3c03dbc86837c06491f8fedbf35", @"/Views/Home/onlinePayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_onlinePayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Project.Net Core\Test\TopLearn\TopLearn.Web\Views\Home\onlinePayment.cshtml"
  
    ViewData["Title"] = "نتیجه پرداخت";

#line default
#line hidden
            BeginContext(50, 256, true);
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">نتیجه پرداخت</li>
    </ul>
</nav>

<div class=""container"">
");
            EndContext();
#line 14 "F:\Project.Net Core\Test\TopLearn\TopLearn.Web\Views\Home\onlinePayment.cshtml"
 if (ViewBag.IsSuccess==true)
{

#line default
#line hidden
            BeginContext(340, 108, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <h2>پرداخت با موفقیت انجام شد.</h2>\r\n        <p> کد پیگیری : ");
            EndContext();
            BeginContext(449, 12, false);
#line 18 "F:\Project.Net Core\Test\TopLearn\TopLearn.Web\Views\Home\onlinePayment.cshtml"
                   Write(ViewBag.code);

#line default
#line hidden
            EndContext();
            BeginContext(461, 18, true);
            WriteLiteral("</p>\r\n    </div>\r\n");
            EndContext();
#line 20 "F:\Project.Net Core\Test\TopLearn\TopLearn.Web\Views\Home\onlinePayment.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(489, 86, true);
            WriteLiteral(" <div class=\"alert alert-danger\">\r\n      <h2>پرداخت با شکست مواجه شد.</h2>\r\n  </div>\r\n");
            EndContext();
#line 25 "F:\Project.Net Core\Test\TopLearn\TopLearn.Web\Views\Home\onlinePayment.cshtml"
}

#line default
#line hidden
            BeginContext(578, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
