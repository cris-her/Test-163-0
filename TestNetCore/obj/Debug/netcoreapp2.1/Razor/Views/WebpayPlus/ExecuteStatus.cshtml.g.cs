#pragma checksum "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03319a62f462f8a23fed30778479706bbe0ec686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WebpayPlus_ExecuteStatus), @"mvc.1.0.view", @"/Views/WebpayPlus/ExecuteStatus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WebpayPlus/ExecuteStatus.cshtml", typeof(AspNetCore.Views_WebpayPlus_ExecuteStatus))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03319a62f462f8a23fed30778479706bbe0ec686", @"/Views/WebpayPlus/ExecuteStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43ce0a22185a80202addd3720efffa1a41cba62", @"/Views/_ViewImports.cshtml")]
    public class Views_WebpayPlus_ExecuteStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml"
  
    ViewBag.Title = "Webpay Plus";

#line default
#line hidden
            BeginContext(43, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(50, 13, false);
#line 5 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(63, 308, true);
            WriteLiteral(@"</h2>
<h4>Transaction.Status</h4>

<h4>Request:</h4>
<pre style=""background-color: lightyellow;"">
POST: https://webpay3gint.transbank.cl/rswebpaytransaction/api/webpay/v1.0/transactions/<span id=""token""></span>/refunds
<code class=""json"">
    {}
</code>
</pre>

<h4>Response:</h4>
<pre>
<code>
");
            EndContext();
            BeginContext(372, 25, false);
#line 19 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml"
Write(ViewBag.Result.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(397, 21, true);
            WriteLiteral("\r\n</code>\r\n</pre>\r\n\r\n");
            EndContext();
#line 23 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml"
 if (ViewBag.Result.ResponseCode == 0)
{

#line default
#line hidden
            BeginContext(461, 41, true);
            WriteLiteral("    <p>Solicitud de estado exitoso.</p>\r\n");
            EndContext();
#line 26 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(514, 57, true);
            WriteLiteral("    <p>Error al solicitar estado de la transacción.</p>\r\n");
            EndContext();
#line 30 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml"
}

#line default
#line hidden
            BeginContext(574, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(577, 123, false);
#line 32 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\WebpayPlus\ExecuteStatus.cshtml"
Write(Html.ActionLink("Volver al inicio", "Index", "Home", null, new { @class = "btn btn-primary", style = "margin-top: 20px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(700, 140, true);
            WriteLiteral("\r\n\r\n<script>\r\n    var token = window.localStorage.getItem(\"savedToken\");\r\n    document.getElementById(\"token\").innerHTML = token;\r\n</script>");
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