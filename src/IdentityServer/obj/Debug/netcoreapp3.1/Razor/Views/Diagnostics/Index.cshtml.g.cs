#pragma checksum "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f242bdecbbd197107afe6aa252256ef1a355e96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diagnostics_Index), @"mvc.1.0.view", @"/Views/Diagnostics/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f242bdecbbd197107afe6aa252256ef1a355e96", @"/Views/Diagnostics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf452908527b88b10d0dce3da0d69e0799b5f0fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Diagnostics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiagnosticsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Authentication cookie</h1>\r\n\r\n<h3>Claims</h3>\r\n<dl>\r\n");
#nullable restore
#line 7 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
     foreach (var claim in Model.AuthenticateResult.Principal.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 9 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 10 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 11 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n<h3>Properties</h3>\r\n<dl>\r\n");
#nullable restore
#line 16 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
     foreach (var prop in Model.AuthenticateResult.Properties.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 18 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
       Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 19 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
       Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 20 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
 if (Model.Clients.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Clients</h3>\r\n    <ul>\r\n");
#nullable restore
#line 27 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
         foreach (var client in Model.Clients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 29 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
           Write(client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 30 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 32 "C:\Users\Danny\source\otherRepos\netcoreIdentitySamples\firstQuick\src\identityserver\Views\Diagnostics\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiagnosticsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
