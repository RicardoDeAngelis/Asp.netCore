#pragma checksum "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\Shared\ClienteSimple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d127a597c03087b3a5376f36bb88d629f03cfe98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ClienteSimple), @"mvc.1.0.view", @"/Views/Shared/ClienteSimple.cshtml")]
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
#line 1 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\_ViewImports.cshtml"
using Asp.netCoreClientes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\_ViewImports.cshtml"
using Asp.netCoreClientes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d127a597c03087b3a5376f36bb88d629f03cfe98", @"/Views/Shared/ClienteSimple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2547a5eadb3b591343e293f36adead5a2b64674d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ClienteSimple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClienteModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- vista paarcial -->\r\n");
            WriteLiteral(@"
 <div class=""text-center"">
    
<table class=""table table-dark table-hover "">
<thead>
        <tr>
            <th scope=""col"">ClienteId</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Apellido</th>
            <th scope=""col"">Dni</th>
            <th scope=""col"">Localidad</th>
            <th scope=""col"">Telefono</th>

        </tr>
    </thead>
    <tbody>
    <tr>
        <th>");
#nullable restore
#line 20 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\Shared\ClienteSimple.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n    <th>");
#nullable restore
#line 21 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\Shared\ClienteSimple.cshtml"
   Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <th>");
#nullable restore
#line 22 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\Shared\ClienteSimple.cshtml"
   Write(Model.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n    <th>");
#nullable restore
#line 23 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\Shared\ClienteSimple.cshtml"
   Write(Model.Dni);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n    <th>");
#nullable restore
#line 24 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\Shared\ClienteSimple.cshtml"
   Write(Model.Localidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n    <th>");
#nullable restore
#line 25 "c:\Users\Ricardo\Documents\Platzi\BackeEnd\Asp.netCoreClientes\Views\Shared\ClienteSimple.cshtml"
   Write(Model.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n\r\n\r\n    </tr>\r\n    \r\n\r\n    </tbody>\r\n</table>\r\n    \r\n\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d127a597c03087b3a5376f36bb88d629f03cfe985558", async() => {
                WriteLiteral("\r\n         <input class=\"btn btn-primary\" type=\"submit\" value=\"volver a la lista\"/>\r\n         ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   </div>\r\n\r\n    \r\n</div>\r\n\r\n      ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClienteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
