#pragma checksum "C:\Users\yanna\Documents\Senac\C#\Atividade 1 UC06\projetohotsite\Views\Home\_ModalCadastroFalha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8acfaa34385fff46e87174c7231c11c2f7f4a77f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ModalCadastroFalha), @"mvc.1.0.view", @"/Views/Home/_ModalCadastroFalha.cshtml")]
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
#line 1 "C:\Users\yanna\Documents\Senac\C#\Atividade 1 UC06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yanna\Documents\Senac\C#\Atividade 1 UC06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8acfaa34385fff46e87174c7231c11c2f7f4a77f", @"/Views/Home/_ModalCadastroFalha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ModalCadastroFalha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""modalCadastroFalha"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content p-3 rounded"">
            <div class=""modal-header border-0"">
                <h5 class=""modal-title col-10 offset-1 text-center"">Falha!</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body text-center"">
                <h6>Ocorreu uma falha e não foi possível registrar seu contato, tente novamente mais tarde.</h6>
            </div>
            <div class=""modal-footer border-0"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Ok</button>
            </div>
        </div>
    </div>
</div>");
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