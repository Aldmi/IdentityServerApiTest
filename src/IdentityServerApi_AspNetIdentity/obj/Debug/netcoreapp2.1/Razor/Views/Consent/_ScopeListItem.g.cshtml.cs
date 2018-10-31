#pragma checksum "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a0b37daefa8efb59911d8989f6d9505b88cbb3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent__ScopeListItem), @"mvc.1.0.view", @"/Views/Consent/_ScopeListItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/_ScopeListItem.cshtml", typeof(AspNetCore.Views_Consent__ScopeListItem))]
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
#line 1 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
using IdentityServerApi_AspNetIdentity.Quickstart.Consent;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0b37daefa8efb59911d8989f6d9505b88cbb3d", @"/Views/Consent/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServerApi_AspNetIdentity.Quickstart.Consent.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(133, 152, true);
            WriteLiteral("\n<li class=\"list-group-item\">\n    <label>\n        <input class=\"consent-scopecheck\"\n               type=\"checkbox\"\n               name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("id", "\n               id=\"", 285, "\"", 323, 2);
            WriteAttributeValue("", 305, "scopes_", 305, 7, true);
#line 9 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 312, Model.Name, 312, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\n               value=\"", 324, "\"", 358, 1);
#line 10 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 347, Model.Name, 347, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\n               checked=\"", 359, "\"", 398, 1);
#line 11 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 384, Model.Checked, 384, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\n               disabled=\"", 399, "\"", 440, 1);
#line 12 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 425, Model.Required, 425, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(441, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 13 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
            BeginContext(484, 74, true);
            WriteLiteral("            <input type=\"hidden\"\n                   name=\"ScopesConsented\"");
            EndContext();
            BeginWriteAttribute("value", "\n                   value=\"", 558, "\"", 596, 1);
#line 17 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 585, Model.Name, 585, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(597, 4, true);
            WriteLiteral(" />\n");
            EndContext();
#line 18 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(611, 16, true);
            WriteLiteral("        <strong>");
            EndContext();
            BeginContext(628, 17, false);
#line 19 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(645, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
#line 20 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
            BeginContext(695, 71, true);
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\n");
            EndContext();
#line 23 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
            BeginContext(776, 13, true);
            WriteLiteral("    </label>\n");
            EndContext();
#line 25 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
            BeginContext(820, 41, true);
            WriteLiteral("        <span><em>(required)</em></span>\n");
            EndContext();
#line 28 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(867, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 29 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
            BeginContext(909, 60, true);
            WriteLiteral("        <div class=\"consent-description\">\n            <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 969, "\"", 993, 2);
            WriteAttributeValue("", 975, "scopes_", 975, 7, true);
#line 32 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 982, Model.Name, 982, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(994, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(996, 17, false);
#line 32 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1013, 24, true);
            WriteLiteral("</label>\n        </div>\n");
            EndContext();
#line 34 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
            BeginContext(1043, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServerApi_AspNetIdentity.Quickstart.Consent.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
