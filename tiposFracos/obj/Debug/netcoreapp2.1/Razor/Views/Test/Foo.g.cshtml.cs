#pragma checksum "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/Foo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44854c6431fbcb5744910576594d07d5d045cd82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Foo), @"mvc.1.0.view", @"/Views/Test/Foo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/Foo.cshtml", typeof(AspNetCore.Views_Test_Foo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44854c6431fbcb5744910576594d07d5d045cd82", @"/Views/Test/Foo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8fb9b25cb6276eb9ecfba38e41b06e8391cbf28", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Foo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 11, true);
            WriteLiteral("<html>\n    ");
            EndContext();
            BeginContext(11, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da55b56ffbe846b29c3d6bad31203fca", async() => {
                BeginContext(17, 16, true);
                WriteLiteral("\n        <title>");
                EndContext();
                BeginContext(34, 17, false);
#line 3 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/Foo.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(51, 14, true);
                WriteLiteral(" </title>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(72, 5, true);
            WriteLiteral("\n    ");
            EndContext();
            BeginContext(77, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7923ba65674e4e1a833d596f6da8b427", async() => {
                BeginContext(83, 13, true);
                WriteLiteral("\n        <h1>");
                EndContext();
                BeginContext(97, 18, false);
#line 6 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/Foo.cshtml"
       Write(ViewData["Header"]);

#line default
#line hidden
                EndContext();
                BeginContext(115, 20, true);
                WriteLiteral(" </h1>\n        <ul>\n");
                EndContext();
#line 8 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/Foo.cshtml"
             foreach(var item in (string[])ViewData["Items"]){

#line default
#line hidden
                BeginContext(198, 20, true);
                WriteLiteral("                <li>");
                EndContext();
                BeginContext(219, 4, false);
#line 9 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/Foo.cshtml"
               Write(item);

#line default
#line hidden
                EndContext();
                BeginContext(223, 6, true);
                WriteLiteral("</li>\n");
                EndContext();
#line 10 "/home/UserDexter/Documentos/Workspace-GitHub/NetCoreLabs/tiposFracos/Views/Test/Foo.cshtml"
            }

#line default
#line hidden
                BeginContext(243, 18, true);
                WriteLiteral("        </ul>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(268, 9, true);
            WriteLiteral("\n</html>\n");
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