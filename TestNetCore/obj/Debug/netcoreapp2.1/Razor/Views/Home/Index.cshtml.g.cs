#pragma checksum "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76993ae66aa5b8bab21af49e2b6fa5cf70bb86cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76993ae66aa5b8bab21af49e2b6fa5cf70bb86cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43ce0a22185a80202addd3720efffa1a41cba62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c92db3b0cf864857a7fb25f8f8d6656a", async() => {
                BeginContext(31, 143, true);
                WriteLiteral("\r\n    <style>\r\n        table, th, td {\r\n            border: 1px solid black;\r\n            border-collapse: collapse;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(181, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(185, 2847, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c689b34a5b344468778b2c05e0b7b7b", async() => {
                BeginContext(191, 502, true);
                WriteLiteral(@"
    <h1>Webpay Plus POC (.NET Core)</h1>
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Servicio</th>
                <th scope=""col"">Crear</th>
                <th scope=""col"">Reembolsar</th>
                <th scope=""col"">Estado</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    Webpay Plus
                </td>
                <td>
                    ");
                EndContext();
                BeginContext(694, 66, false);
#line 29 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Crear Transacción", "NormalCreate", "WebpayPlus"));

#line default
#line hidden
                EndContext();
                BeginContext(760, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(828, 71, false);
#line 32 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Reembolsar Transacción", "NormalRefund", "WebpayPlus"));

#line default
#line hidden
                EndContext();
                BeginContext(899, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(967, 73, false);
#line 35 "C:\Projects\TestNetCore\TestNetCore\TestNetCore\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Estado de la Transacción", "NormalStatus", "WebpayPlus"));

#line default
#line hidden
                EndContext();
                BeginContext(1040, 1985, true);
                WriteLiteral(@"
                </td>
            </tr>
        </tbody>
    </table>
    <table>
        <thead>
            <tr>
                <th>Tipo de tarjeta</th>
                <th>Detalle</th>
                <th>Resultado</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>VISA</td>
                <td>4051 8856 0044 6623<br>CVV 123<br>cualquier fecha de expiración</td>
                <td>Genera transacciones <strong>aprobadas</strong>.</td>
            </tr>
            <tr>
                <td>AMEX</td>
                <td>3700 0000 0002 032<br> CVV 1234<br>cualquier fecha de expiración</td>
                <td>Genera transacciones <strong>aprobadas</strong>.</td>
            </tr>
            <tr>
                <td>MASTERCARD</td>
                <td>5186 0595 5959 0568<br> CVV 123<br>cualquier fecha de expiración</td>
                <td>Genera transacciones <strong>rechazadas</strong>.</td>
            </tr>
            <tr>
        ");
                WriteLiteral(@"        <td>Redcompra</td>
                <td>4051 8842 3993 7763</td>
                <td>Genera transacciones <strong>aprobadas</strong> (para operaciones que permiten débito Redcompra y prepago)</td>
            </tr>
            <tr>
                <td>Redcompra</td>
                <td>4511 3466 6003 7060</td>
                <td>Genera transacciones <strong>aprobadas</strong> (para operaciones que permiten débito Redcompra y prepago)</td>
            </tr>
            <tr>
                <td>Redcompra</td>
                <td>5186 0085 4123 3829</td>
                <td>Genera transacciones <strong>rechazadas</strong> (para operaciones que permiten débito Redcompra y prepago)</td>
            </tr>
        </tbody>

    </table>
    <p></p>
    <p>
        Cuando aparece un formulario de autenticación con RUT y clave, se debe
        usar el RUT <strong>11.111.111-1</strong> y la clave <strong>123</strong>.
    </p>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3032, 9, true);
            WriteLiteral("\r\n</html>");
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
