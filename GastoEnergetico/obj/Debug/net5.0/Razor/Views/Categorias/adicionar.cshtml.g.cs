#pragma checksum "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\adicionar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93cb2f9ba9cca3bcefd305887e0e0a9cef05d80e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_adicionar), @"mvc.1.0.view", @"/Views/Categorias/adicionar.cshtml")]
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
#line 1 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\adicionar.cshtml"
using GastoEnergetico.ViewModel.Categorias;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93cb2f9ba9cca3bcefd305887e0e0a9cef05d80e", @"/Views/Categorias/adicionar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f37fcba8d5732cf212e8b03fa7444394b7f0a779", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_adicionar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GastoEnergetico.ViewModel.Categorias.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Categorias/Adicionar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\adicionar.cshtml"
  
    ViewData["Title"] = "Adicionar Categoria";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\Pedro\Desktop\Nova pasta (4)\GastoEnergetico-3a9eba73def21a225c8ae1e7f12f56fd7f1f714f\GastoEnergetico\Views\Categorias\adicionar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<a href=\"/Categorias\">Voltar</a>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93cb2f9ba9cca3bcefd305887e0e0a9cef05d80e5395", async() => {
                WriteLiteral(@"
    
    <div class=""form-group row"">
        <label for=""ValorKwh"" class=""col-sm-2 col-form-label"">Decrição</label>
        <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" id=""Descricao"" name=""Descricao"" placeholder=""Descrição"">
        </div>
    </div>
    
    <div class=""form-group row"">
            <label for=""ValorKwh"" class=""col-sm-2 col-form-label"">Identificador</label>
            <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" id=""CategoriaPaiId"" name=""CategoriaPaiId"" placeholder=""Identificador Categoria"">
            </div>
        </div>
  
    <div class=""form-group row"">
        <div class=""col-sm-10"">
            <button type=""submit"" class=""btn btn-primary"">Salvar</button>
        </div>
    </div>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
