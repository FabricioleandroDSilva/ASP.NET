#pragma checksum "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a91447a47b0b345a000adf74e4df4dd0f04ed46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albuns_Index), @"mvc.1.0.view", @"/Views/Albuns/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albuns/Index.cshtml", typeof(AspNetCore.Views_Albuns_Index))]
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
#line 1 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\_ViewImports.cshtml"
using AlbumFotos;

#line default
#line hidden
#line 2 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\_ViewImports.cshtml"
using AlbumFotos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a91447a47b0b345a000adf74e4df4dd0f04ed46", @"/Views/Albuns/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ac944a79a00de3bd3cee4c30cb2ebd97da91e27", @"/Views/_ViewImports.cshtml")]
    public class Views_Albuns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlbumFotos.Models.Album>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-ligh btn-small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small blue darken-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small orange darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
  
    ViewData["Title"] = "Albuns";

#line default
#line hidden
            BeginContext(89, 87, true);
            WriteLiteral("\r\n\r\n<div class=\"listaDestinos\">\r\n    <div class=\"container\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(176, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1c995b8888a4b888200a67f6ea14ae5", async() => {
                BeginContext(241, 11, true);
                WriteLiteral("Novo album ");
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
            BeginContext(256, 181, true);
            WriteLiteral("\r\n        </p>\r\n        <table class=\"table striped highlight hover responsive-table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(438, 43, false);
#line 17 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Destino));

#line default
#line hidden
            EndContext();
            BeginContext(481, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(561, 42, false);
#line 20 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Inicio));

#line default
#line hidden
            EndContext();
            BeginContext(603, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(683, 39, false);
#line 23 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Fim));

#line default
#line hidden
            EndContext();
            BeginContext(722, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(913, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(998, 42, false);
#line 33 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Destino));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1132, 41, false);
#line 36 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Inicio));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1265, 38, false);
#line 39 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Fim));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1394, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c98d42106ba4b6c8595e906b8cb7f56", async() => {
                BeginContext(1477, 9, true);
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
#line 42 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                                                   WriteLiteral(item.AlbumId);

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
            BeginContext(1490, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1522, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b99cc62077744c6eada36947e07eb158", async() => {
                BeginContext(1609, 5, true);
                WriteLiteral("Fotos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                                                      WriteLiteral(item.AlbumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1618, 100, true);
            WriteLiteral(" |\r\n                            <a class=\"btn-small red darken-4 modal-trigger\" data-target=\"modal1\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1718, "\"", 1750, 3);
            WriteAttributeValue("", 1728, "Excluir(", 1728, 8, true);
#line 44 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
WriteAttributeValue("", 1736, item.AlbumId, 1736, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1749, ")", 1749, 1, true);
            EndWriteAttribute();
            BeginContext(1751, 72, true);
            WriteLiteral(">Excluir</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Computador\Documents\Curso AspnetCore\AlbumFotos\AlbumFotos\Views\Albuns\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1842, 910, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmar exclusão</h4>
        <p>Deseja prosseguir com a exclusão </p>
    </div>
    <div class=""modal-footer"">
        <a class=""modal-close waves-effect waves-green btn-flat btn-Confirmar"">Sim </a>
        <a  class=""modal-close waves-effect waves-green btn-flat"">Não</a>

    </div>
</div>

<script>
    function Excluir(AlbumId){
        $("".modal"").modal();

        $("".btn-Confirmar"").on('click', function () {
            $.ajax({
                url: '/Albuns/Delete',
                type:'POST',
                data: { AlbumId: AlbumId },
                success: function () {
                    location.reload();
                    $("".modal"").modal('close');

                }
            })

        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlbumFotos.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591