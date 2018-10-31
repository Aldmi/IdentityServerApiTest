#pragma checksum "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f5349823169db04ec271958ded1ae1c428c10c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
using IdentityServerApi_AspNetIdentity.Quickstart.Home;

#line default
#line hidden
#line 2 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f5349823169db04ec271958ded1ae1c428c10c", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServerApi_AspNetIdentity.Quickstart.Home.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(196, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = host.IsDevelopment() ? Model?.Error?.ErrorDescription : null;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            BeginContext(374, 232, true);
            WriteLiteral("\n<div class=\"error-page\">\n    <div class=\"page-header\">\n        <h1>Error</h1>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-6\">\n            <div class=\"alert alert-danger\">\n                Sorry, there was an error\n\n");
            EndContext();
#line 22 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
            BeginContext(660, 88, true);
            WriteLiteral("                    <strong>\n                        <em>\n                            : ");
            EndContext();
            BeginContext(749, 5, false);
#line 26 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
                         Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(754, 61, true);
            WriteLiteral("\n                        </em>\n                    </strong>\n");
            EndContext();
#line 29 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
            BeginContext(888, 29, true);
            WriteLiteral("                        <div>");
            EndContext();
            BeginContext(918, 16, false);
#line 32 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
            EndContext();
            BeginContext(934, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 33 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(981, 20, true);
            WriteLiteral("            </div>\n\n");
            EndContext();
#line 37 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
            BeginContext(1052, 52, true);
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
            EndContext();
            BeginContext(1105, 10, false);
#line 39 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 40 "D:\Dropbox\C#\ASP NET Core\IdentityServerTest_1.2 (With ASP.NET Identity)2\IdentityServerApi_AspNetIdentity\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
            BeginContext(1136, 33, true);
            WriteLiteral("        </div>\n    </div>\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment host { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServerApi_AspNetIdentity.Quickstart.Home.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591