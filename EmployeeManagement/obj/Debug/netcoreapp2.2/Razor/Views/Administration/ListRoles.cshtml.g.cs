#pragma checksum "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22950d0440b16d83d64b468d56858288da454235"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListRoles), @"mvc.1.0.view", @"/Views/Administration/ListRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListRoles.cshtml", typeof(AspNetCore.Views_Administration_ListRoles))]
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
#line 1 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#line 3 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22950d0440b16d83d64b468d56858288da454235", @"/Views/Administration/ListRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0afa2156460ac4fec37a97a6c13148822d8ad41e", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomJavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
  
    ViewBag.Title = "All Roles";

#line default
#line hidden
            BeginContext(173, 22, true);
            WriteLiteral("<h1>All Roles</h1>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(217, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(221, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22950d0440b16d83d64b468d56858288da4542357978", async() => {
                BeginContext(336, 12, true);
                WriteLiteral("Add new role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(352, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"

    foreach (var role in Model)
    {

#line default
#line hidden
            BeginContext(396, 98, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-header\">\r\n                Role Id : ");
            EndContext();
            BeginContext(495, 7, false);
#line 19 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                     Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(502, 98, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(601, 9, false);
#line 22 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                                  Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(610, 82, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            EndContext();
            BeginContext(692, 1214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22950d0440b16d83d64b468d56858288da45423511038", async() => {
                BeginContext(760, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                     if ((await authorizationService.AuthorizeAsync(User, "EditRolePolicy")).Succeeded)
                    {

#line default
#line hidden
                BeginContext(890, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(914, 141, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22950d0440b16d83d64b468d56858288da45423511830", async() => {
                    BeginContext(1047, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 29 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                                                             WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1055, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                    }

#line default
#line hidden
                BeginContext(1080, 25, true);
                WriteLiteral("                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1105, "\"", 1136, 2);
                WriteAttributeValue("", 1110, "confirmDeleteSpan_", 1110, 18, true);
#line 31 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1128, role.Id, 1128, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1137, 238, true);
                WriteLiteral(" style=\"display:none\">\r\n                        <span>Are you sure you want to delete?</span>\r\n                        <button type=\"submit\" class=\"btn btn-danger\">Yes</button>\r\n                        <a href=\"#/\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 1375, "\"", 1445, 4);
                WriteAttributeValue("", 1413, "confirmDelete(\'", 1413, 15, true);
#line 35 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1428, role.Id, 1428, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1436, "\',", 1436, 2, true);
                WriteAttributeValue(" ", 1438, "false)", 1439, 7, true);
                EndWriteAttribute();
                BeginContext(1446, 65, true);
                WriteLiteral(">No</a>\r\n                    </span>\r\n\r\n                    <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1511, "\"", 1535, 2);
                WriteAttributeValue("", 1516, "deleteSpan_", 1516, 11, true);
#line 38 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1527, role.Id, 1527, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1536, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 39 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                         if ((await authorizationService.AuthorizeAsync(User, "DeleteRolePolicy")).Succeeded)
                        {

#line default
#line hidden
                BeginContext(1677, 63, true);
                WriteLiteral("                            <a href=\"#/\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                               onclick=\"", 1740, "\"", 1813, 4);
                WriteAttributeValue("", 1782, "confirmDelete(\'", 1782, 15, true);
#line 42 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
WriteAttributeValue("", 1797, role.Id, 1797, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1805, "\',", 1805, 2, true);
                WriteAttributeValue(" ", 1807, "true)", 1808, 6, true);
                EndWriteAttribute();
                BeginContext(1814, 13, true);
                WriteLiteral(">Delete</a>\r\n");
                EndContext();
#line 43 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                        }

#line default
#line hidden
                BeginContext(1854, 45, true);
                WriteLiteral("                    </span>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
                                                              WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1906, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 48 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(1963, 265, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            No roles created yet
        </div>
        <div class=""card-body"">
            <h5 class=""card-title"">
                Use the button below to create a role
            </h5>
            ");
            EndContext();
            BeginContext(2228, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22950d0440b16d83d64b468d56858288da45423521524", async() => {
                BeginContext(2346, 43, true);
                WriteLiteral("\r\n                Create Role\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2393, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 66 "C:\Users\oa984e\source\repos\ASP.NetCoreDemo\EmployeeManagement\Views\Administration\ListRoles.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(2444, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2450, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22950d0440b16d83d64b468d56858288da45423523671", async() => {
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
                EndContext();
                BeginContext(2498, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591