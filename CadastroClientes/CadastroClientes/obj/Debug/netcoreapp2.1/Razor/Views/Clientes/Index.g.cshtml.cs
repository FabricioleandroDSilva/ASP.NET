#pragma checksum "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abfcdbd16440a4f44c5d3f097b6a163bddb321b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Index), @"mvc.1.0.view", @"/Views/Clientes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clientes/Index.cshtml", typeof(AspNetCore.Views_Clientes_Index))]
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
#line 1 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\_ViewImports.cshtml"
using CadastroClientes;

#line default
#line hidden
#line 2 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\_ViewImports.cshtml"
using CadastroClientes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abfcdbd16440a4f44c5d3f097b6a163bddb321b8", @"/Views/Clientes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f63b3ca325a091ae1aa055db5a24b0368a87562", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CadastroCliente.Models.Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small blue darken-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small light-green darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("115"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
  

    ViewData["Title"] = "Cadastro de Cliente";

#line default
#line hidden
            BeginContext(111, 9, true);
            WriteLiteral("<p>\r\n    ");
            EndContext();
            BeginContext(120, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf41bb6d87ad4fc885c388bb8265210c", async() => {
                BeginContext(175, 4, true);
                WriteLiteral("Novo");
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
            BeginContext(183, 750, true);
            WriteLiteral(@"
</p>
<table class=""table-responsive"" >
    <thead>
        <tr>
            <th>
                Nome
            </th>
            <th>
                Data Nascimento
            </th>
            <th>
                Sexo
            </th>
            <th>
                CEP
            </th>
            <th>
                Endereço
            </th>
            <th>
                Numero
            </th>
            <th>
                Complemento
            </th>
            <th>
                Bairro
            </th>
            <th>
                UF
            </th>
            <th>
                Cidade
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 47 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(982, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1043, 39, false);
#line 51 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1150, 49, false);
#line 54 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataNascimento));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1267, 39, false);
#line 57 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sexo));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1374, 38, false);
#line 60 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1480, 43, false);
#line 63 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Endereço));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1591, 41, false);
#line 66 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1700, 46, false);
#line 69 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1814, 41, false);
#line 72 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1923, 41, false);
#line 75 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2032, 41, false);
#line 78 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2140, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a2c294b259c4882a1f95e15448afa71", async() => {
                BeginContext(2252, 9, true);
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
#line 81 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
                                           WriteLiteral(item.ClienteId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2265, 26, true);
            WriteLiteral(" |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2291, "\"", 2329, 3);
            WriteAttributeValue("", 2301, "ExibirModal(", 2301, 12, true);
#line 82 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
WriteAttributeValue("", 2313, item.ClienteId, 2313, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2328, ")", 2328, 1, true);
            EndWriteAttribute();
            BeginContext(2330, 87, true);
            WriteLiteral(" class=\"btn-small red darken-2\">Excluir</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 85 "C:\Users\falea\OneDrive\FIES\Crnall Prova\CadastroClientes\CadastroClientes\Views\Clientes\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2428, 389, true);
            WriteLiteral(@"    </tbody>
</table>

<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmar exclusão</h4>
        <p>Deseja prosseguir com a exclusão do cliente ? </p>
    </div>
    <div class=""modal-footer"">
        <a class=""modal-close btn green accent-4"">Não</a>
        <a class=""modal-close btn red accent-4 btnConfirmar"">Sim</a>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2840, 607, true);
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
                    url: ""/Clientes/Delete"",
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CadastroCliente.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
