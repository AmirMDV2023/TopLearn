#pragma checksum "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e50c73487fb22da9baae7795ba671525462e74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_Shared__SideBar), @"mvc.1.0.view", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/UserPanel/Views/Shared/_SideBar.cshtml", typeof(AspNetCore.Areas_UserPanel_Views_Shared__SideBar))]
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
#line 1 "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.Convertors;

#line default
#line hidden
#line 2 "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.DTOs;

#line default
#line hidden
#line 3 "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
using TopLearn.Core.Services.Interfaces;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e50c73487fb22da9baae7795ba671525462e74", @"/Areas/UserPanel/Views/Shared/_SideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_Shared__SideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(137, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
  
    SideBarUserPanelViewModel user = _UserService.GetSideBarUserPanelData(User.Identity.Name);

#line default
#line hidden
            BeginContext(242, 237, true);
            WriteLiteral("\r\n<div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n    <aside>\r\n\r\n        <div class=\"avatar-layer\">\r\n            <div class=\"img-layer\">\r\n                <a href=\"\" class=\"change-image\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 479, "\"", 512, 2);
            WriteAttributeValue("", 485, "/UserAvatar/", 485, 12, true);
#line 16 "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
WriteAttributeValue("", 497, user.ImageName, 497, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(513, 80, true);
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"detail\">\r\n                <span> ");
            EndContext();
            BeginContext(594, 13, false);
#line 19 "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
                  Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(607, 41, true);
            WriteLiteral(" </span>\r\n                <span> عضویت : ");
            EndContext();
            BeginContext(649, 28, false);
#line 20 "E:\Project.Net Core\Test\TopLearn\TopLearn.Web\Areas\UserPanel\Views\Shared\_SideBar.cshtml"
                          Write(user.RegisterDate.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(677, 720, true);
            WriteLiteral(@" </span>
            </div>
        </div>

        <section>
            <header><h3> میز کار </h3></header>
            <div class=""inner"">
                <ul>
                    <li><a href=""/UserPanel""> مشاهده حساب کابری </a></li>
                    <li><a href=""/UserPanel/EditProfile""> ویرایش حساب کابری </a></li>
                    <li><a href=""/UserPanel/ChangePassword""> تغییر رمز عبور </a></li>
                    <li><a href=""/UserPanel/Wallet""> کیف پول شما </a></li>
                    <li><a href=""""> تنظیمات حساب کاربری </a></li>
                    <li><a href=""/Logout""> خروج از حساب کاربری </a></li>
                </ul>
            </div>
        </section>
    </aside>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _UserService { get; private set; }
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
