#pragma checksum "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b9f7f755e07e7561bb1a33769f6a6b42187fffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebpayPlus_NormalCreate), @"mvc.1.0.view", @"/Views/WebpayPlus/NormalCreate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WebpayPlus/NormalCreate.cshtml", typeof(AspNetCore.Views_WebpayPlus_NormalCreate))]
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
#line 1 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\_ViewImports.cshtml"
using TestNetCore;

#line default
#line hidden
#line 2 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\_ViewImports.cshtml"
using TestNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b9f7f755e07e7561bb1a33769f6a6b42187fffd", @"/Views/WebpayPlus/NormalCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43ce0a22185a80202addd3720efffa1a41cba62", @"/Views/_ViewImports.cshtml")]
    public class Views_WebpayPlus_NormalCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
  
    ViewBag.Title = "Sitio del comercio";

#line default
#line hidden
            BeginContext(50, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(57, 13, false);
#line 5 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(70, 72, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"container jumbotron w-25 bg-light\">\r\n    <p>Valor: ");
            EndContext();
            BeginContext(143, 14, false);
#line 8 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
         Write(ViewBag.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(157, 30, true);
            WriteLiteral("</p>\r\n    <p>Orden de Compra: ");
            EndContext();
            BeginContext(188, 16, false);
#line 9 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
                   Write(ViewBag.BuyOrder);

#line default
#line hidden
            EndContext();
            BeginContext(204, 10, true);
            WriteLiteral("</p>\r\n    ");
            EndContext();
            BeginContext(214, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa2df61737547faa907cf6b219215f8", async() => {
                BeginContext(263, 46, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"token_ws\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 309, "\"", 333, 1);
#line 11 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
WriteAttributeValue("", 317, ViewBag.TokenWs, 317, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(334, 104, true);
                WriteLiteral(" />\r\n        <a href=\"javascript: document.globalForm.submit();\" class=\"btn btn-primary\">Pagar</a>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 10 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
AddHtmlAttributeValue("", 228, ViewBag.FormAction, 228, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(445, 247, true);
            WriteLiteral("\r\n</div>\r\n\r\n<h4>Transaction.Create</h4>\r\n\r\n<h4>Request:</h4>\r\n<pre style=\"background-color: lightyellow;\">\r\nPOST: https://webpay3gint.transbank.cl/rswebpaytransaction/api/webpay/v1.0/transactions\r\n<code class=\"json\">\r\n    {\r\n        \"buy_order\": \"");
            EndContext();
            BeginContext(693, 16, false);
#line 23 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
                 Write(ViewBag.BuyOrder);

#line default
#line hidden
            EndContext();
            BeginContext(709, 27, true);
            WriteLiteral("\",\r\n        \"session_id\": \"");
            EndContext();
            BeginContext(737, 17, false);
#line 24 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
                  Write(ViewBag.SessionId);

#line default
#line hidden
            EndContext();
            BeginContext(754, 23, true);
            WriteLiteral("\",\r\n        \"amount\": \"");
            EndContext();
            BeginContext(778, 14, false);
#line 25 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
              Write(ViewBag.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(792, 27, true);
            WriteLiteral("\",\r\n        \"return_url\": \"");
            EndContext();
            BeginContext(820, 17, false);
#line 26 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
                  Write(ViewBag.ReturnUrl);

#line default
#line hidden
            EndContext();
            BeginContext(837, 230, true);
            WriteLiteral("\"\r\n    }\r\n</code>\r\n</pre>\r\n<p> Largo máximo de buy_order: 26.</p>\r\n<p> Largo máximo de session_id: 61.</p>\r\n<p> Largo máximo de amount: 17.</p>\r\n<p> Largo máximo de return_url: 256.</p>\r\n<h4>Response:</h4>\r\n<pre>\r\n<code>\r\n    ");
            EndContext();
            BeginContext(1068, 14, false);
#line 37 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\NormalCreate.cshtml"
Write(ViewBag.Result);

#line default
#line hidden
            EndContext();
            BeginContext(1082, 19, true);
            WriteLiteral("\r\n</code>\r\n</pre>\r\n");
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