#pragma checksum "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27975b92d16ea55819aa38b4658d4af708088f4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_CreateRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/CreateRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/CreateRole.cshtml", typeof(AspNetCore.Pages_Admin_Roles_CreateRole), null)]
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
#line 2 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
using TopLearn.DataLayer.Entities.Permissions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27975b92d16ea55819aa38b4658d4af708088f4f", @"/Pages/Admin/Roles/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_CreateRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
  
    ViewData["Title"] = "افزودن نقش";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
            BeginContext(237, 175, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">افزودن کاربر جدید</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(412, 2862, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27975b92d16ea55819aa38b4658d4af708088f4f4902", async() => {
                BeginContext(432, 381, true);
                WriteLiteral(@"
        <div class=""col-md-8"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                    نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label>عنوان نقش :</label>
                        ");
                EndContext();
                BeginContext(813, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27975b92d16ea55819aa38b4658d4af708088f4f5673", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 26 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitle);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(878, 516, true);
                WriteLiteral(@"
                    </div>

                    <input type=""submit"" value=""ذخیره اطلاعات"" class=""btn btn-success"" />
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    دسترسی های نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <ul>
");
                EndContext();
#line 42 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                         foreach (var permission in permissions.Where(p => p.ParentID == null))
                        {

#line default
#line hidden
                BeginContext(1518, 114, true);
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1632, "\"", 1664, 1);
#line 45 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 1640, permission.PermissionId, 1640, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1665, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(1669, 26, false);
#line 45 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                               Write(permission.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1695, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 46 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                 if (permissions.Any(p => p.ParentID == permission.ParentID))
                                {
                                    

#line default
#line hidden
#line 48 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                     foreach (var sub in permissions.Where(p => p.ParentID == permission.PermissionId))
                                    {

#line default
#line hidden
                BeginContext(1987, 130, true);
                WriteLiteral("                                    <li>\r\n                                        <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2117, "\"", 2142, 1);
#line 51 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2125, sub.PermissionId, 2125, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2143, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(2147, 19, false);
#line 51 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                Write(sub.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2166, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                         if (permissions.Any(p => p.ParentID == sub.ParentID))
                                        {

#line default
#line hidden
                BeginContext(2307, 50, true);
                WriteLiteral("                                            <ul>\r\n");
                EndContext();
#line 55 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                 foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionId))
                                                {

#line default
#line hidden
                BeginContext(2535, 162, true);
                WriteLiteral("                                                    <li>\r\n                                                        <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2697, "\"", 2723, 1);
#line 58 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2705, sub2.PermissionId, 2705, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2724, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(2728, 20, false);
#line 58 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                 Write(sub2.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2748, 61, true);
                WriteLiteral("\r\n                                                    </li>\r\n");
                EndContext();
#line 60 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                }

#line default
#line hidden
                BeginContext(2860, 51, true);
                WriteLiteral("                                            </ul>\r\n");
                EndContext();
#line 62 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                        }

#line default
#line hidden
                BeginContext(2954, 43, true);
                WriteLiteral("                                    </li>\r\n");
                EndContext();
#line 64 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                }

#line default
#line hidden
#line 64 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                 
                                }

#line default
#line hidden
                BeginContext(3067, 39, true);
                WriteLiteral("                                </li>\r\n");
                EndContext();
#line 67 "F:\Project.Net Core\Share\Test\TopLearn\TopLearn.Web\Pages\Admin\Roles\CreateRole.cshtml"
                            }

#line default
#line hidden
                BeginContext(3137, 130, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3274, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Web.Pages.Admin.Roles.CreateRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.Roles.CreateRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TopLearn.Web.Pages.Admin.Roles.CreateRoleModel>)PageContext?.ViewData;
        public TopLearn.Web.Pages.Admin.Roles.CreateRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
