#pragma checksum "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe731a9de8a5f746f8213b7acc42505582e801f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoriasExercicios_Index), @"mvc.1.0.view", @"/Views/CategoriasExercicios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CategoriasExercicios/Index.cshtml", typeof(AspNetCore.Views_CategoriasExercicios_Index))]
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
#line 1 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia;

#line default
#line hidden
#line 2 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fe731a9de8a5f746f8213b7acc42505582e801f", @"/Views/CategoriasExercicios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoriasExercicios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FichaAcademia.Dominio.Models.CategoriaExercicio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small green darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn-small light-blue darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
  
    ViewData["Title"] = "Nova categoria de exericio";

#line default
#line hidden
            BeginContext(133, 50, true);
            WriteLiteral("\r\n<h5>Nova categoria de exericio</h5>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(183, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "240967e157f64d9095007f8a271275da", async() => {
                BeginContext(239, 15, true);
                WriteLiteral(" Nova Categoria");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(258, 116, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table striped hover highlight\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(375, 40, false);
#line 16 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(415, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(550, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(611, 39, false);
#line 26 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(650, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(717, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70cc48011eaa4b73bbfe9998a55b65d9", async() => {
                BeginContext(819, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
                                           WriteLiteral(item.CategoriaExercicioId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(832, 31, true);
            WriteLiteral(" &nbsp;\r\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 863, "\"", 925, 5);
            WriteAttributeValue("", 873, "ExibirModal(", 873, 12, true);
#line 30 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
WriteAttributeValue("", 885, item.CategoriaExercicioId, 885, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 911, ",\'", 911, 2, true);
#line 30 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
WriteAttributeValue("", 913, item.Nome, 913, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 923, "\')", 923, 2, true);
            EndWriteAttribute();
            BeginContext(926, 88, true);
            WriteLiteral(" class=\" btn-small red darken-2\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 33 "C:\Users\falea\Documents\FichaAcademia\FichaAcademia\Views\CategoriasExercicios\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1025, 397, true);
            WriteLiteral(@"    </tbody>
</table>

<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmar exclusão</h4>
        <p>Deseja prosseguir com a exclusão de <b class=""nome""></b> ?</p>
    </div>
    <div class=""modal-footer"">
        <a class=""modal-close btn green accent-4"">Não</a>
        <a class=""modal-close btn red accent-4 btnConfirmar"">Sim</a>
    </div>
</div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1445, 617, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".modal"").modal();
        })
        function ExibirModal(id, nome) {
            $("".nome"").html(nome);
            $(""#modal1"").modal(""open"");
            $("".btnConfirmar"").on('click', function () {
                $.ajax({
                    method: ""POST"",
                    url: ""/CategoriasExercicios/Delete"",
                    data: { id: id },
                    success: function () {
                        location.reload();
                    }
                });
            });
        }

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FichaAcademia.Dominio.Models.CategoriaExercicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
