#pragma checksum "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b7682fff5eccd7711502318d464b2eda48d805"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
#line 1 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
using IdentityServerApi_AspNetIdentity.Quickstart.Consent;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b7682fff5eccd7711502318d464b2eda48d805", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityServerApi_AspNetIdentity.Quickstart.Consent.ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(135, 94, true);
            WriteLiteral("\n<div class=\"page-consent\">\n    <div class=\"row page-header\">\n        <div class=\"col-sm-10\">\n");
            EndContext();
#line 7 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(289, 45, true);
            WriteLiteral("                <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 334, "\"", 360, 1);
#line 9 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
WriteAttributeValue("", 340, Model.ClientLogoUrl, 340, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(361, 8, true);
            WriteLiteral("></div>\n");
            EndContext();
#line 10 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(383, 33, true);
            WriteLiteral("            <h1>\n                ");
            EndContext();
            BeginContext(417, 16, false);
#line 12 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(433, 172, true);
            WriteLiteral("\n                <small>is requesting your permission</small>\n            </h1>\n        </div>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-8\">\n            ");
            EndContext();
            BeginContext(606, 34, false);
#line 20 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
       Write(Html.Partial("_ValidationSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(640, 14, true);
            WriteLiteral("\n\n            ");
            EndContext();
            BeginContext(654, 2571, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467e5034f4334143a2026043140efde7", async() => {
                BeginContext(700, 17, true);
                WriteLiteral("\n                ");
                EndContext();
                BeginContext(717, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9dd7d1d2a0f3443f9716782d4c8de1f4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 23 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(760, 96, true);
                WriteLiteral("\n\n                <div>Uncheck the permissions you do not wish to grant.</div>\n                \n");
                EndContext();
#line 27 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(923, 325, true);
                WriteLiteral(@"                    <div class=""panel panel-default consent-buttons"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-user""></span>
                            Personal Information
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 35 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.IdentityScopes)
                            {
                                

#line default
#line hidden
                BeginContext(1384, 37, false);
#line 37 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                           Write(Html.Partial("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 37 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                                                                      
                            }

#line default
#line hidden
                BeginContext(1452, 57, true);
                WriteLiteral("                        </ul>\n                    </div>\n");
                EndContext();
#line 41 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1527, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 43 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(1595, 308, true);
                WriteLiteral(@"                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <span class=""glyphicon glyphicon-tasks""></span>
                            Application Access
                        </div>
                        <ul class=""list-group"">
");
                EndContext();
#line 51 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                             foreach (var scope in Model.ResourceScopes)
                            {
                                

#line default
#line hidden
                BeginContext(2039, 37, false);
#line 53 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                           Write(Html.Partial("_ScopeListItem", scope));

#line default
#line hidden
                EndContext();
#line 53 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                                                                      
                            }

#line default
#line hidden
                BeginContext(2107, 57, true);
                WriteLiteral("                        </ul>\n                    </div>\n");
                EndContext();
#line 57 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2182, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 59 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
                BeginContext(2250, 111, true);
                WriteLiteral("                    <div class=\"consent-remember\">\n                        <label>\n                            ");
                EndContext();
                BeginContext(2361, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e27c0663577470f9165694e71014182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 63 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2423, 127, true);
                WriteLiteral("\n                            <strong>Remember My Decision</strong>\n                        </label>\n                    </div>\n");
                EndContext();
#line 67 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2568, 246, true);
                WriteLiteral("\n                <div class=\"consent-buttons\">\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\n");
                EndContext();
#line 72 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
                BeginContext(2886, 77, true);
                WriteLiteral("                        <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2963, "\"", 2986, 1);
#line 74 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
WriteAttributeValue("", 2970, Model.ClientUrl, 2970, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2987, 118, true);
                WriteLiteral(">\n                            <span class=\"glyphicon glyphicon-info-sign\"></span>\n                            <strong>");
                EndContext();
                BeginContext(3106, 16, false);
#line 76 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                               Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(3122, 39, true);
                WriteLiteral("</strong>\n                        </a>\n");
                EndContext();
#line 78 "D:\Git\IdentityServerApiTest\src\IdentityServerApi_AspNetIdentity\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3183, 35, true);
                WriteLiteral("                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3225, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityServerApi_AspNetIdentity.Quickstart.Consent.ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
