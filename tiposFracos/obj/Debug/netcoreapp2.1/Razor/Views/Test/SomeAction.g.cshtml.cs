#pragma checksum "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa62bbfd22aedab845adf2f605925762bf07862a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_SomeAction), @"mvc.1.0.view", @"/Views/Test/SomeAction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/SomeAction.cshtml", typeof(AspNetCore.Views_Test_SomeAction))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa62bbfd22aedab845adf2f605925762bf07862a", @"/Views/Test/SomeAction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8fb9b25cb6276eb9ecfba38e41b06e8391cbf28", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_SomeAction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml"
  
    // Since Address isn't a string, it requires a cast.
    var address = ViewData["Address"] as Address;

#line default
#line hidden
            BeginContext(112, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(114, 20, false);
#line 6 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml"
Write(ViewData["Greeting"]);

#line default
#line hidden
            EndContext();
            BeginContext(134, 23, true);
            WriteLiteral(" World!\n\n<address>\n    ");
            EndContext();
            BeginContext(158, 12, false);
#line 9 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml"
Write(address.Name);

#line default
#line hidden
            EndContext();
            BeginContext(170, 9, true);
            WriteLiteral("<br>\n    ");
            EndContext();
            BeginContext(180, 14, false);
#line 10 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml"
Write(address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(194, 9, true);
            WriteLiteral("<br>\n    ");
            EndContext();
            BeginContext(204, 12, false);
#line 11 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml"
Write(address.City);

#line default
#line hidden
            EndContext();
            BeginContext(216, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(219, 13, false);
#line 11 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml"
              Write(address.State);

#line default
#line hidden
            EndContext();
            BeginContext(232, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(234, 18, false);
#line 11 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/SomeAction.cshtml"
                             Write(address.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(252, 17, true);
            WriteLiteral(" <br>\n</address>\n");
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
