#pragma checksum "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/OutraAcao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24ea057423d4078f1dd33529f81b2bd26f4e2c8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_OutraAcao), @"mvc.1.0.view", @"/Views/Test/OutraAcao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/OutraAcao.cshtml", typeof(AspNetCore.Views_Test_OutraAcao))]
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
#line 1 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/_ViewImports.cshtml"
using tiposFracos;

#line default
#line hidden
#line 2 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/_ViewImports.cshtml"
using tiposFracos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ea057423d4078f1dd33529f81b2bd26f4e2c8e", @"/Views/Test/OutraAcao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8fb9b25cb6276eb9ecfba38e41b06e8391cbf28", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_OutraAcao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1, 16, false);
#line 1 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/OutraAcao.cshtml"
Write(ViewBag.Greeting);

#line default
#line hidden
            EndContext();
            BeginContext(17, 23, true);
            WriteLiteral(" Mundo!\n\n<address>\n    ");
            EndContext();
            BeginContext(41, 20, false);
#line 4 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/OutraAcao.cshtml"
Write(ViewBag.Address.Name);

#line default
#line hidden
            EndContext();
            BeginContext(61, 9, true);
            WriteLiteral("<br>\n    ");
            EndContext();
            BeginContext(71, 22, false);
#line 5 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/OutraAcao.cshtml"
Write(ViewBag.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(93, 9, true);
            WriteLiteral("<br>\n    ");
            EndContext();
            BeginContext(103, 20, false);
#line 6 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/OutraAcao.cshtml"
Write(ViewBag.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(123, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(126, 21, false);
#line 6 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/OutraAcao.cshtml"
                      Write(ViewBag.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(147, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(149, 26, false);
#line 6 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/OutraAcao.cshtml"
                                             Write(ViewBag.Address.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(175, 12, true);
            WriteLiteral("\n</address>\n");
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
