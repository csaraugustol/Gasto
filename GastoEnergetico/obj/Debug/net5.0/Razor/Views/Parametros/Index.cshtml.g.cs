#pragma checksum "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e84d9998fc5eada3dab945fc39b68402cd4b6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parametros_Index), @"mvc.1.0.view", @"/Views/Parametros/Index.cshtml")]
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
#line 1 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\_ViewImports.cshtml"
using GastoEnergetico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\_ViewImports.cshtml"
using GastoEnergetico.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
using GastoEnergetico.ViewModel.Parametros;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e84d9998fc5eada3dab945fc39b68402cd4b6b", @"/Views/Parametros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde47198d0312cec28c18c60341ee7adb9588c30", @"/Views/_ViewImports.cshtml")]
    public class Views_Parametros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GastoEnergetico.ViewModel.Parametros.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
  
    ViewData["Title"] = "Parâmetros";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<a href=""/Parametros/Adicionar"">Adicionar Parâmetro</a>

<table class=""table table-hover"">
  <thead>
    <tr class="" text-center"">
      <th scope=""col"">#</th>
      <th scope=""col"">Valor R$/kWh</th>
      <th scope=""col"">Faixa Consumo Alto</th>
      <th scope=""col"">Faixa Consumo Médio</th>
      <th scope=""col"">Ações</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 22 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
     foreach (Parametro p in @Model.Parametros)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr class=\"text-center\">\r\n        <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
                   Write(p.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
       Write(p.ValorKwh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
       Write(p.FaixaConsumoAlto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
       Write(p.FaixaConsumoMedio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 811, "\"", 842, 2);
            WriteAttributeValue("", 818, "/Parametros/Editar/", 818, 19, true);
#nullable restore
#line 30 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
WriteAttributeValue("", 837, p.Id, 837, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 868, "\"", 900, 2);
            WriteAttributeValue("", 875, "/Parametros/Remover/", 875, 20, true);
#nullable restore
#line 31 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
WriteAttributeValue("", 895, p.Id, 895, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a>\r\n        </td>\r\n      </tr>\r\n");
#nullable restore
#line 34 "C:\Users\cesar\Documents\ADS\PWA\GastoEnergetico\GastoEnergetico\Views\Parametros\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GastoEnergetico.ViewModel.Parametros.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
