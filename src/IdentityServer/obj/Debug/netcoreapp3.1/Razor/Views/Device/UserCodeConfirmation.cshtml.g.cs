#pragma checksum "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e0f3776e6e275fb14c9e32db32e73ed443cc7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Device_UserCodeConfirmation), @"mvc.1.0.view", @"/Views/Device/UserCodeConfirmation.cshtml")]
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
#line 1 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\_ViewImports.cshtml"
using IdentityServer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e0f3776e6e275fb14c9e32db32e73ed443cc7e", @"/Views/Device/UserCodeConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf452908527b88b10d0dce3da0d69e0799b5f0fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Device_UserCodeConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServer.Device.DeviceAuthorizationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Callback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <div class=\"row page-header\">\r\n        <div class=\"col-sm-10\">\r\n");
#nullable restore
#line 6 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"client-logo\"><img");
            BeginWriteAttribute("src", " src=\"", 263, "\"", 289, 1);
#nullable restore
#line 8 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 269, Model.ClientLogoUrl, 269, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 9 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>\r\n                ");
#nullable restore
#line 11 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <small>is requesting your permission</small>\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
     if (Model.ConfirmUserCode)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-8\">\r\n                <p>\r\n                    Please confirm that the authorization request quotes the code: \"");
#nullable restore
#line 22 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                                                                               Write(Model.UserCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\".\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14e0f3776e6e275fb14c9e32db32e73ed443cc7e8165", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14e0f3776e6e275fb14c9e32db32e73ed443cc7e9297", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14e0f3776e6e275fb14c9e32db32e73ed443cc7e9571", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserCode);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                                                   WriteLiteral(Model.UserCode);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                <div>Uncheck the permissions you do not wish to grant.</div>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
#nullable restore
#line 45 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14e0f3776e6e275fb14c9e32db32e73ed443cc7e13187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 47 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 51 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Application Access
                        </div>
                        <ul class=""list-group"">
");
#nullable restore
#line 61 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14e0f3776e6e275fb14c9e32db32e73ed443cc7e16484", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 63 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 67 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"consent-remember\">\r\n                        <label>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14e0f3776e6e275fb14c9e32db32e73ed443cc7e19197", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 73 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <strong>Remember My Decision</strong>\r\n                        </label>\r\n                    </div>\r\n");
#nullable restore
#line 77 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"consent-buttons\">\r\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\r\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\r\n");
#nullable restore
#line 82 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                BeginWriteAttribute("href", " href=\"", 3282, "\"", 3305, 1);
#nullable restore
#line 84 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
WriteAttributeValue("", 3289, Model.ClientUrl, 3289, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <span class=\"glyphicon glyphicon-info-sign\"></span>\r\n                            <strong>");
#nullable restore
#line 86 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                               Write(Model.ClientName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                        </a>\r\n");
#nullable restore
#line 88 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Device\UserCodeConfirmation.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServer.Device.DeviceAuthorizationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
