#pragma checksum "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bc73ce9a5094380a62321108c7c1bca314c3529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Index), @"mvc.1.0.view", @"/Views/Categorias/Index.cshtml")]
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
#line 1 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\_ViewImports.cshtml"
using GastoEnergetico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\_ViewImports.cshtml"
using GastoEnergetico.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
using GastoEnergetico.ViewModel.Categorias;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bc73ce9a5094380a62321108c7c1bca314c3529", @"/Views/Categorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f37fcba8d5732cf212e8b03fa7444394b7f0a779", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GastoEnergetico.ViewModel.Categorias.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
  
    ViewData["Title"] = "Categorias";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<a href=""Categorias/Adicionar"">Adicionar Categoria</a>

<table class=""table table-hover"">
  <thead>
    <tr class=""text-center"">
      <th scope=""col"">#</th>
      <th scope=""col"">Descrição</th>
      <th scope=""col"">Id Categoria</th>
      <th scope=""col"">Ações</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 21 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
     foreach (Categoria c in @Model.Categorias)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr class=\"text-center\">\n        <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
                   Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <td>");
#nullable restore
#line 25 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
       Write(c.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 26 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
       Write(c.CategoriaPaiId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n          <a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 716, 2);
            WriteAttributeValue("", 692, "/Categorias/Editar/", 692, 19, true);
#nullable restore
#line 28 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 711, c.Id, 711, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\n          <a");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 773, 2);
            WriteAttributeValue("", 748, "/Categorias/Remover/", 748, 20, true);
#nullable restore
#line 29 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
WriteAttributeValue("", 768, c.Id, 768, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a>\n        </td>\n      </tr>\n");
#nullable restore
#line 32 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n  </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GastoEnergetico.ViewModel.Categorias.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
