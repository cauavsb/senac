#pragma checksum "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b315bf257a1d284226488328b8ced70bcb290df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Listagem), @"mvc.1.0.view", @"/Views/Produto/Listagem.cshtml")]
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
#line 1 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\_ViewImports.cshtml"
using atividade_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\_ViewImports.cshtml"
using atividade_4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b315bf257a1d284226488328b8ced70bcb290df1", @"/Views/Produto/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae71da61d3158e993342fc2ffa531d87ed2d7be", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <table class=""table"">

        <thead>
            <tr>
                <th>produto</th>
                <th>tamanho</th>
                <th>sexo</th>
                <th>quantidade_estoque</th>
                <th>quantidade_venda</th>
                <th>valor_unitario</th>
                <th>valor_venda</th>
                <td>Manutenção</td>
            </tr>
        </thead>

");
#nullable restore
#line 18 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
         foreach (Produto p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
               Write(p.produto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
               Write(p.tamanho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
               Write(p.sexo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
               Write(p.quantidade_estoque);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
               Write(p.quantidade_venda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
               Write(p.valor_unitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
               Write(p.valor_venda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 860, 2);
            WriteAttributeValue("", 836, "/Produto/Editar?id=", 836, 19, true);
#nullable restore
#line 29 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
WriteAttributeValue("", 855, p.id, 855, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> / <a");
            BeginWriteAttribute("href", " href=\"", 877, "\"", 909, 2);
            WriteAttributeValue("", 884, "/Produto/Deletar?id=", 884, 20, true);
#nullable restore
#line 29 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
WriteAttributeValue("", 904, p.id, 904, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Deletar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Mundial do Palmeiras\Music\atividade_4\Views\Produto\Listagem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591